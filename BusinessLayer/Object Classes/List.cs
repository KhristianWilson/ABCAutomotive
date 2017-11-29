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

        public int StudentID { get; internal set; }
        public string FirstName { get; internal set; }
        public string LastName { get; internal set; }
        public string FullName { get { return string.Format("{0},{1}", this.FirstName, this.LastName); } }

    }


    #endregion

    #region LoansLookup

    public class LoansLookup
    {
        internal LoansLookup()
        {

        }

        [System.ComponentModel.Browsable(false)]
        public int StudentID { get; internal set; }
        public int ResourceID { get; internal set; }
        public string Title { get; internal set; }
        public ResourceType ResourceType { get; internal set; }
        public DateTime CheckOutDate { get; internal set; }
        public Image Image { get; internal set; }
        public DateTime DueDate { get; internal set; }
    }

    #endregion

}
