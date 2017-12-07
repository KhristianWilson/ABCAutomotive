using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class Reserve : Form
    {
        private Main parent;
        public Reserve(Main p)
        {
            this.parent = p;
            InitializeComponent();
        }

        #region Start Up

        List<StudentLookup> StudentList;
        Student student;
        Resource resource;

        private void Reserve_Load(object sender, EventArgs e)
        {
            setupForm();
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
                    if (Validation.validReserve(resource))
                    {
                        btnReserveResource.Enabled = true;
                        loadResourceInfo();
                        ReserveMode(true);
                    }
                }
                else
                {
                    clearResourceInfo();
                    errorProvider1.SetError(txtsearchResource, "Invalid ResourceID");
                }
            }
            catch (Exception ex)
            {
                clearResourceInfo();
                btnReserveResource.Enabled = false;
                errorProvider1.SetError(txtsearchResource, ex.Message);
            }
        }

        private void loadResourceInfo()
        {
            txttitle.Text = resource.title;
            cbreserved.SelectedItem = resource.reserveStatus;
            txttitle.Text = resource.resourceType.ToString();
            cbresourceStatus.SelectedItem = resource.resourceStatus;
            cbtype.SelectedItem = resource.resourceType;
            btnReserveResource.Enabled = true;
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
                clearStudentInfo();
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }

        private void LstSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int studentID = Convert.ToInt32(lstSearchResults.SelectedValue);
                student = StudentFactory.Create(studentID);
                if (Validation.validStudent(student))
                {
                    btnReserveResource.Enabled = true;
                    loadStudentInfo();
                    errorProvider1.Clear();
                }
            }
            catch (Exception ex)
            {
                clearStudentInfo();
                btnReserveResource.Enabled = false;
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }

        private void loadStudentInfo()
        {
            txtfirstName.Text = student.firstName;
            txtlastName.Text = student.lastName;
            txtbalance.Text = student.balanceDue.ToString("c2");
            cbprogram.SelectedItem = student.programType;
            dtpstartDate.Value = student.startDate;
            dtpendDate.Value = student.endDate;
            cbstudentStatus.SelectedItem = student.status;
        }

        #endregion

        #region House Keeping

        private void setupForm()
        {
            txtsearchResource.MaxLength = 8;
            ReserveMode(false);
            gbResource.Enabled = false;
            gbStudentsInfo.Enabled = false;

            cbstudentStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbprogram.DataSource = Enum.GetValues(typeof(ProgramType));
            cbresourceStatus.DataSource = Enum.GetValues(typeof(ResourceStatus));
            cbreserved.DataSource = Enum.GetValues(typeof(ReserveStatus));
            cbtype.DataSource = Enum.GetValues(typeof(ResourceType));
        }

        private void ReserveMode(bool mode)
        {
            gbResource.Visible = mode;
            gbSearch.Visible = mode;
            gbStudentsInfo.Visible = mode;
            btnReserveResource.Visible = mode;
            btnclear.Visible = mode;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control x in gbStudentsInfo.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = string.Empty;
                }
                if (x is ComboBox)
                {
                    (x as ComboBox).SelectedIndex = -1;
                    (x as ComboBox).SelectedIndex = -1;
                }
                this.errorProvider1.SetError(x, string.Empty);
            }

            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
            lstSearchResults.DataSource = null;
            txtSearch.ResetText();
            txtsearchResource.Focus();
            txtsearchResource.ResetText();
            errorProvider1.SetError(txtSearch, string.Empty);
            ReserveMode(false);
            resource = ResourceFactory.Create();
            student = StudentFactory.Create();
        }

        private void clearStudentInfo()
        {
            foreach (Control x in gbStudentsInfo.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = string.Empty;
                }
                if(x is ComboBox)
                {
                    (x as ComboBox).SelectedIndex = - 1;
                    (x as ComboBox).SelectedIndex = -1;
                }
                this.errorProvider1.SetError(x, string.Empty);
            }
        }

        private void clearResourceInfo()
        {
            foreach (Control x in gbResource.Controls)
            {
                if (x is TextBox | x is ComboBox)
                {
                    x.Text = string.Empty;
                }
                if (x is ComboBox)
                {
                    (x as ComboBox).SelectedIndex = -1;
                    (x as ComboBox).SelectedIndex = -1;
                }
                this.errorProvider1.SetError(x, string.Empty);
            }
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.SetError((sender as Control), "");
            (sender as TextBox).SelectAll();
        }

        private void Reserve_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        #endregion

        #region Reserve Resource

        private void btnReserveResource_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtfirstName.Text))
                {
                    ResourceMethods.ReserveResource(student.studentid, resource.resourceid);
                    parent.StatusLabel.Text = "Resource Reserved";
                }
                else
                {
                    errorProvider1.SetError(txtSearch, "Please search for a student");
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
