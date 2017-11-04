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

        public string firstName { get; internal set; }
        public string lastName { get; internal set; }
        public double balance { get; internal set; }
        public ProgramType programType { get; internal set; }
        public DateTime startDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public StudentStatus status { get; internal set; }
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
