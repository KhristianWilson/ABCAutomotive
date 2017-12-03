using ABCAutomotive.BusinessLayer;
using System;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.StartUpForms
{
    public partial class Login : Form
    {
        private Authentication user;

        private Main parent;
        public Login(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region StartUp

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            this.CancelButton = btnCancel;
            this.Text = Application.ProductName;
            txtUsername.Text = Environment.UserName;
            txtPassword.Text = Properties.Settings.Default.password;
            if (txtPassword.Text != String.Empty)
            { chkRemember.Checked = true; }
            txtPassword.MaxLength = 20;
            txtUsername.MaxLength = 30;
        }

        #endregion

        #region Login

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                user = AuthenticationFactory.Create(txtUsername.Text, txtPassword.Text);
                SavePassword();
                if(user.AccessLevel != 0)
                {
                    DialogResult = DialogResult.OK;
                    parent.accessLevel = user.AccessLevel;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                errorProvider.SetError(txtUsername, ex.Message);
            }
        }

        #endregion

        #region HouseKeeping

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void SavePassword()
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.password = txtPassword.Text;
            }
            else
            {
                Properties.Settings.Default.password = String.Empty;
            }
            Properties.Settings.Default.Save();
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrEmpty(textBox.Text))
            {
                errorProvider.SetError(textBox, "Required");
            }
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            errorProvider.Clear();
            (sender as TextBox).SelectAll();
        }

        #endregion

    }
}
