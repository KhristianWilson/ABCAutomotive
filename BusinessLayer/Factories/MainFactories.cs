using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System;
using System.Data;

namespace ABCAutomotive.BusinessLayer
{

    #region StudentFactory

    public static class StudentFactory
    {
        public static Student Create()
        {
            return new Student();
        }

        public static Student Create(int studentid)
        {
            if (studentid == 0 || Validation.checkLength(studentid.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentException("Invalid Student ID");
            }

            DataTable EmpTable = StudentSQL.Retrieve(studentid);
            return Repackage(EmpTable.Rows[0]);
        }

        public static Student Create(string name)
        {
            if (string.IsNullOrEmpty(name) || Validation.checkLength(name, 30, SizeOperator.CanBeLessThan))
            {
                throw new ArgumentException("Invalid Student Name");
            }

            DataTable StudentTable = StudentSQL.Retrieve(name);
            return Repackage(StudentTable.Rows[0]);
        }

        private static Student Repackage(DataRow myRow)
        {
            Student myStudent = new Student();
            myStudent._studentid = Convert.ToInt16(myRow["StudentID"]);
            myStudent._firstName = myRow["FirstName"].ToString();
            myStudent._lastName = myRow["LastName"].ToString();
            myStudent._address = myRow["Address"].ToString();
            myStudent._city = myRow["City"].ToString();
            myStudent._phone = myRow["Phone"].ToString();
            myStudent._postalCode = myRow["PostalCode"].ToString();
            myStudent._balancedue = Convert.ToDouble(myRow["BalanceDue"]);
            myStudent._programType = (ProgramType)myRow["Program"];
            myStudent.status = (StudentStatus)myRow["Status"];
            myStudent._startDate = Convert.ToDateTime(myRow["StartDate"]);
            myStudent._endDate = Convert.ToDateTime(myRow["EndDate"]);
            myStudent._timeStamp = myRow["TimeStamp"];
            myStudent._trusted = true;

            return myStudent;
        }
    }

    #endregion

    #region ResourceFactory

    public static class ResourceFactory
    {
        public static Resource Create()
        {
            return new Resource();
        }

        public static Resource Create(int resourceid)
        {
            if (resourceid == 0 || Validation.checkLength(resourceid.ToString(), 8, SizeOperator.MustBeEqualTo)) 
            {
                throw new ArgumentException("Invalid Resource ID");
            }

            DataTable ResouceTable = ResouceSQL.Retrieve(resourceid);
            return Repackage(ResouceTable.Rows[0]);
        }

        private static Resource Repackage(DataRow myRow)
        {
            Resource myResource = new Resource();

            myResource._trusted = true;

            return myResource;
        }
    }

    #endregion

}
