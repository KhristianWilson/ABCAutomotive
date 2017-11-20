using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class Student : Form
    {  
        private Main parent;
        public Student(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region StartUp

        BusinessLayer.Student student;
        List<StudentLookup> StudentList;

        private void Student_Load(object sender, EventArgs e)
        {
            txtSearch.MaxLength = 8;
            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            btninsert.Enabled = false;
            txtstudentID.Enabled = false;
            cbStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbProgram.DataSource = Enum.GetValues(typeof(ProgramType));

        }

        #endregion

        #region Student Searching

        private void btnSearch_Click(object sender, EventArgs e)
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
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(lstSearchResults, ex.Message);
            }
        }

        private void loadStudentInfo()
        {
            txtstudentID.Text = student.studentid.ToString();
            txtfirstName.Text = student.firstName;
            txtlastName.Text = student.lastName;
            txtaddress.Text = student.address;
            txtbalance.Text = student.balanceDue.ToString("c2");
            txtcity.Text = student.city;
            txtphoneNumber.Text = student.phone;
            dtpendDate.Value = student.endDate;
            dtpstartDate.Value = student.startDate;
            cbProgram.SelectedItem = student.programType;
            cbStatus.SelectedItem = student.status;
        }

        #endregion

        #region CUD 

        private void btninsert_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
