using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class ManageStudent : Form
    {
        private Main parent;
        public ManageStudent(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region StartUp

        Student student;
        List<StudentLookup> StudentList;

        private void Student_Load(object sender, EventArgs e)
        {
            setupFrom();
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
                editMode(true);
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
            txtpostalCode.Text = student.postalCode;
            dtpendDate.Value = student.endDate;
            dtpstartDate.Value = student.startDate;
            cbProgram.SelectedItem = student.programType;
            cbStatus.SelectedItem = student.status;
        }

        #endregion

        #region UD 

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormIsClean())
                {
                    StudentCUD.Update(student);
                    parent.StatusLabel.Text = ("Update Successful");
                }
                else
                {
                    MessageBox.Show("Fields Were Left Blank", "Update rejected");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update rejected");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete Record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                try
                {
                    Validation.validDelete(student);
                    StudentCUD.Delete(student.studentid);
                    parent.StatusLabel.Text = ("Delete Successful");
                    btnclear_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Delete Failed");
                }
            }
        }

        #endregion

        #region HouseKeeping

        private void setupFrom()
        {
            student = StudentFactory.Create();
            cbStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbProgram.DataSource = Enum.GetValues(typeof(ProgramType));

            btndelete.Enabled = false;
            btnupdate.Enabled = false;
            btnclear.Enabled = false;
            txtstudentID.Enabled = false;
            gbStudentsInfo.Enabled = false;

            txtfirstName.MaxLength = 20;
            txtlastName.MaxLength = 30;
            txtaddress.MaxLength = 50;
            txtcity.MaxLength = 50;
            txtphoneNumber.MaxLength = 12;
            txtpostalCode.MaxLength = 7;
        }

        private void editMode(bool mode)
        {
            btnupdate.Enabled = mode;
            btndelete.Enabled = mode;
            btnclear.Enabled = mode;
            gbStudentsInfo.Enabled = mode;
            btnSearch.Enabled = !mode;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            errorProvider1.SetError((sender as Control), "");
            (sender as TextBox).SelectAll();
        }

        private void txtfirstName_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError((sender as Control), "");
            (sender as TextBox).SelectAll();
        }

        private bool FormIsClean()
        {
            bool isClean = true;

            foreach (Control ctrl in gbStudentsInfo.Controls)
            {
                if (errorProvider1.GetError(ctrl) != string.Empty)
                {
                    isClean = false;
                    break;
                }
                if (ctrl.Text == string.Empty)
                {
                    isClean = false;
                    break;
                }
            }

            return isClean;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbStudentsInfo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.ResetText();
                }
            }

            dtpendDate.Value = DateTime.Now;
            dtpstartDate.Value = DateTime.Now;
            student = StudentFactory.Create();

            cbProgram.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            
            gbSearch.Enabled = true;
            txtSearch.Focus();
            editMode(false);
            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
            lstSearchResults.DataSource = null;
            lstSearchResults.Visible = false;

        }

        private void ManageStudent_Activated(object sender, EventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        #endregion

        #region Validating

        private void txtfirstName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.errorProvider1.SetError((Control)sender, string.Empty);

            try
            {
                if (object.ReferenceEquals(sender, txtfirstName))
                {
                    student.firstName = txtfirstName.Text;
                }
                if (object.ReferenceEquals(sender, txtaddress))
                {
                    student.address = txtaddress.Text;
                }
                if (object.ReferenceEquals(sender, txtbalance))
                {
                    string tempBalance;
                    if (txtbalance.Text.StartsWith("$"))
                    {
                        tempBalance = txtbalance.Text.Remove(0,1);
                    }
                    else
                    {
                        tempBalance = txtbalance.Text;
                    }
                    if (Double.TryParse(tempBalance, out double balance))
                    {
                        student.balanceDue = balance;
                    }
                    else
                    {
                        errorProvider1.SetError(txtbalance, "Balance Must be a decimal amount");
                    }
                }
                if (object.ReferenceEquals(sender, txtcity))
                {
                    student.city = txtcity.Text;
                }
                if (object.ReferenceEquals(sender, txtlastName))
                {
                    student.lastName = txtlastName.Text;
                }
                if (object.ReferenceEquals(sender, txtphoneNumber))
                {
                    student.phone = txtphoneNumber.Text;
                }
                if (object.ReferenceEquals(sender, txtpostalCode))
                {
                    student.postalCode = txtpostalCode.Text;
                }
                if (object.ReferenceEquals(sender, dtpstartDate))
                {
                    student.startDate = dtpstartDate.Value;
                }
                if (object.ReferenceEquals(sender, dtpendDate))
                {
                    student.endDate = dtpendDate.Value;
                }
                if (object.ReferenceEquals(sender, cbProgram))
                {
                    student.programType = (ProgramType)cbProgram.SelectedItem;
                }
                if (object.ReferenceEquals(sender, cbStatus))
                {
                    student.status = (StudentStatus)cbStatus.SelectedItem;
                }
            }
            catch (Exception ex)
            {
                this.errorProvider1.SetError((Control)sender, ex.Message);
            }

        }

        #endregion

    }
}
