using ABCAutomotive.DAL;
using ABCAutomotive.Types;
using System.Collections.Generic;
using System.Data;

namespace ABCAutomotive.SQLLayer
{

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
