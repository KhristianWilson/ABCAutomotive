using ABCAutomotive.BusinessLayer;
using System;
using System.Collections.Generic;
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
                errorProvider1.Clear();
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
                CheckOutMode();
                loadStudentInfo(StudentList);
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lstSearchResults, ex.Message);
            }
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
            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
        }

            #endregion

        }
    }
