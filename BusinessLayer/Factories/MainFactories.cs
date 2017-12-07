using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System.Drawing;
using System;
using System.Data;
using System.IO;

namespace ABCAutomotive.BusinessLayer
{

    #region Authentication Factory

    public static class AuthenticationFactory
    {
        public static Authentication Create()
        {
            return new Authentication();
        }

        public static Authentication Create(string username, string password)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ConstraintException("Username is required");
            }
            if (!Validation.checkLength(username, 30, SizeOperator.CanBeLessThan))
            {
                throw new ConstraintException("Username must be less than 30 characters");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ConstraintException("Password is required");
            }
            if (!Validation.checkLength(password, 20, SizeOperator.CanBeLessThan))
            {
                throw new ConstraintException("Password must be less than 20 characters");
            }

            int AccessLevel = AuthenticationSQL.Retrieve(username, password);
            return Repackage(AccessLevel);
        }

        private static Authentication Repackage(int AccessLevel)
        {
            Authentication user = new Authentication();
            user._accessLevel = AccessLevel;
            return user;
        }

    }
    

    #endregion

    #region Student Factory

    public static class StudentFactory
    {
        public static Student Create()
        {
            return new Student();
        }

        public static Student Create(int studentid)
        {
            if (studentid == 0 || !Validation.checkLength(studentid.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentException("Invalid Student ID");
            }

            DataTable StuTable = StudentSQL.Retrieve(studentid);
            return Repackage(StuTable.Rows[0]);
        }

        public static Student CreateByResouce(int resourceID)
        {
            if (resourceID == 0 || !Validation.checkLength(resourceID.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentException("Invalid Resource ID");
            }

            DataTable StuTable = StudentSQL.RetrieveOwningStudent(resourceID);
            return Repackage(StuTable.Rows[0]);

        }

        private static Student Repackage(DataRow myRow)
        {
            Student myStudent = new Student();
            myStudent._studentid = Convert.ToInt32(myRow["StudentID"]);
            myStudent._firstName = myRow["FirstName"].ToString();
            myStudent._lastName = myRow["LastName"].ToString();
            myStudent._address = myRow["Address"].ToString();
            myStudent._city = myRow["City"].ToString();
            myStudent._phone = myRow["Phone"].ToString();
            myStudent._postalCode = myRow["PostalCode"].ToString();
            myStudent._balancedue = Convert.ToDouble(myRow["BalanceDue"]);
            myStudent._programType = (ProgramType)(Convert.ToInt32(myRow["Program"]));
            myStudent.status = (StudentStatus)(Convert.ToInt32(myRow["Status"]));
            myStudent._startDate = Convert.ToDateTime(myRow["StartDate"]);
            myStudent._endDate = Convert.ToDateTime(myRow["EndDate"]);
            myStudent._trusted = true;

            return myStudent;
        }
    }

    #endregion

    #region Resource Factory

    public static class ResourceFactory
    {
        public static Resource Create()
        {
            return new Resource();
        }

        public static Resource Create(int resourceid)
        {
            if (resourceid == 0 || !Validation.checkLength(resourceid.ToString(), 8, SizeOperator.MustBeEqualTo)) 
            {
                throw new ArgumentException("Invalid Resource ID");
            }

            DataTable ResouceTable = ResouceSQL.Retrieve(resourceid);
            return Repackage(ResouceTable.Rows[0]);
        }

        public static Resource CreateNotLoaned(int resourceid)
        {
            if (resourceid == 0 || !Validation.checkLength(resourceid.ToString(), 8, SizeOperator.MustBeEqualTo))
            {
                throw new ArgumentException("Invalid Resource ID");
            }

            DataTable ResouceTable = ResouceSQL.RetrieveNonLoaned(resourceid);
            return Repackage(ResouceTable.Rows[0]);
        }


        private static Resource Repackage(DataRow myRow)
        {
            Resource myResource = new Resource();
            myResource._resourceId = Convert.ToInt32(myRow["ResourceID"]);
            myResource._description = myRow["Description"].ToString();
            myResource._title = myRow["Title"].ToString();
            myResource._type = (ResourceType)(Convert.ToInt32(myRow["Type"]));
            myResource._publisher = myRow["Publisher"].ToString();
            myResource._dateOfPurchase = Convert.ToDateTime(myRow["DateOfPurchase"]);
            myResource._price = Convert.ToDouble(myRow["Price"]);
            myResource._referenceNumber = myRow["ReferenceNumber"].ToString();
            myResource._image = (byte[])(myRow["Image"]);
            myResource._status = (ResourceStatus)(Convert.ToInt32(myRow["Status"]));
            myResource._reserveStatus = (ReserveStatus)(Convert.ToInt32(myRow["ReserveStatus"]));
            if(myRow["StudentReserving"].ToString() != string.Empty)
            {
                myResource._reserveingStudent = Convert.ToInt32(myRow["StudentReserving"]);
            }
            if (myRow["DateOfRemoval"].ToString() != string.Empty)
            {
                myResource._removealDate = Convert.ToDateTime(myRow["DateOfRemoval"]);
            }
            else
            {
                myResource._removealDate = default(DateTime);
            }
            myResource._trusted = true;

            return myResource;
        }
    }

    #endregion

    #region Payment Factory

    public static class PaymentFactory
    {
        public static Payment Create()
        {
            return new Payment();
        }
    }
    #endregion

}
