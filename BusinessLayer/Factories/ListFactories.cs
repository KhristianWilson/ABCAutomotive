using ABCAutomotive.SQLLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

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
                loansLookup.resourceId = Convert.ToInt32(Row["ResourceID"]);
                loansLookup.title = Row["Title"].ToString();
                loansLookup.checkOutDate = Convert.ToDateTime(Row["CheckOutDate"]);
                loansLookup.dueDate = Convert.ToDateTime(Row["DueDate"]);
                loansLookup.resourceType = (ResourceType)(Row["Type"]);
                loansLookup.image = (Image)Row["Image"];
                LoansList.Add(loansLookup);
            }

            return LoansList;
        }
    }

    #endregion

    #region Student LookUp

    public static class StudentsLookupFactory
    {
        public static List<StudentLookup> Create(string studentName)
        {
            DataTable tmpTable = ListsSQL.RetrieveStudentLookup(studentName);
            List<StudentLookup> newStudentsList = new List<StudentLookup>();

            newStudentsList = RepackageStudentLookup(tmpTable);
            return newStudentsList;

        }

        public static List<StudentLookup> Create(int studentid)
        {
            DataTable tmpTable = ListsSQL.RetrieveStudentLookup(studentid);
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
                studentLookup.Balance = Convert.ToDouble(Row["BalanceDue"]);
                studentLookup.ProgramType = (ProgramType)(Convert.ToInt32(Row["Program"]));
                studentLookup.Status= (StudentStatus)(Convert.ToInt32(Row["Status"]));
                studentLookup.EndDate = Convert.ToDateTime(Row["EndDate"]);
                studentLookup.StartDate = Convert.ToDateTime(Row["StartDate"]);
                StudentsList.Add(studentLookup);
            }

            return StudentsList;
        }
    }

    #endregion

    #region Resource LookUp

    public static class ResourceLookupFactory
    {
        public static List<ResourceLookup> Create(int resourceId)
        {
            DataTable tmpTable = ListsSQL.RetrieveResourceLookup(resourceId);
            List<ResourceLookup> newResourceList = new List<ResourceLookup>();

            newResourceList = RepackageResourceLookup(tmpTable);
            return newResourceList;
        }

        private static List<ResourceLookup> RepackageResourceLookup(DataTable myTable)
        {
            List<ResourceLookup> resourceList = new List<ResourceLookup>();

            foreach (DataRow Row in myTable.Rows)
            {
                ResourceLookup resourceLookup = new ResourceLookup();
                resourceLookup.resourceID = Convert.ToInt32(Row["ResourceID"]);
                resourceLookup.title = Row["Title"].ToString();
                resourceLookup.resourceType = (ResourceType)(Convert.ToInt32(Row["Type"]));
                resourceLookup.reserveStatus= (ReserveStatus)(Convert.ToInt32(Row["ReserveStatus"]));
                resourceLookup.resourceStatus = (ResourceStatus)(Convert.ToInt32(Row["Status"]));
                resourceList.Add(resourceLookup);
            }

            return resourceList;
        }
    }

    #endregion

}
