using ABCAutomotive.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class Returns : Form
    {
        public Returns()
        {
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
        }

        #endregion

        #region Search Resource

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                int resourceID;

                if (int.TryParse(txtsearchResource.Text, out resourceID))
                {
                    StudentList = StudentsLookupFactory.CreateByResouce(resourceID);
                    loadStudentInfo(StudentList);
                    loadLoanInfo(StudentList[0].StudentID);
                    returnMode();
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsearchResource, ex.Message);
            }
        }

        #endregion

        #region Load Info

        private void loadLoanInfo(int studentID)
        {
            LoansList = LoansLookupFactory.Create(studentID);
            dgvLoans.DataSource = LoansList;
        }

        private void loadStudentInfo(List<StudentLookup> studentList)
        {
            txtfirstName.Text = studentList[0].FirstName;
            txtlastName.Text = studentList[0].LastName;
            txtbalance.Text = studentList[0].Balance.ToString();
            txtprogram.Text = studentList[0].ProgramType.ToString();
            txtstartDate.Text = studentList[0].StartDate.ToShortDateString();
            txtendDate.Text = studentList[0].EndDate.ToShortDateString();
            txtstatus.Text = studentList[0].Status.ToString();
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

        #endregion

        #region Return Action

        private void dgvLoans_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLoans.Focused)
            {
                if (dgvLoans.SelectedCells.Count > 0)
                {
                    int rowindex = dgvLoans.CurrentCell.RowIndex;
                    int columnindex = dgvLoans.CurrentCell.ColumnIndex;

                    txtResourceID.Text = dgvLoans.Rows[rowindex].Cells[columnindex].Value.ToString();
                }
            }
        }

        #endregion

    }
}
