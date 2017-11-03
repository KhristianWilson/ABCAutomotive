using ABCAutomotive.Types;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ABCAutomotive.DAL
{
    public sealed class DataAccess
    {
        private DataAccess() { }

        #region Database Access Methods

        public static DataTable GetDataTable(string SQLStatement, List<ParmStruct> parmlist = null)
        {
            SqlCommand cmd = CreateCommandObject(SQLStatement, parmlist);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            UnloadParms(cmd, parmlist);
            return dt;
        }

        public static DataSet GetDataSet(string SQLStatement, List<ParmStruct> parmlist = null)
        {
            SqlCommand cmd = CreateCommandObject(SQLStatement, parmlist);
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.SelectCommand = cmd;
            da.Fill(ds);
            UnloadParms(cmd, parmlist);
            return ds;
        }

        public static int SendData(string SQLStatement, List<ParmStruct> parmlist = null)
        {
            SqlCommand cmd = CreateCommandObject(SQLStatement, parmlist);
            using (cmd.Connection)
            {
                cmd.Connection.Open();
                UnloadParms(cmd, parmlist);
                return cmd.ExecuteNonQuery();
            }
        }

        #endregion

        #region Private Methods

        private static SqlCommand CreateCommandObject(string commond, List<ParmStruct> parms)
        {
            SqlConnection cnn = new SqlConnection(Properties.Settings.Default.CnnString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commond;
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            if (parms != null)
            {
                foreach (ParmStruct x in parms)
                {
                    cmd.Parameters.Add(new SqlParameter(x.parmName, x.datatype, x.size));
                    cmd.Parameters[x.parmName].Value = x.parmValue;
                    cmd.Parameters[x.parmName].Direction = x.direction;
                }
            }
            return cmd;
        }

        private static void UnloadParms(SqlCommand cmd, List<ParmStruct> parms)
        {
            if (parms != null)
            {
                for (int i = 0; i <= parms.Count - 1; i++)
                {
                    ParmStruct x = parms[i];
                    x.parmValue = cmd.Parameters[i].Value;
                    parms[i] = x;
                }
            }
        }

        #endregion

    }
}
