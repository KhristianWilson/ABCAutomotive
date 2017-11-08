using ABCAutomotive.FrontEnd.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        #endregion

        #region HouseKeeping

        private void SetupStatasStrip()
        {
            statusMain.LayoutStyle = ToolStripLayoutStyle.Table;
            lblDateTime.TextAlign = ContentAlignment.MiddleLeft;
            lblDateTime.BorderSides = ToolStripStatusLabelBorderSides.Right;

            lblUser.Text = Environment.UserName;
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            lblUser.BorderSides = ToolStripStatusLabelBorderSides.Right;
        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = System.DateTime.Now.ToShortTimeString();
        }

        #endregion

        #region Display Forms

        private void MenuClick(object sender, EventArgs e)
        {
            if (sender == btnLoans)
            {
                if (loans == null || loans.IsDisposed)
                {
                    loans = new Loans();
                    DisplayForm(loans);
                }
            }
            if (sender == btnReturns)
            {
                if (returns == null || returns.IsDisposed)
                {
                    returns = new Returns();
                    DisplayForm(returns);
                }
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
