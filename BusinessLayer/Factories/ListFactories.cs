using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;

namespace ABCAutomotive.BusinessLayer
{

    #region Loans LookUp

    public static class LoansLookupFactory
    {
        public static List<LoansLookup> Create(int studentId)
        {
            DataTable tmpTable = ListsSQL.RetrieveLoansLookup(studentId);
            List<LoansLookup> newLoansList = new List<LoansLookup>();

            newLoansList = RepackageLoansLookup(tmpTable);
            return newLoansList;
        }

        private static List<LoansLookup> RepackageLoansLookup(DataTable myTable)
        {
            List<LoansLookup> LoansList = new List<LoansLookup>();

            foreach (DataRow Row in myTable.Rows)
            {
                LoansLookup loansLookup = new LoansLookup();
                loansLookup.StudentID = Convert.ToInt32(Row["StudentID"].ToString());
                loansLookup.ResourceID = Convert.ToInt32(Row["ResourceID"]);
                loansLookup.Title = Row["Title"].ToString();
                loansLookup.CheckOutDate = Convert.ToDateTime(Row["CheckOutDate"]);
                loansLookup.DueDate = Convert.ToDateTime(Row["DueDate"]);
                loansLookup.ResourceType = (ResourceType)Convert.ToInt32((Row["Type"]));
                loansLookup.Image = getImage((byte[])Row["Image"]);
                LoansList.Add(loansLookup);
            }
            return LoansList;
        }

        private static Image getImage(byte[] ImageData)
        {
            Image Image;
            if (ImageData == null)
            {
                return null;
            }    
            using (MemoryStream ms = new MemoryStream(ImageData))
            {
                Image = Image.FromStream(ms);
            }
            return Image;
        }
    }

    #endregion

    #region Student LookUp

    public static class StudentsFactory
    {
        public static List<StudentLookup> Create(string studentName)
        {
            DataTable tmpTable = ListsSQL.RetrieveStudentLookup(studentName);
            List<StudentLookup> newStudentsList = new List<StudentLookup>();

            newStudentsList = RepackageStudentLookup(tmpTable);
            return newStudentsList;
        }

        public static List<StudentLookup> Create(int studentID)
        {
            DataTable tmpTable = ListsSQL.RetrieveStudentLookup(studentID);
            List<StudentLookup> newStudentsList = new List<StudentLookup>();

            newStudentsList = RepackageStudentLookup(tmpTable);
            return newStudentsList;
        }

        private static List<StudentLookup> RepackageStudentLookup(DataTable myTable)
        {
            List<StudentLookup> StudentsList = new List<StudentLookup>();

            foreach (DataRow Row in myTable.Rows)
            {
                StudentLookup studentLookup = new StudentLookup();
                studentLookup.StudentID = Convert.ToInt32(Row["StudentID"]);
                studentLookup.FirstName = Row["FirstName"].ToString();
                studentLookup.LastName= Row["LastName"].ToString();
                StudentsList.Add(studentLookup);
            }

            return StudentsList;
        }
    }

    #endregion

    #region OverDue Lookup

    public static class OverDueLookupFactory
    {
        public static List<OverDueLookup> Create()
        {
            DataTable tmpTable = ListsSQL.RetrieveOverdueLookup();
            List<OverDueLookup> newOverdueist = new List<OverDueLookup>();

            newOverdueist = RepackageOverdueLookup(tmpTable);
            return newOverdueist;
        }

        private static List<OverDueLookup> RepackageOverdueLookup(DataTable myTable)
        {
            List<OverDueLookup> OverdueList = new List<OverDueLookup>();

            foreach (DataRow Row in myTable.Rows)
            {
                OverDueLookup OverDueLookup = new OverDueLookup();
                OverDueLookup.Description = Row["Description"].ToString();
                OverDueLookup.StudentID = Convert.ToInt32(Row["StudentID"]);
                OverDueLookup.Price = Convert.ToDouble(Row["Price"]);
                OverDueLookup.FullName = Row["Full Name"].ToString();
                OverDueLookup.ResourceType = (ResourceType)Row["Type"];
                OverdueList.Add(OverDueLookup);
            }

            return OverdueList;
        }
    }

    #endregion

}
