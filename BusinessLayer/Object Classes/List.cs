using ABCAutomotive.Types;
using System;
using System.Drawing;

namespace ABCAutomotive.BusinessLayer
{

    #region StudentLookup

    public class StudentLookup
    {
        internal StudentLookup()
        {

        }

        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public double Balance { get; internal set; }
        public ProgramType ProgramType { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public StudentStatus Status { get; internal set; }
    }

    #endregion

    #region LoansLookup

    public class LoansLookup
    {
        internal LoansLookup()
        {

        }

        public int resourceId { get; internal set; }
        public string title { get; internal set; }
        public ResourceType resourceType { get; internal set; }
        public DateTime checkOutDate { get; internal set; }
        public Image image { get; internal set; }
        public DateTime dueDate { get; internal set; }
    }

    #endregion

    #region ResourceLoop

    public class ResourceLookup
    {
        internal ResourceLookup()
        {

        }

        public string title { get; internal set; }
        public ResourceType resourceType { get; internal set; }
        public ReserveStatus reserveStatus { get; internal set; }
        public ResourceStatus resourceStatus { get; internal set; }
    }

    #endregion

}
