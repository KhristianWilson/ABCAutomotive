using System;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class addNewUser : Form
    {
        private Main parent;
        public addNewUser(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        private void addNewUser_Load(object sender, EventArgs e)
        {
            parent.StatusLabel.Text = "";
            cbRoles.SelectedIndex = 1;
        }

        private void addNewUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.StatusLabel.Text = "";
        }
    }
}
