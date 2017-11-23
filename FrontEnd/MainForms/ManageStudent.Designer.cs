namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class ManageStudent
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
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbStudentsInfo = new System.Windows.Forms.GroupBox();
            this.txtstudentID = new System.Windows.Forms.TextBox();
            this.lblstudentID = new System.Windows.Forms.Label();
            this.txtphoneNumber = new System.Windows.Forms.TextBox();
            this.lblphone = new System.Windows.Forms.Label();
            this.txtpostalCode = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lblpostalCode = new System.Windows.Forms.Label();
            this.lblcity = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbProgram = new System.Windows.Forms.ComboBox();
            this.dtpendDate = new System.Windows.Forms.DateTimePicker();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpstartDate = new System.Windows.Forms.DateTimePicker();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.panActions = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSearch.SuspendLayout();
            this.gbStudentsInfo.SuspendLayout();
            this.panActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.lstSearchResults);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(270, 169);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Students";
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.Location = new System.Drawing.Point(15, 45);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(144, 95);
            this.lstSearchResults.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 19);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(181, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbStudentsInfo
            // 
            this.gbStudentsInfo.Controls.Add(this.txtstudentID);
            this.gbStudentsInfo.Controls.Add(this.lblstudentID);
            this.gbStudentsInfo.Controls.Add(this.txtphoneNumber);
            this.gbStudentsInfo.Controls.Add(this.lblphone);
            this.gbStudentsInfo.Controls.Add(this.txtpostalCode);
            this.gbStudentsInfo.Controls.Add(this.txtcity);
            this.gbStudentsInfo.Controls.Add(this.txtaddress);
            this.gbStudentsInfo.Controls.Add(this.lblpostalCode);
            this.gbStudentsInfo.Controls.Add(this.lblcity);
            this.gbStudentsInfo.Controls.Add(this.lbladdress);
            this.gbStudentsInfo.Controls.Add(this.cbStatus);
            this.gbStudentsInfo.Controls.Add(this.cbProgram);
            this.gbStudentsInfo.Controls.Add(this.dtpendDate);
            this.gbStudentsInfo.Controls.Add(this.txtbalance);
            this.gbStudentsInfo.Controls.Add(this.lblStartDate);
            this.gbStudentsInfo.Controls.Add(this.dtpstartDate);
            this.gbStudentsInfo.Controls.Add(this.txtlastName);
            this.gbStudentsInfo.Controls.Add(this.lblEndDate);
            this.gbStudentsInfo.Controls.Add(this.txtfirstName);
            this.gbStudentsInfo.Controls.Add(this.lblStatus);
            this.gbStudentsInfo.Controls.Add(this.lblProgram);
            this.gbStudentsInfo.Controls.Add(this.lblBalance);
            this.gbStudentsInfo.Controls.Add(this.lblLname);
            this.gbStudentsInfo.Controls.Add(this.lblFname);
            this.gbStudentsInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentsInfo.Location = new System.Drawing.Point(12, 187);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(959, 176);
            this.gbStudentsInfo.TabIndex = 6;
            this.gbStudentsInfo.TabStop = false;
            this.gbStudentsInfo.Text = "Student Info";
            // 
            // txtstudentID
            // 
            this.txtstudentID.Enabled = false;
            this.txtstudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentID.Location = new System.Drawing.Point(122, 41);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(123, 27);
            this.txtstudentID.TabIndex = 25;
            // 
            // lblstudentID
            // 
            this.lblstudentID.AutoSize = true;
            this.lblstudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentID.Location = new System.Drawing.Point(11, 42);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(108, 24);
            this.lblstudentID.TabIndex = 24;
            this.lblstudentID.Text = "Studend ID:";
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txtphoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneNumber.Location = new System.Drawing.Point(431, 138);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(143, 27);
            this.txtphoneNumber.TabIndex = 23;
            this.txtphoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(285, 138);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(145, 24);
            this.lblphone.TabIndex = 21;
            this.lblphone.Text = "Phone Number:";
            // 
            // txtpostalCode
            // 
            this.txtpostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpostalCode.Location = new System.Drawing.Point(431, 102);
            this.txtpostalCode.Name = "txtpostalCode";
            this.txtpostalCode.Size = new System.Drawing.Size(143, 27);
            this.txtpostalCode.TabIndex = 19;
            this.txtpostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(431, 69);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(143, 27);
            this.txtcity.TabIndex = 18;
            this.txtcity.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(431, 36);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(143, 27);
            this.txtaddress.TabIndex = 17;
            this.txtaddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblpostalCode
            // 
            this.lblpostalCode.AutoSize = true;
            this.lblpostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpostalCode.Location = new System.Drawing.Point(312, 105);
            this.lblpostalCode.Name = "lblpostalCode";
            this.lblpostalCode.Size = new System.Drawing.Size(116, 24);
            this.lblpostalCode.TabIndex = 16;
            this.lblpostalCode.Text = "Postal Code:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(383, 72);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(45, 24);
            this.lblcity.TabIndex = 15;
            this.lblcity.Text = "City:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(343, 39);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(85, 24);
            this.lbladdress.TabIndex = 14;
            this.lbladdress.Text = "Address:";
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(704, 77);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 13;
            // 
            // cbProgram
            // 
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.Location = new System.Drawing.Point(704, 42);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(121, 21);
            this.cbProgram.TabIndex = 12;
            // 
            // dtpendDate
            // 
            this.dtpendDate.Location = new System.Drawing.Point(704, 139);
            this.dtpendDate.Name = "dtpendDate";
            this.dtpendDate.Size = new System.Drawing.Size(200, 22);
            this.dtpendDate.TabIndex = 11;
            this.dtpendDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // txtbalance
            // 
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(122, 138);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(123, 27);
            this.txtbalance.TabIndex = 9;
            this.txtbalance.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(603, 108);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpstartDate
            // 
            this.dtpstartDate.Location = new System.Drawing.Point(704, 111);
            this.dtpstartDate.Name = "dtpstartDate";
            this.dtpstartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpstartDate.TabIndex = 10;
            this.dtpstartDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // txtlastName
            // 
            this.txtlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(122, 107);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(123, 27);
            this.txtlastName.TabIndex = 8;
            this.txtlastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(603, 141);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 24);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtfirstName
            // 
            this.txtfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(122, 74);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(123, 27);
            this.txtfirstName.TabIndex = 7;
            this.txtfirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(632, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 24);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(610, 39);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(87, 24);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Program:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(34, 141);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(83, 24);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(13, 110);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(104, 24);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(11, 77);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(106, 24);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // panActions
            // 
            this.panActions.Controls.Add(this.btnclear);
            this.panActions.Controls.Add(this.btnupdate);
            this.panActions.Controls.Add(this.btndelete);
            this.panActions.Location = new System.Drawing.Point(12, 394);
            this.panActions.Name = "panActions";
            this.panActions.Size = new System.Drawing.Size(959, 100);
            this.panActions.TabIndex = 7;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(501, 28);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 44);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(165, 28);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(162, 44);
            this.btnupdate.TabIndex = 16;
            this.btnupdate.Text = "&Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(333, 28);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(162, 44);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "&Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.panActions);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.gbSearch);
            this.Name = "ManageStudent";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.Student_Load);
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            this.panActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbStudentsInfo;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.DateTimePicker dtpendDate;
        private System.Windows.Forms.DateTimePicker dtpstartDate;
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
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtpostalCode;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblpostalCode;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Panel panActions;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.Label lblstudentID;
    }
}