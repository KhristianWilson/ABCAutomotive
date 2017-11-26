﻿using ABCAutomotive.BusinessLayer;
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
        List<ResourceLookup> ResourceList;

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
                    ResourceList = ResourceLookupFactory.Create(resouceID);
                    loadResourceInfo(ResourceList);
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

        private void loadResourceInfo(List<ResourceLookup> resourceLookup)
        {
            txttitle.Text = resourceLookup[0].title;
            txtreserveStatus.Text = resourceLookup[0].reserveStatus.ToString();
            txttype.Text = resourceLookup[0].resourceType.ToString();
            txtresourceStatus.Text = resourceLookup[0].resourceStatus.ToString();
            btnReserveResource.Enabled = true;
            Validation.validReserve(resourceLookup[0]);
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
                StudentList = StudentsFactory.Create(studentID);
                Validation.validStudent(StudentList[0]);
                btnReserveResource.Enabled = true;
                loadStudentInfo(StudentList);   
            }
            catch (Exception ex)
            {
                btnReserveResource.Enabled = false;
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }

        private void loadStudentInfo(List<StudentLookup> studentList)
        {
            txtfirstName.Text = studentList[0].FirstName;
            txtlastName.Text = studentList[0].LastName;
            txtbalance.Text = studentList[0].Balance.ToString("c2");
            txtprogram.Text = studentList[0].ProgramType.ToString();
            txtstartDate.Text = studentList[0].StartDate.ToShortDateString();
            txtendDate.Text = studentList[0].EndDate.ToShortDateString();
            txtstatus.Text = studentList[0].Status.ToString();
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
                ResourceMethods.ReserveResource(StudentList[0].StudentID, ResourceList[0].resourceID);
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
