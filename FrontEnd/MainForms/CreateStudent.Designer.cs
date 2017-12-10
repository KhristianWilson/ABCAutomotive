namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class CreateStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStudent));
            this.panActions = new System.Windows.Forms.Panel();
            this.btnclear = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpstartDate = new System.Windows.Forms.DateTimePicker();
            this.txtlastName = new System.Windows.Forms.TextBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.txtfirstName = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.panActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbStudentsInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panActions
            // 
            this.panActions.Controls.Add(this.btnclear);
            this.panActions.Controls.Add(this.btninsert);
            this.panActions.Location = new System.Drawing.Point(12, 194);
            this.panActions.Name = "panActions";
            this.panActions.Size = new System.Drawing.Size(959, 100);
            this.panActions.TabIndex = 26;
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(183, 27);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(162, 44);
            this.btnclear.TabIndex = 13;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninsert.Location = new System.Drawing.Point(15, 27);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(162, 44);
            this.btninsert.TabIndex = 12;
            this.btninsert.Text = "&Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbStudentsInfo
            // 
            this.gbStudentsInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            this.gbStudentsInfo.Controls.Add(this.lblStartDate);
            this.gbStudentsInfo.Controls.Add(this.dtpstartDate);
            this.gbStudentsInfo.Controls.Add(this.txtlastName);
            this.gbStudentsInfo.Controls.Add(this.lblEndDate);
            this.gbStudentsInfo.Controls.Add(this.txtfirstName);
            this.gbStudentsInfo.Controls.Add(this.lblStatus);
            this.gbStudentsInfo.Controls.Add(this.lblProgram);
            this.gbStudentsInfo.Controls.Add(this.lblLname);
            this.gbStudentsInfo.Controls.Add(this.lblFname);
            this.gbStudentsInfo.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentsInfo.Location = new System.Drawing.Point(12, 12);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(959, 176);
            this.gbStudentsInfo.TabIndex = 15;
            this.gbStudentsInfo.TabStop = false;
            this.gbStudentsInfo.Text = "Student Info";
            // 
            // txtstudentID
            // 
            this.txtstudentID.Enabled = false;
            this.txtstudentID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentID.Location = new System.Drawing.Point(122, 41);
            this.txtstudentID.Name = "txtstudentID";
            this.txtstudentID.Size = new System.Drawing.Size(148, 26);
            this.txtstudentID.TabIndex = 1;
            this.txtstudentID.TabStop = false;
            // 
            // lblstudentID
            // 
            this.lblstudentID.AutoSize = true;
            this.lblstudentID.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentID.Location = new System.Drawing.Point(11, 47);
            this.lblstudentID.Name = "lblstudentID";
            this.lblstudentID.Size = new System.Drawing.Size(100, 21);
            this.lblstudentID.TabIndex = 24;
            this.lblstudentID.Text = "Studend ID:";
            // 
            // txtphoneNumber
            // 
            this.txtphoneNumber.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txtphoneNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphoneNumber.Location = new System.Drawing.Point(431, 138);
            this.txtphoneNumber.Name = "txtphoneNumber";
            this.txtphoneNumber.Size = new System.Drawing.Size(143, 26);
            this.txtphoneNumber.TabIndex = 7;
            this.txtphoneNumber.Enter += new System.EventHandler(this.txtstudentID_Enter);
            this.txtphoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.Location = new System.Drawing.Point(292, 144);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(126, 21);
            this.lblphone.TabIndex = 21;
            this.lblphone.Text = "Phone Number:";
            // 
            // txtpostalCode
            // 
            this.txtpostalCode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpostalCode.Location = new System.Drawing.Point(431, 107);
            this.txtpostalCode.Name = "txtpostalCode";
            this.txtpostalCode.Size = new System.Drawing.Size(143, 26);
            this.txtpostalCode.TabIndex = 6;
            this.txtpostalCode.Enter += new System.EventHandler(this.txtstudentID_Enter);
            this.txtpostalCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // txtcity
            // 
            this.txtcity.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcity.Location = new System.Drawing.Point(431, 74);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(143, 26);
            this.txtcity.TabIndex = 5;
            this.txtcity.Enter += new System.EventHandler(this.txtstudentID_Enter);
            this.txtcity.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(431, 41);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(143, 26);
            this.txtaddress.TabIndex = 4;
            this.txtaddress.Enter += new System.EventHandler(this.txtstudentID_Enter);
            this.txtaddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblpostalCode
            // 
            this.lblpostalCode.AutoSize = true;
            this.lblpostalCode.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpostalCode.Location = new System.Drawing.Point(312, 113);
            this.lblpostalCode.Name = "lblpostalCode";
            this.lblpostalCode.Size = new System.Drawing.Size(106, 21);
            this.lblpostalCode.TabIndex = 16;
            this.lblpostalCode.Text = "Postal Code:";
            // 
            // lblcity
            // 
            this.lblcity.AutoSize = true;
            this.lblcity.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcity.Location = new System.Drawing.Point(373, 80);
            this.lblcity.Name = "lblcity";
            this.lblcity.Size = new System.Drawing.Size(45, 21);
            this.lblcity.TabIndex = 15;
            this.lblcity.Text = "City:";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(341, 47);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(77, 21);
            this.lbladdress.TabIndex = 14;
            this.lbladdress.Text = "Address:";
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.ItemHeight = 21;
            this.cbStatus.Location = new System.Drawing.Point(704, 69);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(200, 29);
            this.cbStatus.TabIndex = 9;
            this.cbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // cbProgram
            // 
            this.cbProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProgram.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProgram.FormattingEnabled = true;
            this.cbProgram.ItemHeight = 21;
            this.cbProgram.Location = new System.Drawing.Point(704, 31);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(200, 29);
            this.cbProgram.TabIndex = 8;
            this.cbProgram.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // dtpendDate
            // 
            this.dtpendDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpendDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpendDate.Location = new System.Drawing.Point(704, 135);
            this.dtpendDate.Name = "dtpendDate";
            this.dtpendDate.Size = new System.Drawing.Size(200, 29);
            this.dtpendDate.TabIndex = 11;
            this.dtpendDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(604, 110);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 21);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpstartDate
            // 
            this.dtpstartDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartDate.Location = new System.Drawing.Point(704, 104);
            this.dtpstartDate.Name = "dtpstartDate";
            this.dtpstartDate.Size = new System.Drawing.Size(200, 29);
            this.dtpstartDate.TabIndex = 10;
            this.dtpstartDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // txtlastName
            // 
            this.txtlastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(122, 107);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(148, 26);
            this.txtlastName.TabIndex = 3;
            this.txtlastName.Enter += new System.EventHandler(this.txtstudentID_Enter);
            this.txtlastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(609, 144);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(83, 21);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // txtfirstName
            // 
            this.txtfirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(122, 74);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(148, 26);
            this.txtfirstName.TabIndex = 2;
            this.txtfirstName.Enter += new System.EventHandler(this.txtstudentID_Enter);
            this.txtfirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtfirstName_Validating);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(632, 76);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 21);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(614, 39);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(78, 21);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Program:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(17, 113);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(94, 21);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(15, 80);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(96, 21);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // CreateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.panActions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateStudent";
            this.Text = "Create Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateStudent_FormClosing);
            this.Load += new System.EventHandler(this.CreateStudent_Load);
            this.panActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panActions;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbStudentsInfo;
        private System.Windows.Forms.TextBox txtstudentID;
        private System.Windows.Forms.Label lblstudentID;
        private System.Windows.Forms.TextBox txtphoneNumber;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.TextBox txtpostalCode;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lblpostalCode;
        private System.Windows.Forms.Label lblcity;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbProgram;
        private System.Windows.Forms.DateTimePicker dtpendDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpstartDate;
        private System.Windows.Forms.TextBox txtlastName;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.TextBox txtfirstName;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
    }
}