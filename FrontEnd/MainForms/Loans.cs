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
        private Main parent;
        public Loans(Main p)
        {
            this.parent = p;
            InitializeComponent();
        }

        #region Start Up

        List<StudentLookup> StudentList;
        List<LoansLookup> loansLookup;
        Resource resource;
        Student student;
        BindingList<LoanItem> loanItems = new BindingList<LoanItem>();

        private void Loans_Load(object sender, System.EventArgs e)
        {
            setupForm();
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
                    if (x.ToString().Length != 8)
                    {
                        errorProvider1.SetError(txtSearch, "Invalid StudentID");
                    }
                    else
                    {
                        StudentList = StudentsFactory.Create(x);
                    }
                }
                else
                {
                    StudentList = StudentsFactory.Create(txtSearch.Text);
                }
                lstSearchResults.Visible = true;
                lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
                lstSearchResults.ValueMember = "StudentID";
                lstSearchResults.DisplayMember = "FullName";
                lstSearchResults.DataSource = StudentList;
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
                student = StudentFactory.Create(studentID);
                Validation.validStudent(student);
                loadStudentInfo();
                loadStudentLoans();
                CheckOutMode(true);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }

        private void loadStudentLoans()
        {
            loansLookup = LoansLookupFactory.Create(student.studentid);
            dgvLoans.DataSource = loansLookup;
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

        #region Resource Searching 

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                int resouceID = 0;
                if (Int32.TryParse(txtsearchResource.Text, out resouceID) && txtsearchResource.Text.Length == 8)
                {
                    resource = ResourceFactory.Create(resouceID);
                    Validation.activeResource(resource);
                    Validation.checkreserved(student, resource);
                    loadResourceInfo();
                    btnAddtoCart.Enabled = true;
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

        private void loadResourceInfo()
        {
            txttitle.Text = resource.title;
            txtreserveStatus.Text = resource.reserveStatus.ToString();
            txttype.Text = resource.resourceType.ToString();
            txtresourceStatus.Text = resource.resourceStatus.ToString();
        }


        #endregion

        #region House Keeping

        private void setupForm()
        {
            txtSearch.MaxLength = 50;
            txtsearchResource.MaxLength = 8;
            gbSearch.Visible = true;
            dgvLoans.ReadOnly = true;
            dtpendDate.Enabled = false;
            dtpstartDate.Enabled = false;
            cbprogram.Enabled = false;
            cbstudentStatus.Enabled = false;
            CheckOutMode(false);
            parent.StatusLabel.Text = "";
            cbstudentStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbprogram.DataSource = Enum.GetValues(typeof(ProgramType));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearResourceSearch();
            parent.StatusLabel.Text = "";
            CheckOutMode(false);
            errorProvider1.Clear();
            loanItems.Clear();
            StudentList.Clear();
            loansLookup.Clear();
            student = StudentFactory.Create();
            resource = ResourceFactory.Create();
            lstSearchResults.DataSource = null;
            lstCart.DataSource = null;

        }

        private void clearResourceSearch()
        {
            foreach (Control x in gbResource.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = string.Empty;
                }
                this.errorProvider1.SetError(x, string.Empty);
            }
        }

        private void CheckOutMode(bool mode)
        {
            gbSearch.Visible = !mode;
            gbStudentsInfo.Visible = mode;
            gbStudentLoans.Visible = mode;
            gbSearchResource.Visible = mode;
            gbResource.Visible = mode;
            plCheckOut.Visible = mode;
            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.SetError((sender as Control), "");
            (sender as TextBox).SelectAll();
        }

        private void Loans_Activated(object sender, EventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstCart.SelectedIndex >= 0)
            {
                loanItems.Remove((LoanItem)lstCart.SelectedItem);
            }
            errorProvider1.Clear();
        }

        #endregion

        #region CheckOut Process

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.validResourceCheckout(loansLookup, loanItems, resource);
                addItem();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(btnAddtoCart, ex.Message);
            }
        }

        private void addItem()
        {
            if (CheckResource())
            {
                loanItems.Add(new LoanItem(resource.resourceid, txttitle.Text, GetDueDate(), resource.resourceType));
                lstCart.ValueMember = "resourceID";
                lstCart.DisplayMember = "titleDueDate";
                lstCart.DataSource = loanItems;
                errorProvider1.Clear();
            }
        }

        private bool CheckResource()
        {
            foreach (LoanItem item in loanItems)
            {
                if (item.resourceID == resource.resourceid)
                {
                    errorProvider1.SetError(btnAddtoCart, "Resource In Cart");
                    return false;
                }
            }
            return true;
        }

        private DateTime GetDueDate()
        {
            DateTime now = DateTime.Now;
            DateTime dueDate;
            DayOfWeek day = now.DayOfWeek;

            if (Convert.ToInt32(day) == 4 || Convert.ToInt32(day) == 5)
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
                if (lstCart.Items.Count != 0)
                {
                    errorProvider1.Clear();
                    for (int i = 0; i < lstCart.Items.Count; i++)
                    {
                        lstCart.SelectedIndex = i;
                        int resourceID = Convert.ToInt32(lstCart.SelectedValue);
                        ResourceMethods.CheckOutResource(student.studentid, resourceID);
                    }
                    loadStudentLoans();
                    loanItems.Clear();
                    clearResourceSearch();
                    parent.StatusLabel.Text = "Items Added To Student Loans";
                }
                else
                {
                    errorProvider1.SetError(txtsearchResource, "Please Select A Resource");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}

