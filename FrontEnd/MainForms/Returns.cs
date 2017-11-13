using ABCAutomotive.BusinessLayer;
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
        List<StudentLookup> StudentList;

        private void Returns_Load(object sender, EventArgs e)
        {
            txtsearchResource.MaxLength = 8;
            gbStudentLoans.Visible = false;
            gbStudentsInfo.Visible = false;
            gbReturn.Visible = false;
            dgvLoans.ReadOnly = true;
            parent.StatusLabel.Text = "";
        }

        #endregion

        #region Search Resource

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                int resourceID;

                if (int.TryParse(txtsearchResource.Text, out resourceID) || txtsearchResource.Text.Length == 8)
                {
                    StudentList = StudentsLookupFactory.CreateByResouce(resourceID);
                    loadStudentInfo();
                    loadLoanInfo();
                    returnMode();
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
            LoansList = LoansLookupFactory.Create(StudentList[0].StudentID);
            dgvLoans.DataSource = LoansList;
            (dgvLoans.Columns[4] as DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void loadStudentInfo()
        {
            txtfirstName.Text = StudentList[0].FirstName;
            txtlastName.Text = StudentList[0].LastName;
            txtbalance.Text = StudentList[0].Balance.ToString("c");
            txtprogram.Text = StudentList[0].ProgramType.ToString();
            txtstartDate.Text = StudentList[0].StartDate.ToShortDateString();
            txtendDate.Text = StudentList[0].EndDate.ToShortDateString();
            txtstatus.Text = StudentList[0].Status.ToString();
        }

        #endregion

        #region House Keeping 

        private void returnMode()
        {
            gbStudentLoans.Visible = true;
            gbStudentsInfo.Visible = true;
            gbReturn.Visible = true;
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Returns_Load(null, null);
            txtsearchResource.ResetText();
            StudentList.Clear();
            parent.StatusLabel.Text = "";
        }

        private void refreshStudentInfo()
        {
            int studentID = StudentList[0].StudentID;
            StudentList = StudentsLookupFactory.Create(studentID);
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
