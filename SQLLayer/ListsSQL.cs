﻿using ABCAutomotive.DAL;
using ABCAutomotive.Types;
using System.Collections.Generic;
using System.Data;

namespace ABCAutomotive.SQLLayer
{
    public static class ListsSQL
    {

        #region Student Lookups

        public static DataTable RetrieveStudentLookup(string studentName)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@search", studentName, ParameterDirection.Input, SqlDbType.VarChar, 50));
            return DataAccess.GetDataTable("spgetStudentByName", parmlist);
        }

        public static DataTable RetrieveStudentLookup(int studentId)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", studentId, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetStudentById", parmlist);
        }

        #endregion

        #region Loan Lookup

        public static DataTable RetrieveLoansLookup(int studentId)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", studentId, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetLoansByStudentID", parmlist);
        }

        #endregion

        #region Overdue Lookup

        public static DataTable RetrieveOverdueLookup()
        {
            return DataAccess.GetDataTable("spoverDueChangesReport");
        }

        #endregion

    }
}
