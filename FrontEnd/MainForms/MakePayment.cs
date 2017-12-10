using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class MakePayment : Form
    {
        private Main parent;
        public MakePayment(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region Start Up

        List<StudentLookup> StudentList;
        Student student;
        Payment payment;

        private void MakePayment_Load(object sender, System.EventArgs e)
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
                Validation.ownsBalnce(student);
                loadStudentInfo();
                showInfo(true);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }
        private void loadStudentInfo()
        {
            txtfirstName.Text = student.firstName;
            txtlastName.Text = student.lastName;
            txtbalance.Text = student.balanceDue.ToString("c");
            cbProgram.SelectedItem = student.programType.ToString();
            cbStatus.SelectedItem = student.startDate.ToString();
            dtpstartDate.Value = student.startDate;
            dtpendDate.Value = student.endDate;
            errorProvider1.Clear();
        }

        #endregion

        #region House Keeping

        private void setupForm()
        {
            parent.StatusLabel.Text = "";
            gbpayment.Visible = false;
            gbStudentsInfo.Visible = false;
            gbStudentsInfo.Enabled = false;
            rdoCredit.Checked = true;
            cbStatus.DataSource = Enum.GetValues(typeof(StudentStatus));
            cbProgram.DataSource = Enum.GetValues(typeof(ProgramType));
            student = StudentFactory.Create();
            payment = PaymentFactory.Create();
        }

        private void showInfo(bool mode)
        {
            gbpayment.Enabled = mode;
            gbpayment.Visible = mode;
            gbStudentsInfo.Visible = mode;
            gbSearch.Enabled = !mode;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control x in gbStudentsInfo.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = string.Empty;
                }
                if(x is ComboBox)
                {
                    (x as ComboBox).SelectedIndex = 0;
                    (x as ComboBox).SelectedIndex = 0;
                }
                this.errorProvider1.SetError(x, string.Empty);
            }

            lstSearchResults.SelectedIndexChanged -= LstSearchResults_SelectedIndexChanged;
            lstSearchResults.DataSource = null;
            txtSearch.ResetText();
            showInfo(false);
            student = StudentFactory.Create();
            payment = PaymentFactory.Create();

        }

        private void txtamount_Enter(object sender, EventArgs e)
        {
            errorProvider1.SetError((sender as Control), "");
            (sender as TextBox).SelectAll();
            btnmakePayment.Enabled = true;
        }

        private void MakePayment_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        private void refreshStudentInfo()
        {
            student = StudentFactory.Create(student.studentid);
            loadStudentInfo();
        }

        #endregion

        #region Validating

        private void txtamount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (decimal.TryParse(txtamount.Text, out decimal amount))
                {
                    payment.paymentAmount = amount;
                }
                else
                {
                    errorProvider1.SetError(txtamount, "Amount Must an Decimal Amount");
                    btnmakePayment.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtamount, ex.Message);
            }
        }

        #endregion

        #region Make Payment

        private void btnmakePayment_Click(object sender, EventArgs e)
        {
            try
            {
                payment.paymentDate = DateTime.Now;
                payment.studentId = student.studentid;
                PaymentMethods.MakePayment(payment);
                parent.StatusLabel.Text = "Payment Made";
                refreshStudentInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
