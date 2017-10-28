using System.Data;

namespace ABCAutomotive.Types
{

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

    #endregion

    #region Enumerations

    public enum SizeOperator
    {
        MustBeEqualTo,
        CanBeLessThan
    }

    public enum StudentStatus
    {
        NotActive,
        Active
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
        NotReturned,
    }

    #endregion

}
