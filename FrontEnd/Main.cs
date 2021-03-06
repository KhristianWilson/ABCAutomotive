﻿using ABCAutomotive.FrontEnd.MainForms;
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
        ManageStudent student;
        ModifyResourceStatus modifyResourceStatus;
        CreateStudent createStudent;
        MakePayment makePayment;
        AddResource addResource;
        OverDueReport overDueLoans;
        addNewUser addNewUser;

        public ToolStripStatusLabel StatusLabel { get { return this.lblStatus; } set { this.lblStatus = value; } }

        private void Main_Load(object sender, EventArgs e)
        {
            StartUpForms.Splash Splash = new StartUpForms.Splash();
            Splash.ShowDialog();

            StartUpForms.Login login = new StartUpForms.Login(this);
            login.ShowDialog();

            if (login.DialogResult == DialogResult.Cancel)
            {
                this.Close();
            }
            else
            {
                setupForm();
            }
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
            lblStatus.Text = "Welcome";

            lblRole.TextAlign = ContentAlignment.MiddleLeft;
            lblRole.BorderSides = ToolStripStatusLabelBorderSides.Right;

        }

        private void setupForm()
        {
            this.Text = Application.ProductName;
            SetupStatasStrip();
            this.WindowState = FormWindowState.Maximized;

            if (Properties.Settings.Default.accessLevel == 2)
            {
                addResourceToolStrip.Enabled = true;
                newUserToolStripMenuItem.Enabled = true;
                lblRole.Text = "Admin";
            }
            else
            {
                lblRole.Text = "Instructor";
            }
        }

        private void timerDisplay_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = System.DateTime.Now.ToShortTimeString();
        }

        #endregion

        #region Display Forms

        private void MenuClick(object sender, EventArgs e)
        {
            if(sender == aboutToolStripMenuItem)
            {
                StartUpForms.AboutBox about = new StartUpForms.AboutBox();
                about.ShowDialog();
            }
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

            if (sender == btnOverdue || sender == overdueChargeToolStrip)
            {
                if (overDueLoans == null || overDueLoans.IsDisposed)
                {
                    overDueLoans = new OverDueReport(this);
                }
                DisplayForm(overDueLoans);
            }

            if (sender == updateResourceToolStrip)
            {
                if (modifyResourceStatus == null || modifyResourceStatus.IsDisposed)
                {
                    modifyResourceStatus = new ModifyResourceStatus(this);
                }
                DisplayForm(modifyResourceStatus);
            }

            if(sender == manageStudentsToolStrip)
            {
                if (student == null || student.IsDisposed)
                {
                    student = new ManageStudent(this);
                }
                DisplayForm(student);
            }

            if(sender == createStudentToolStrip)
            {
                if (createStudent == null || createStudent.IsDisposed)
                {
                    createStudent = new CreateStudent(this);
                }
                DisplayForm(createStudent);
            }
            
            if(sender == paymentsToolStrip)
            {
                if (makePayment == null || makePayment.IsDisposed)
                {
                    makePayment = new MakePayment(this);
                }
                DisplayForm(makePayment);
            }
            if(sender == addResourceToolStrip)
            {
                if (addResource == null || addResource.IsDisposed)
                {
                    addResource = new AddResource(this);
                }
                DisplayForm(addResource);
            }
            if (sender == newUserToolStripMenuItem)
            {
                if (addNewUser == null || addNewUser.IsDisposed)
                {
                    addNewUser = new addNewUser(this);
                }
                DisplayForm(addNewUser);
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
