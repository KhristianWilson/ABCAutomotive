namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class Reserve
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
            this.gbSearchResource = new System.Windows.Forms.GroupBox();
            this.txtsearchResource = new System.Windows.Forms.TextBox();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.gbResource = new System.Windows.Forms.GroupBox();
            this.cbresourceStatus = new System.Windows.Forms.ComboBox();
            this.cbreserved = new System.Windows.Forms.ComboBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblreserveStatus = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lblresourceStatus = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbStudentsInfo = new System.Windows.Forms.GroupBox();
            this.dtpendDate = new System.Windows.Forms.DateTimePicker();
            this.dtpstartDate = new System.Windows.Forms.DateTimePicker();
            this.cbstudentStatus = new System.Windows.Forms.ComboBox();
            this.cbprogram = new System.Windows.Forms.ComboBox();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReserveResource = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.gbSearchResource.SuspendLayout();
            this.gbResource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbStudentsInfo.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchResource
            // 
            this.gbSearchResource.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbSearchResource.Controls.Add(this.txtsearchResource);
            this.gbSearchResource.Controls.Add(this.btnSearchResource);
            this.gbSearchResource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchResource.Location = new System.Drawing.Point(12, 12);
            this.gbSearchResource.Name = "gbSearchResource";
            this.gbSearchResource.Size = new System.Drawing.Size(270, 116);
            this.gbSearchResource.TabIndex = 5;
            this.gbSearchResource.TabStop = false;
            this.gbSearchResource.Text = "Search Resources";
            // 
            // txtsearchResource
            // 
            this.txtsearchResource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchResource.Location = new System.Drawing.Point(15, 33);
            this.txtsearchResource.MaxLength = 50;
            this.txtsearchResource.Name = "txtsearchResource";
            this.txtsearchResource.Size = new System.Drawing.Size(144, 26);
            this.txtsearchResource.TabIndex = 1;
            this.txtsearchResource.Enter += new System.EventHandler(this.txtsearchResource_Enter);
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(189, 31);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(75, 29);
            this.btnSearchResource.TabIndex = 2;
            this.btnSearchResource.Text = "&Search";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // gbResource
            // 
            this.gbResource.Controls.Add(this.cbresourceStatus);
            this.gbResource.Controls.Add(this.cbreserved);
            this.gbResource.Controls.Add(this.cbtype);
            this.gbResource.Controls.Add(this.lbltitle);
            this.gbResource.Controls.Add(this.label3);
            this.gbResource.Controls.Add(this.lblreserveStatus);
            this.gbResource.Controls.Add(this.txttitle);
            this.gbResource.Controls.Add(this.lblresourceStatus);
            this.gbResource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResource.Location = new System.Drawing.Point(288, 12);
            this.gbResource.Name = "gbResource";
            this.gbResource.Size = new System.Drawing.Size(636, 116);
            this.gbResource.TabIndex = 6;
            this.gbResource.TabStop = false;
            this.gbResource.Text = "Resource Info";
            // 
            // cbresourceStatus
            // 
            this.cbresourceStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbresourceStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbresourceStatus.FormattingEnabled = true;
            this.cbresourceStatus.Location = new System.Drawing.Point(408, 72);
            this.cbresourceStatus.Name = "cbresourceStatus";
            this.cbresourceStatus.Size = new System.Drawing.Size(204, 27);
            this.cbresourceStatus.TabIndex = 21;
            // 
            // cbreserved
            // 
            this.cbreserved.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbreserved.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbreserved.FormattingEnabled = true;
            this.cbreserved.Location = new System.Drawing.Point(408, 33);
            this.cbreserved.Name = "cbreserved";
            this.cbreserved.Size = new System.Drawing.Size(204, 27);
            this.cbreserved.TabIndex = 20;
            // 
            // cbtype
            // 
            this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtype.FormattingEnabled = true;
            this.cbtype.Location = new System.Drawing.Point(75, 72);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(222, 27);
            this.cbtype.TabIndex = 19;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(19, 38);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(46, 21);
            this.lbltitle.TabIndex = 14;
            this.lbltitle.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type:";
            // 
            // lblreserveStatus
            // 
            this.lblreserveStatus.AutoSize = true;
            this.lblreserveStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreserveStatus.Location = new System.Drawing.Point(322, 41);
            this.lblreserveStatus.Name = "lblreserveStatus";
            this.lblreserveStatus.Size = new System.Drawing.Size(84, 21);
            this.lblreserveStatus.TabIndex = 16;
            this.lblreserveStatus.Text = "Reserved:";
            // 
            // txttitle
            // 
            this.txttitle.Enabled = false;
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(75, 35);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(222, 27);
            this.txttitle.TabIndex = 18;
            // 
            // lblresourceStatus
            // 
            this.lblresourceStatus.AutoSize = true;
            this.lblresourceStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresourceStatus.Location = new System.Drawing.Point(346, 78);
            this.lblresourceStatus.Name = "lblresourceStatus";
            this.lblresourceStatus.Size = new System.Drawing.Size(60, 21);
            this.lblresourceStatus.TabIndex = 17;
            this.lblresourceStatus.Text = "Status:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbStudentsInfo
            // 
            this.gbStudentsInfo.Controls.Add(this.dtpendDate);
            this.gbStudentsInfo.Controls.Add(this.dtpstartDate);
            this.gbStudentsInfo.Controls.Add(this.cbstudentStatus);
            this.gbStudentsInfo.Controls.Add(this.cbprogram);
            this.gbStudentsInfo.Controls.Add(this.txtbalance);
            this.gbStudentsInfo.Controls.Add(this.txtlastName);
            this.gbStudentsInfo.Controls.Add(this.txtfirstName);
            this.gbStudentsInfo.Controls.Add(this.lblStatus);
            this.gbStudentsInfo.Controls.Add(this.lblEndDate);
            this.gbStudentsInfo.Controls.Add(this.lblStartDate);
            this.gbStudentsInfo.Controls.Add(this.lblProgram);
            this.gbStudentsInfo.Controls.Add(this.lblBalance);
            this.gbStudentsInfo.Controls.Add(this.lblLname);
            this.gbStudentsInfo.Controls.Add(this.lblFname);
            this.gbStudentsInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentsInfo.Location = new System.Drawing.Point(288, 154);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(636, 169);
            this.gbStudentsInfo.TabIndex = 8;
            this.gbStudentsInfo.TabStop = false;
            this.gbStudentsInfo.Text = "Student Info";
            this.gbStudentsInfo.Visible = false;
            // 
            // dtpendDate
            // 
            this.dtpendDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpendDate.Location = new System.Drawing.Point(408, 82);
            this.dtpendDate.Name = "dtpendDate";
            this.dtpendDate.Size = new System.Drawing.Size(204, 26);
            this.dtpendDate.TabIndex = 25;
            // 
            // dtpstartDate
            // 
            this.dtpstartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartDate.Location = new System.Drawing.Point(408, 52);
            this.dtpstartDate.Name = "dtpstartDate";
            this.dtpstartDate.Size = new System.Drawing.Size(204, 26);
            this.dtpstartDate.TabIndex = 24;
            // 
            // cbstudentStatus
            // 
            this.cbstudentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstudentStatus.FormattingEnabled = true;
            this.cbstudentStatus.Location = new System.Drawing.Point(408, 114);
            this.cbstudentStatus.Name = "cbstudentStatus";
            this.cbstudentStatus.Size = new System.Drawing.Size(204, 27);
            this.cbstudentStatus.TabIndex = 23;
            // 
            // cbprogram
            // 
            this.cbprogram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprogram.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbprogram.FormattingEnabled = true;
            this.cbprogram.Location = new System.Drawing.Point(408, 19);
            this.cbprogram.Name = "cbprogram";
            this.cbprogram.Size = new System.Drawing.Size(204, 27);
            this.cbprogram.TabIndex = 22;
            // 
            // txtbalance
            // 
            this.txtbalance.Enabled = false;
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(130, 88);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(140, 27);
            this.txtbalance.TabIndex = 9;
            // 
            // txtlastName
            // 
            this.txtlastName.Enabled = false;
            this.txtlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(130, 55);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(140, 27);
            this.txtlastName.TabIndex = 8;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Enabled = false;
            this.txtfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(130, 22);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(140, 27);
            this.txtfirstName.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(342, 120);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 21);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(319, 88);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(83, 21);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(317, 58);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 21);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(327, 25);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(78, 21);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Program:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(41, 91);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(72, 21);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(21, 58);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(94, 21);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(19, 25);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(96, 21);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbSearch.Controls.Add(this.lstSearchResults);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 154);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(270, 169);
            this.gbSearch.TabIndex = 4;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Students";
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.ItemHeight = 19;
            this.lstSearchResults.Location = new System.Drawing.Point(15, 60);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(249, 99);
            this.lstSearchResults.TabIndex = 5;
            this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.LstSearchResults_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(15, 22);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.Enter += new System.EventHandler(this.txtsearchResource_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReserveResource
            // 
            this.btnReserveResource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserveResource.Location = new System.Drawing.Point(638, 329);
            this.btnReserveResource.Name = "btnReserveResource";
            this.btnReserveResource.Size = new System.Drawing.Size(140, 34);
            this.btnReserveResource.TabIndex = 6;
            this.btnReserveResource.Text = "&Reserve";
            this.btnReserveResource.UseVisualStyleBackColor = true;
            this.btnReserveResource.Click += new System.EventHandler(this.btnReserveResource_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(784, 329);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(140, 34);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Reserve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnReserveResource);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbResource);
            this.Controls.Add(this.gbSearchResource);
            this.Name = "Reserve";
            this.Text = "Reserve";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Reserve_FormClosing);
            this.Load += new System.EventHandler(this.Reserve_Load);
            this.gbSearchResource.ResumeLayout(false);
            this.gbSearchResource.PerformLayout();
            this.gbResource.ResumeLayout(false);
            this.gbResource.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchResource;
        private System.Windows.Forms.TextBox txtsearchResource;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.GroupBox gbResource;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblreserveStatus;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lblresourceStatus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbStudentsInfo;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReserveResource;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox cbresourceStatus;
        private System.Windows.Forms.ComboBox cbreserved;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.DateTimePicker dtpendDate;
        private System.Windows.Forms.DateTimePicker dtpstartDate;
        private System.Windows.Forms.ComboBox cbstudentStatus;
        private System.Windows.Forms.ComboBox cbprogram;
    }
}