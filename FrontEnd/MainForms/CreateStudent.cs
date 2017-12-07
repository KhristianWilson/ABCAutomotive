using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
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
            setupForm();
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
                    parent.StatusLabel.Text = "Insert Successful StudentID:" + student.studentid;
                }
                else
                {
                    parent.StatusLabel.Text = "Fields Were Left Blank" + " , " + "Insert rejected";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region House Keeping

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

        private void setupForm()
        {
            student = StudentFactory.Create();
            txtstudentID.Enabled = false;
            cbStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbProgram.DataSource = Enum.GetValues(typeof(ProgramType));

            student.startDate = DateTime.Now;
            student.endDate = DateTime.Now.AddDays(10);
            dtpendDate.Value = DateTime.Now.AddDays(10);
            student.status = (StudentStatus)cbStatus.SelectedItem;
            student.programType = (ProgramType)cbProgram.SelectedItem;

            txtfirstName.MaxLength = 20;
            txtlastName.MaxLength = 30;
            txtaddress.MaxLength = 50;
            txtcity.MaxLength = 50;
            txtphoneNumber.MaxLength = 12;
            txtpostalCode.MaxLength = 7;
            parent.StatusLabel.Text = "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbStudentsInfo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.ResetText();
                }
                if(ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndex = -1;
                    (ctrl as ComboBox).SelectedIndex = -1;
                }
            }

            student = StudentFactory.Create();
            dtpendDate.Value = DateTime.Now.AddDays(10);
            dtpstartDate.Value = DateTime.Now;
            student.startDate = dtpstartDate.Value;
            student.endDate = dtpendDate.Value;

            parent.StatusLabel.Text = "";
            errorProvider1.Clear();
        }

        private void txtstudentID_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
            errorProvider1.SetError((sender as Control), "");
        }

        private void CreateStudent_FormClosing(object sender, FormClosingEventArgs e)
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
