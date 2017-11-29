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
            txtSearch.MaxLength = 50;
            txtsearchResource.MaxLength = 8;
            gbSearch.Visible = true;
            dgvLoans.ReadOnly = true;
            gbStudentsInfo.Visible = false;
            gbStudentLoans.Visible = false;
            gbSearchResource.Visible = false;
            gbResource.Visible = false;
            btncancel.Visible = false;
            btncheckOut.Visible = false;
            btnRemoveItem.Visible = false;
            lstCart.Visible = false;
            parent.StatusLabel.Text = "";
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

                lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
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
                student = StudentFactory.Create(studentID);
                loadStudentInfo();
                loadStudentLoans();
                CheckOutMode();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lstSearchResults, ex.Message);
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
            txtprogram.Text = student.programType.ToString();
            txtstartDate.Text = student.startDate.ToString();
            txtendDate.Text = student.endDate.ToString();
            txtstatus.Text = student.status.ToString();
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
                    resource= ResourceFactory.Create(resouceID);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Loans_Load(null, null);
            parent.StatusLabel.Text = "";
            txtsearchResource.ResetText();
            txtreserveStatus.ResetText();
            txtresourceStatus.ResetText();
            txttitle.ResetText();
            txttype.ResetText();
            loanItems.Clear();
            StudentList.Clear();
            loansLookup.Clear();
            lstSearchResults.DataSource = null;
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
            btnRemoveItem.Visible = true;
            lstCart.Visible = true;
            btnAddtoCart.Enabled = false;
            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
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
            errorProvider1.Clear();
            DialogResult result = DialogResult.None;
            if (resource.reserveStatus == ReserveStatus.Reserved)
            {
                Student ReserveingStudent = StudentFactory.CreateByResouce(resource.resourceid);
                string message = "Resource is reserved \n" + "Is The Student \n" + "Student ID: " + ReserveingStudent.studentid + "\nStudent Name: " + ReserveingStudent.firstName + ", " + ReserveingStudent.lastName;
                result = MessageBox.Show(message, "Reserved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            }

            if (result == DialogResult.Yes || result == DialogResult.None)
            {
                addItem();
            }
            else
            {
                parent.StatusLabel.Text = "Unable to Checkout Resource";
            }
        }

        private void addItem()
        {
            if (CheckResource())
            {
                loanItems.Add(new LoanItem(resource.resourceid, txttitle.Text, GetDueDate()));
                lstCart.ValueMember = "resourceID";
                lstCart.DisplayMember = "titleDueDate";
                lstCart.DataSource = loanItems;
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
                    parent.StatusLabel.Text = "Items Added To Student Loans";
                }
                else
                {
                    errorProvider1.SetError(btncheckOut, "Please Select A Resource");
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

