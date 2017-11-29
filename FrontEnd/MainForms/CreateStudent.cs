using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class CreateStudent : Form
    {
        private Main parent;
        public CreateStudent(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region Startup

        Student student;

        private void CreateStudent_Load(object sender, EventArgs e)
        {
            txtstudentID.Enabled = false;
            cbStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbProgram.DataSource = Enum.GetValues(typeof(ProgramType));

            student = StudentFactory.Create();
            student.startDate = DateTime.Now;
            student.endDate = DateTime.Now;
            student.status = (StudentStatus)cbStatus.SelectedItem;
            student.programType = (ProgramType)cbProgram.SelectedItem;
        }

        #endregion

        #region Insert

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormIsClean())
                {
                    StudentCUD.Insert(student);
                    txtstudentID.Text = student.studentid.ToString();
                    parent.StatusLabel.Text = ("Insert Successful");
                }
                else
                {
                    MessageBox.Show("Form is not clean", "Insert rejected");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion

        #region HouseKeeping

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
                if (ctrl.Text == string.Empty && ctrl != txtstudentID)
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
            cbProgram.SelectedIndex = -1;
            cbProgram.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            parent.StatusLabel.Text = "";
        }

        private void txtstudentID_Enter(object sender, EventArgs e)
        {
            parent.StatusLabel.Text = "";
            (sender as TextBox).SelectAll();
        }

        private void txtfirstName_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
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
                        tempBalance = txtbalance.Text.Remove(0, 1);
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
