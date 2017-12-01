using ABCAutomotive.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class OverDueReport : Form
    {
        private Main parent;
        public OverDueReport(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region Start Up

        private void OverDueLoans_Load(object sender, System.EventArgs e)
        {
            List<OverDueLookup> overDueLoans = OverDueLookupFactory.Create();
            dgvoverDueLoans.DataSource = overDueLoans;

            lblDate.Text = DateTime.Now.ToLongDateString();

        }

        #endregion

    }
}
