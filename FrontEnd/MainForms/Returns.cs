﻿using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class Returns : Form
    {
        private Main parent;
        public Returns(Main p)
        {
            this.parent = p;
            InitializeComponent();
        }

        #region Start Up

        List<LoansLookup> LoansList;
        Student student;

        private void Returns_Load(object sender, EventArgs e)
        {
            setupForm();
        }

        #endregion

        #region Search Resource

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                int resourceID;

                if (int.TryParse(txtsearchResource.Text, out resourceID) && txtsearchResource.Text.Length == 8)
                {
                    student = StudentFactory.CreateByResouce(resourceID);
                    loadStudentInfo();
                    loadLoanInfo();
                    returnMode();
                    foreach (DataGridViewRow row in dgvLoans.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == txtsearchResource.Text)
                        {
                            row.Selected = true;
                            txtResourceID.Text = row.Cells[0].Value.ToString();
                        }
                    }
                }
                else
                {
                    errorProvider1.SetError(txtsearchResource, "Invalid ResourceID");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsearchResource, ex.Message);
            }
        }

        #endregion

        #region Load Info

        private void loadLoanInfo()
        {
            LoansList = LoansLookupFactory.Create(student.studentid);
            dgvLoans.DataSource = LoansList;
            (dgvLoans.Columns[4] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void loadStudentInfo()
        {
            txtfirstName.Text = student.firstName;
            txtlastName.Text = student.lastName;
            txtbalance.Text = student.balanceDue.ToString("c");
            cbprogram.SelectedItem = student.programType;
            dtpstartDate.Value = student.startDate;
            dtpendDate.Value = student.endDate;
            cbstudentStatus.SelectedItem = student.status;
        }

        #endregion

        #region House Keeping 
        private void setupForm()
        {
            dtpendDate.Enabled = false;
            dtpstartDate.Enabled = false;
            cbprogram.Enabled = false;
            cbstudentStatus.Enabled = false;

            txtsearchResource.MaxLength = 8;
            gbStudentLoans.Visible = false;
            gbStudentsInfo.Visible = false;
            gbReturn.Visible = false;
            dgvLoans.ReadOnly = true;
            parent.StatusLabel.Text = "";

            cbstudentStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbprogram.DataSource = Enum.GetValues(typeof(ProgramType));
            rdoNormal.Checked = true;
        }
        private void returnMode()
        {
            gbStudentLoans.Visible = true;
            gbStudentsInfo.Visible = true;
            gbReturn.Visible = true;
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtsearchResource.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Returns_Load(null, null);
            txtsearchResource.ResetText();
            LoansList.Clear();
            student = StudentFactory.Create();
            parent.StatusLabel.Text = "";
        }

        private void refreshStudentInfo()
        {
            int studentID = student.studentid;
            student = StudentFactory.Create(studentID);
            loadStudentInfo();
            loadLoanInfo();
        }

        #endregion

        #region Return Action

        private void dgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoans.Focused)
            {
                if (dgvLoans.SelectedCells.Count > 0)
                {
                    int rowindex = dgvLoans.CurrentCell.RowIndex;
                    int columnindex = 0;

                    txtResourceID.Text = dgvLoans.Rows[rowindex].Cells[columnindex].Value.ToString();
                }
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                int returnStatus = 0;
                int resourceID;
                Int32.TryParse(txtResourceID.Text, out resourceID);
                if (rdoDamged.Checked)
                {
                    returnStatus = 1;
                }
                if (rdoLost.Checked)
                {
                    returnStatus = 2;
                }
                ResourceMethods.CheckInResource(returnStatus, resourceID, chkLate.Checked);
                refreshStudentInfo();
                txtResourceID.ResetText();
                chkLate.Checked = false;
                rdoNormal.Checked = true;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(btnReturn, ex.Message);
            }
        }

        #endregion

    }
}
