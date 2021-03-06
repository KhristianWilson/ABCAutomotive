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
                parent.StatusLabel.Text = "";
                List<OverDueLookup> overDueLoans = OverDueLookupFactory.Create();
                lbldateText.Text = DateTime.Now.ToLongDateString();
                if (overDueLoans.Count <= 0)
                {
                    lblnoRecords.Text = "No Overdue Loans Found";
                }
                else
                {
                    dgvoverDueLoans.DataSource = overDueLoans;
                }
            }
            catch (Exception ex)
            {
                parent.StatusLabel.Text = ex.Message;
            }
        }

        #endregion

        #region House Keeping

        private void OverDueReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        #endregion

    }
}
