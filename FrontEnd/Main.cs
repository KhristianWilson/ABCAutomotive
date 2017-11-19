using ABCAutomotive.FrontEnd.MainForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        #region Start Up

        Loans loans;
        Returns returns;
        Reserve reserves;
        Student student;
        ModifyResourceStatus modifyResourceStatus;

        public ToolStripStatusLabel StatusLabel { get { return this.lblStatus; } set { this.lblStatus = value; } }

        private void Main_Load(object sender, EventArgs e)
        {
            StartUpForms.Splash Splash = new StartUpForms.Splash();
            Splash.ShowDialog();

            StartUpForms.Login login = new StartUpForms.Login();
            login.ShowDialog();
            if (login.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }

            this.Text = Application.ProductName;
            SetupStatasStrip();
            this.WindowState = FormWindowState.Maximized;
        }

        #endregion

        #region House Keeping

        private void SetupStatasStrip()
        {
            statusMain.LayoutStyle = ToolStripLayoutStyle.Table;
            lblDateTime.TextAlign = ContentAlignment.MiddleLeft;
            lblDateTime.BorderSides = ToolStripStatusLabelBorderSides.Right;

            lblUser.Text = Environment.UserName;
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            lblUser.BorderSides = ToolStripStatusLabelBorderSides.Right;

            lblStatus.ForeColor = Color.Red;
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            lblStatus.BorderSides = ToolStripStatusLabelBorderSides.Right;

        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = System.DateTime.Now.ToShortTimeString();
        }

        #endregion

        #region Display Forms

        private void MenuClick(object sender, EventArgs e)
        {
            if (sender == btnLoans || sender == checkOutToolStrip)
            {
                if (loans == null || loans.IsDisposed)
                {
                    loans = new Loans(this);
                }
                DisplayForm(loans);
            }
            if (sender == btnReturns || sender == returnsToolStrip)
            {
                if (returns == null || returns.IsDisposed)
                {
                    returns = new Returns(this);
                }
                DisplayForm(returns);
            }

            if (sender == btnReserves || sender == reserveToolStrip)
            {
                if (reserves == null || reserves.IsDisposed)
                {
                    reserves = new Reserve(this);
                }
                DisplayForm(reserves);
            }

            if (sender == updateResourceToolStrip)
            {
                if (modifyResourceStatus == null || modifyResourceStatus.IsDisposed)
                {
                    modifyResourceStatus = new ModifyResourceStatus(this);
                }
                DisplayForm(modifyResourceStatus);
            }

        }

        private void DisplayForm(Form form)
        {
            if (tabControlMain.Contains(form))
            {
                tabControlMain.TabPages[form].Select();
            }
            else
            {
                tabControlMain.TabPages.Add(form);
            }
        }

        #endregion

    }
}
