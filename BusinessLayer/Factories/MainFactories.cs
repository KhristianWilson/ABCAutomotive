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
            if (studentid == 0 || Validation.checkStudentIdStuct(studentid))
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
            if (resourceid == 0 || Validation.checkStudentIdStuct(resourceid))
            {
                throw new ArgumentException("Invalid Student ID");
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
