using ABCAutomotive.DAL;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Data;

namespace ABCAutomotive.SQLLayer
{

    #region AuthSQL

    public static class AuthenticationSQL
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

    public static class StudentSQL
    {
        public static DataTable Retrieve(int ID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", ID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetStudentById", parmlist);
        }

        public static DataTable RetrieveOwningStudent(int resourceID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@resourceID", resourceID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetStudentByResource", parmlist);
        }

        public static bool Delete(int stuid)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@studentId", stuid, ParameterDirection.Input, SqlDbType.Int));
            DataAccess.SendData("spdeleteStudent", parmlist);
            return true;
        }

        public static bool Update(IStudent student)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@timestamp", student.TimeStamp, ParameterDirection.InputOutput, SqlDbType.Timestamp));
            parmlist.Add(new ParmStruct("@stuid", student.studentid, ParameterDirection.Input, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@firstName", student.firstName, ParameterDirection.Input, SqlDbType.VarChar, 20));
            parmlist.Add(new ParmStruct("@lastName", student.lastName, ParameterDirection.Input, SqlDbType.VarChar, 30));
            parmlist.Add(new ParmStruct("@address", student.address, ParameterDirection.Input, SqlDbType.VarChar, 50));
            parmlist.Add(new ParmStruct("@postalCode", student.postalCode, ParameterDirection.Input, SqlDbType.Char, 7));
            parmlist.Add(new ParmStruct("@city", student.city, ParameterDirection.Input, SqlDbType.VarChar, 50));
            parmlist.Add(new ParmStruct("@phone", student.phone, ParameterDirection.Input, SqlDbType.Char, 12));
            parmlist.Add(new ParmStruct("@status", student.status, ParameterDirection.Input, SqlDbType.TinyInt));
            parmlist.Add(new ParmStruct("@program", student.status, ParameterDirection.Input, SqlDbType.TinyInt));
            parmlist.Add(new ParmStruct("@startDate", student.startDate, ParameterDirection.Input, SqlDbType.DateTime));
            parmlist.Add(new ParmStruct("@endDate", student.startDate, ParameterDirection.Input, SqlDbType.DateTime));

            DataAccess.SendData("spupdateStudent", parmlist);
            student.TimeStamp = parmlist[0].parmValue;
            return true;
        }

        public static bool Insert(IStudent student)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@timestamp", DBNull.Value, ParameterDirection.InputOutput, SqlDbType.Timestamp));
            parmlist.Add(new ParmStruct("@stuid", student.studentid, ParameterDirection.InputOutput, SqlDbType.Int));
            parmlist.Add(new ParmStruct("@firstName", student.firstName, ParameterDirection.Input, SqlDbType.VarChar, 20));
            parmlist.Add(new ParmStruct("@lastName", student.lastName, ParameterDirection.Input, SqlDbType.VarChar, 30));
            parmlist.Add(new ParmStruct("@address", student.address, ParameterDirection.Input, SqlDbType.VarChar, 50));
            parmlist.Add(new ParmStruct("@postalCode", student.postalCode, ParameterDirection.Input, SqlDbType.Char, 7));
            parmlist.Add(new ParmStruct("@city", student.city, ParameterDirection.Input, SqlDbType.VarChar, 50));
            parmlist.Add(new ParmStruct("@phone", student.phone, ParameterDirection.Input, SqlDbType.Char, 12));
            parmlist.Add(new ParmStruct("@status", student.status, ParameterDirection.Input, SqlDbType.TinyInt));
            parmlist.Add(new ParmStruct("@program", student.status, ParameterDirection.Input, SqlDbType.TinyInt));
            parmlist.Add(new ParmStruct("@startDate", student.startDate, ParameterDirection.Input, SqlDbType.DateTime));
            parmlist.Add(new ParmStruct("@endDate", student.startDate, ParameterDirection.Input, SqlDbType.DateTime));

            DataAccess.SendData("spinsertStudent", parmlist);
            student.TimeStamp = parmlist[0].parmValue;
            student.studentid = Convert.ToInt32(parmlist[1].parmValue);
            return true;
        }
    }

    #endregion

    #region ResouceSQL

    public static class ResouceSQL
    {
        public static DataTable Retrieve(int ID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@resourceId", ID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetResource", parmlist);
        }

        public static DataTable RetrieveNonLoaned(int ID)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@resourceId", ID, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.GetDataTable("spgetResourceNotLoaned", parmlist);
        }
    }

    #endregion

    #region PaymentSQL

    public static class PaymentSQL
    {
        public static bool MakePayment(IPayment payment)
        {
            List<ParmStruct> parmlist = new List<ParmStruct>();
            parmlist.Add(new ParmStruct("@amount", payment.paymentAmount, ParameterDirection.Input, SqlDbType.Decimal));
            parmlist.Add(new ParmStruct("@paymentDate", payment.paymentDate, ParameterDirection.Input, SqlDbType.DateTime));
            parmlist.Add(new ParmStruct("@studentId", payment.studentId, ParameterDirection.Input, SqlDbType.Int));
            return DataAccess.SendData("spmakePayment", parmlist);
        }
    }

    #endregion

}
