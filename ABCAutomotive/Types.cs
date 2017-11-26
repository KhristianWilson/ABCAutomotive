using System;
using System.Data;
using System.Drawing;

namespace ABCAutomotive.Types
{

    #region Interfaces

    public interface IStudent
    {

        int studentid { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string address { get; set; }
        string postalCode { get; set; }
        string city { get; set; }
        string phone { get; set; }
        ProgramType programType { get; set; }
        StudentStatus status { get; set; }
        DateTime startDate { get; set; }
        DateTime endDate { get; set; }
        object TimeStamp { get; set; }

    }

    public interface IResource
    {
        int resourceid { get; set; }
        string description { get; set; }
        string title { get; set; }
        string publisher { get; set; }
        string referenceNumber { get; set; }
        Image image { get; set; }
        ResourceStatus resourceStatus { get; set; }
        ResourceType resourceType { get; set; }
        DateTime purchaseDate { get; set; }
        double price { get; set; }
        object TimeStamp { get; set; }
    }

    public interface IPayment
    {
        int paymentId { get; set; }
        DateTime paymentDate { get; set; }
        decimal paymentAmount { get; set; }
        int studentId { get; set; }
    }

    #endregion

    #region Structures

    public struct ParmStruct
    {
        public string parmName;
        public object parmValue;
        public ParameterDirection direction;
        public SqlDbType datatype;
        public short size;

        public ParmStruct(string parmname, object parmvalue, ParameterDirection direction, SqlDbType sqlDbType, short size = 0)
        {
            this.parmName = parmname;
            this.parmValue = parmvalue;
            this.direction = direction;
            this.datatype = sqlDbType;
            this.size = size;
        }
    }

    public struct LoanItem
    {
        public int resourceID { get; internal set; }
        public string titleDueDate { get; internal set; }

        public LoanItem(int resourceID, string title, DateTime dueDate)
        {
            this.resourceID = resourceID;
            this.titleDueDate = title + " Due: " + dueDate.ToShortDateString();
        }
    }

    #endregion

    #region Enumerations

    public enum SizeOperator
    {
        MustBeEqualTo,
        CanBeLessThan
    }

    public enum StudentStatus
    {
        Active,
        Inactive
    }

    public enum ProgramType
    {
        RegularProgram,
        BlockRelease
    }

    public enum ResourceType
    {
        DVD,
        ReferenceManual,
        ReferenceBook
    }

    public enum ResourceStatus
    {
        Available,
        OnLoan,
        NotAvailable
    }

    public enum ReserveStatus
    {
        Reserved,
        NotReserved
    }

    public enum LoanStatus
    {
        OnLoan,
        Returned,
        ReturnedDamaged,
        NotReturned
    }

    public enum LookupTypes
    {
        StudentLookup,
        LoansLookup,
        ResourceLookup
    }

    #endregion

}
