namespace ABCAutomotive.FrontEnd
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.loansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.overdueChargeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reserveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.updateResourceToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.addResourceToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.studentInfoToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.createStudentToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.btnLoans = new System.Windows.Forms.ToolStripButton();
            this.btnReturns = new System.Windows.Forms.ToolStripButton();
            this.btnReserves = new System.Windows.Forms.ToolStripButton();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.lblDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new MdiTabControl.TabControl();
            this.timerDisplay = new System.Windows.Forms.Timer(this.components);
            this.menuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loansToolStripMenuItem,
            this.resourceInfoToolStripMenuItem,
            this.studentInfoToolStrip});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1246, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip";
            // 
            // loansToolStripMenuItem
            // 
            this.loansToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnsToolStrip,
            this.checkOutToolStrip,
            this.overdueChargeToolStrip});
            this.loansToolStripMenuItem.Name = "loansToolStripMenuItem";
            this.loansToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.loansToolStripMenuItem.Text = "&Loans";
            this.loansToolStripMenuItem.Click += new System.EventHandler(this.MenuClick);
            // 
            // returnsToolStrip
            // 
            this.returnsToolStrip.Name = "returnsToolStrip";
            this.returnsToolStrip.Size = new System.Drawing.Size(165, 22);
            this.returnsToolStrip.Text = "&Returns";
            this.returnsToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // checkOutToolStrip
            // 
            this.checkOutToolStrip.Name = "checkOutToolStrip";
            this.checkOutToolStrip.Size = new System.Drawing.Size(165, 22);
            this.checkOutToolStrip.Text = "&Check Out";
            // 
            // overdueChargeToolStrip
            // 
            this.overdueChargeToolStrip.Name = "overdueChargeToolStrip";
            this.overdueChargeToolStrip.Size = new System.Drawing.Size(165, 22);
            this.overdueChargeToolStrip.Text = "&Overdue Charges";
            this.overdueChargeToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // resourceInfoToolStripMenuItem
            // 
            this.resourceInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reserveToolStrip,
            this.updateResourceToolStrip,
            this.addResourceToolStrip});
            this.resourceInfoToolStripMenuItem.Name = "resourceInfoToolStripMenuItem";
            this.resourceInfoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.resourceInfoToolStripMenuItem.Text = "&Resource Info";
            // 
            // reserveToolStrip
            // 
            this.reserveToolStrip.Name = "reserveToolStrip";
            this.reserveToolStrip.Size = new System.Drawing.Size(163, 22);
            this.reserveToolStrip.Text = "&Reserves";
            this.reserveToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // updateResourceToolStrip
            // 
            this.updateResourceToolStrip.Name = "updateResourceToolStrip";
            this.updateResourceToolStrip.Size = new System.Drawing.Size(163, 22);
            this.updateResourceToolStrip.Text = "&Update Resource";
            this.updateResourceToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // addResourceToolStrip
            // 
            this.addResourceToolStrip.Name = "addResourceToolStrip";
            this.addResourceToolStrip.Size = new System.Drawing.Size(163, 22);
            this.addResourceToolStrip.Text = "&Add Resource";
            this.addResourceToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // studentInfoToolStrip
            // 
            this.studentInfoToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageStudentsToolStrip,
            this.createStudentToolStrip,
            this.paymentsToolStrip});
            this.studentInfoToolStrip.Name = "studentInfoToolStrip";
            this.studentInfoToolStrip.Size = new System.Drawing.Size(84, 20);
            this.studentInfoToolStrip.Text = "&Student Info";
            // 
            // manageStudentsToolStrip
            // 
            this.manageStudentsToolStrip.Name = "manageStudentsToolStrip";
            this.manageStudentsToolStrip.Size = new System.Drawing.Size(166, 22);
            this.manageStudentsToolStrip.Text = "&Manage Students";
            this.manageStudentsToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // createStudentToolStrip
            // 
            this.createStudentToolStrip.Name = "createStudentToolStrip";
            this.createStudentToolStrip.Size = new System.Drawing.Size(166, 22);
            this.createStudentToolStrip.Text = "&Create Student";
            this.createStudentToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // paymentsToolStrip
            // 
            this.paymentsToolStrip.Name = "paymentsToolStrip";
            this.paymentsToolStrip.Size = new System.Drawing.Size(166, 22);
            this.paymentsToolStrip.Text = "&Payments";
            this.paymentsToolStrip.Click += new System.EventHandler(this.MenuClick);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoans,
            this.btnReturns,
            this.btnReserves});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1246, 25);
            this.toolStripMain.TabIndex = 1;
            this.toolStripMain.Text = "toolStrip";
            // 
            // btnLoans
            // 
            this.btnLoans.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoans.Image = global::ABCAutomotive.FrontEnd.Properties.Resources.loans;
            this.btnLoans.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoans.Name = "btnLoans";
            this.btnLoans.Size = new System.Drawing.Size(23, 22);
            this.btnLoans.Text = "Loans";
            this.btnLoans.Click += new System.EventHandler(this.MenuClick);
            // 
            // btnReturns
            // 
            this.btnReturns.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReturns.Image = global::ABCAutomotive.FrontEnd.Properties.Resources.returns;
            this.btnReturns.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReturns.Name = "btnReturns";
            this.btnReturns.Size = new System.Drawing.Size(23, 22);
            this.btnReturns.Text = "Returns";
            this.btnReturns.Click += new System.EventHandler(this.MenuClick);
            // 
            // btnReserves
            // 
            this.btnReserves.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReserves.Image = global::ABCAutomotive.FrontEnd.Properties.Resources.reserve;
            this.btnReserves.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReserves.Name = "btnReserves";
            this.btnReserves.Size = new System.Drawing.Size(23, 22);
            this.btnReserves.Text = "Reserves";
            this.btnReserves.Click += new System.EventHandler(this.MenuClick);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDateTime,
            this.lblUser,
            this.lblStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 646);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1246, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip";
            // 
            // lblDateTime
            // 
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // lblUser
            // 
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(176)))), ((int)(((byte)(84)))));
            this.splitContainer1.Panel1.Controls.Add(this.pbLogo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainer1.Size = new System.Drawing.Size(1246, 597);
            this.splitContainer1.SplitterDistance = 294;
            this.splitContainer1.TabIndex = 3;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::ABCAutomotive.FrontEnd.Properties.Resources.ABCLogo;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(294, 258);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.MenuRenderer = null;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Size = new System.Drawing.Size(948, 597);
            this.tabControlMain.TabCloseButtonImage = null;
            this.tabControlMain.TabCloseButtonImageDisabled = null;
            this.tabControlMain.TabCloseButtonImageHot = null;
            this.tabControlMain.TabIndex = 0;
            // 
            // timerDisplay
            // 
            this.timerDisplay.Enabled = true;
            this.timerDisplay.Interval = 1;
            this.timerDisplay.Tick += new System.EventHandler(this.timerDisplay_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1246, 668);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pbLogo;
        private MdiTabControl.TabControl tabControlMain;
        private System.Windows.Forms.ToolStripStatusLabel lblDateTime;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.Timer timerDisplay;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripButton btnLoans;
        private System.Windows.Forms.ToolStripButton btnReturns;
        private System.Windows.Forms.ToolStripButton btnReserves;
        private System.Windows.Forms.ToolStripMenuItem resourceInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reserveToolStrip;
        private System.Windows.Forms.ToolStripMenuItem studentInfoToolStrip;
        private System.Windows.Forms.ToolStripMenuItem updateResourceToolStrip;
        private System.Windows.Forms.ToolStripMenuItem manageStudentsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem createStudentToolStrip;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem loansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnsToolStrip;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStrip;
        private System.Windows.Forms.ToolStripMenuItem overdueChargeToolStrip;
        private System.Windows.Forms.ToolStripMenuItem addResourceToolStrip;
    }
}