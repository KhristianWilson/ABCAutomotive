using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class Loans : Form
    {
        public Loans()
        {
            InitializeComponent();
        }

        #region Start Up

        List<StudentLookup> StudentList;
        List<ResourceLookup> ResourceLookup;
        List<LoansLookup> loansLookup;
        BindingList<LoanItem> loanItems = new BindingList<LoanItem>();

        private void Loans_Load(object sender, System.EventArgs e)
        {
            lstSearchResults.Visible = false;
            txtSearch.MaxLength = 50;
            txtsearchResource.MaxLength = 8;
            gbSearch.Visible = true;
            gbStudentsInfo.Visible = false;
            gbStudentLoans.Visible = false;
            gbSearchResource.Visible = false;
            gbResource.Visible = false;
            btncancel.Visible = false;
            btncheckOut.Visible = false;
            lstCart.Visible = false;
        }

        #endregion

        #region Student Searching

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                int x;

                if (int.TryParse(txtSearch.Text, out x))
                {
                    StudentList = StudentsLookupFactory.Create(x);
                }
                else
                {
                    StudentList = StudentsLookupFactory.Create(txtSearch.Text);
                }

                lstSearchResults.ValueMember = "StudentID";
                lstSearchResults.DisplayMember = "FullName";
                lstSearchResults.DataSource = StudentList;
                lstSearchResults.Visible = true;
                lstSearchResults.SelectedIndexChanged += LstSearchResults_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }

        private void LstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(lstSearchResults.SelectedValue);
                StudentList = StudentsLookupFactory.Create(studentID);
                loadStudentInfo(StudentList);
                loadStudentLoans(studentID);
                CheckOutMode();
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lstSearchResults, ex.Message);
            }
        }

        private void loadStudentLoans(int studentID)
        {
            loansLookup = LoansLookupFactory.Create(studentID);
            dgvLoans.DataSource = loansLookup;
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

        #region Resource Searching 

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceLookup = ResourceLookupFactory.Create(Convert.ToInt32(txtsearchResource.Text));
                loadResourceInfo(ResourceLookup);
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsearchResource, ex.Message);
            }
        }

        private void loadResourceInfo(List<ResourceLookup> resourceLookup)
        {
            txttitle.Text = resourceLookup[0].title;
            txtreserveStatus.Text = resourceLookup[0].reserveStatus.ToString();
            txttype.Text = resourceLookup[0].resourceType.ToString();
            txtresourceStatus.Text = resourceLookup[0].resourceStatus.ToString();
        }


        #endregion

        #region House Keeping

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Loans_Load(null, null);
            txtsearchResource.ResetText();
            txtreserveStatus.ResetText();
            txtresourceStatus.ResetText();
            txttitle.ResetText();
            txttype.ResetText();
            lstCart.DataSource = null;
        }

        private void CheckOutMode()
        {
            gbSearch.Visible = false;
            gbStudentsInfo.Visible = true;
            gbStudentLoans.Visible = true;
            gbSearchResource.Visible = true;
            gbResource.Visible = true;
            btncancel.Visible = true;
            btncheckOut.Visible = true;
            lstCart.Visible = true;
            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        #endregion

        #region CheckOut Process

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            foreach(LoanItem item in loanItems)
            {
                if(item.resourceID == ResourceLookup[0].resourceID)
                {
                    errorProvider1.SetError(btnAddtoCart, "Resource In Cart");
                    return;
                }
            }

            loanItems.Add(new LoanItem(ResourceLookup[0].resourceID, txttitle.Text, GetDueDate()));
            lstCart.ValueMember = "resourceID";
            lstCart.DisplayMember = "titleDueDate";
            lstCart.DataSource = loanItems;
        }

        private DateTime GetDueDate()
        {
            DateTime now = DateTime.Now;
            DateTime dueDate;
            DayOfWeek day = now.DayOfWeek;

            if(Convert.ToInt32(day) == 4 || Convert.ToInt32(day) == 5)
            {
                dueDate = now.AddDays(4);
            }
            else
            {
                dueDate = now.AddDays(2);
            }
            return dueDate;

        }

        private void btncheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                if(lstCart.Items.Count == 0)
                {
                    errorProvider1.SetError(btncheckOut, "Please Select A Resource");
                    return;
                }
                errorProvider1.Clear();
                for (int i = 0; i < lstCart.Items.Count; i++)
                {
                    lstCart.SelectedIndex = i;

                    int resourceID = Convert.ToInt32(lstCart.SelectedValue);
                    ResourceMethods.CheckOutResource(StudentList[0].StudentID, resourceID);
                }
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(btncheckOut, ex.Message);
            }
        }

        #endregion

    }
}

