using ABCAutomotive.BusinessLayer;
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
            txtsearchResource.MaxLength = 8;
            gbResource.Visible= false;
            gbSearch.Visible = false;
            gbStudentsInfo.Visible = false;
            btnReserveResource.Visible = false;
            btnclear.Visible = false;
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
                    loadResourceInfo();
                    ReserveMode();
                }
                else
                {
                    errorProvider1.SetError(txtsearchResource, "Invalid ResourceID");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsearchResource, ex.Message);
                btnReserveResource.Enabled = false;
            }
        }

        private void loadResourceInfo()
        {
            txttitle.Text = resource.title;
            txtreserveStatus.Text = resource.reserveStatus.ToString();
            txttype.Text = resource.resourceType.ToString();
            txtresourceStatus.Text = resource.resourceStatus.ToString();
            btnReserveResource.Enabled = true;
            Validation.validReserve(resource);
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
                Validation.validStudent(student);
                btnReserveResource.Enabled = true;
                loadStudentInfo();   
            }
            catch (Exception ex)
            {
                btnReserveResource.Enabled = false;
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }

        private void loadStudentInfo()
        {
            txtfirstName.Text = student.firstName;
            txtlastName.Text = student.lastName;
            txtbalance.Text = student.balanceDue.ToString("c2");
            txtprogram.Text = student.programType.ToString();
            txtstartDate.Text = student.startDate.ToString();
            txtendDate.Text = student.endDate.ToString();
            txtstatus.Text = student.status.ToString();
        }

        #endregion

        #region House Keeping

        private void ReserveMode()
        {
            gbResource.Visible = true;
            gbSearch.Visible = true;
            gbStudentsInfo.Visible = true;
            btnReserveResource.Visible = true;
            btnclear.Visible = true;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            Reserve_Load(null, null);
            foreach (Control x in gbStudentsInfo.Controls)
            {
                if (x is TextBox | x is ComboBox)
                {
                    x.Text = string.Empty;
                }
                this.errorProvider1.SetError(x, string.Empty);
            }

            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
            lstSearchResults.DataSource = null;
            txtSearch.ResetText();
            resource = ResourceFactory.Create();
            student = StudentFactory.Create();
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            parent.StatusLabel.Text = "";
        }

        #endregion

        #region Reserve Resource

        private void btnReserveResource_Click(object sender, EventArgs e)
        {
            try
            {
                ResourceMethods.ReserveResource(student.studentid, resource.resourceid);
                parent.StatusLabel.Text = "Resource Reserved";
                btnclear_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
