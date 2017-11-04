using ABCAutomotive.DAL;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace ABCAutomotive.SQLLayer
{

    #region AuthSQL

    public class AuthenticationSQL
    {
        public static int Retrieve(string username, string password)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@userId", username, ParameterDirection.Input, SqlDbType.VarChar, 30));
            parmlist.Add(new ParmStruct("@password", password, ParameterDirection.Input, SqlDbType.VarChar, 20));
            parmlist.Add(new ParmStruct("@accessLevel", 0, ParameterDirection.Output, SqlDbType.Int));
            DataAccess.GetDataTable("spauthenticate", parmlist);
            return Convert.ToInt16(parmlist[2].parmValue);
        }

    }

    #endregion

    #region StudentSQL

    public class StudentSQL
    {
        public static DataTable Retrieve(int ID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", ID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetStudentById", parmlist);
        }

        public static DataTable Retrieve(string name)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@search ", name, ParameterDirection.Input, SqlDbType.VarChar, 30));
            return DataAccess.GetDataTable("spgetStudentByName", parmlist);
        }
    }

    #endregion

    #region ResouceSQL

    public class ResouceSQL
    {
        public static DataTable Retrieve(int ID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@resourceId", ID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetResource", parmlist);
        }
    }

    #endregion

}
