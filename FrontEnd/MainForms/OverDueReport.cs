﻿using ABCAutomotive.BusinessLayer;
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
            try
            {
                List<OverDueLookup> overDueLoans = OverDueLookupFactory.Create();
                dgvoverDueLoans.DataSource = overDueLoans;
                if (overDueLoans.Count < 0)
                {
                    lblnoRecords.Text = "No Overdue Loans Found";
                }
                lblDate.Text = DateTime.Now.ToLongDateString();
            }
            catch (Exception ex)
            {
                parent.StatusLabel.Text = ex.Message;
            }
        }

        #endregion

        #region House Keeping

        private void OverDueReport_Activated(object sender, EventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        #endregion

    }
}
