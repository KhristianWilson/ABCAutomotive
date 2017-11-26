using ABCAutomotive.BusinessLayer;
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

        #region StartUp

        List<StudentLookup> StudentList;
        Payment payment;

        private void MakePayment_Load(object sender, System.EventArgs e)
        {
            gbpayment.Visible = false;
            gbStudentsInfo.Visible = false;
            gbStudentsInfo.Enabled = false;
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
                loadStudentInfo(StudentList);
                showInfo();
            }
            catch (Exception ex)
            {
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

        private void showInfo()
        {
            gbpayment.Enabled = true;
            gbpayment.Visible = true;
            gbStudentsInfo.Visible = true;
            parent.StatusLabel.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MakePayment_Load(null, null);
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

        private void txtamount_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        #endregion

        #region Validating

        private void txtamount_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(decimal.TryParse(txtamount.Text, out decimal amount))
            {
                if(amount <= 0)
                {
                    errorProvider1.SetError(txtamount, "Amount Must Be Greater Than 0.00");
                    btnmakePayment.Enabled = false;
                }
            }
            else
            {
                errorProvider1.SetError(txtamount, "Amount Must an Decimal Amount");
                btnmakePayment.Enabled = false;
            }
            btnmakePayment.Enabled = true;
        }

        #endregion

        #region Make Payment

        private void btnmakePayment_Click(object sender, EventArgs e)
        {
            try
            {
                payment = PaymentFactory.Create();
                payment.paymentAmount = Convert.ToDecimal(txtamount.Text);
                payment.paymentDate = DateTime.Now;
                payment.studentId = StudentList[0].StudentID;
                PaymentMethods.MakePayment(payment);
                parent.StatusLabel.Text = "Payment Made";
                btnCancel_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

    }
}
