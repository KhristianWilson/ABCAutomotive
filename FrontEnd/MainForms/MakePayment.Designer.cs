namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class MakePayment
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
            this.gbpayment = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnmakePayment = new System.Windows.Forms.Button();
            this.rdoCredit = new System.Windows.Forms.RadioButton();
            this.rdoDebit = new System.Windows.Forms.RadioButton();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbStudentsInfo = new System.Windows.Forms.GroupBox();
            this.txtstatus = new System.Windows.Forms.TextBox();
            this.txtendDate = new System.Windows.Forms.TextBox();
            this.txtstartDate = new System.Windows.Forms.TextBox();
            this.txtprogram = new System.Windows.Forms.TextBox();
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
            this.gbpayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbStudentsInfo.SuspendLayout();
            this.gbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbpayment
            // 
            this.gbpayment.Controls.Add(this.btnCancel);
            this.gbpayment.Controls.Add(this.btnmakePayment);
            this.gbpayment.Controls.Add(this.rdoCredit);
            this.gbpayment.Controls.Add(this.rdoDebit);
            this.gbpayment.Controls.Add(this.txtamount);
            this.gbpayment.Controls.Add(this.lblAmount);
            this.gbpayment.Location = new System.Drawing.Point(12, 362);
            this.gbpayment.Name = "gbpayment";
            this.gbpayment.Size = new System.Drawing.Size(636, 214);
            this.gbpayment.TabIndex = 4;
            this.gbpayment.TabStop = false;
            this.gbpayment.Text = "Payment Info";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(458, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel Payment";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnmakePayment
            // 
            this.btnmakePayment.Location = new System.Drawing.Point(458, 31);
            this.btnmakePayment.Name = "btnmakePayment";
            this.btnmakePayment.Size = new System.Drawing.Size(140, 23);
            this.btnmakePayment.TabIndex = 7;
            this.btnmakePayment.Text = "Confirm Payment";
            this.btnmakePayment.UseVisualStyleBackColor = true;
            this.btnmakePayment.Click += new System.EventHandler(this.btnmakePayment_Click);
            // 
            // rdoCredit
            // 
            this.rdoCredit.AutoSize = true;
            this.rdoCredit.Location = new System.Drawing.Point(341, 57);
            this.rdoCredit.Name = "rdoCredit";
            this.rdoCredit.Size = new System.Drawing.Size(52, 17);
            this.rdoCredit.TabIndex = 6;
            this.rdoCredit.TabStop = true;
            this.rdoCredit.Text = "Credit";
            this.rdoCredit.UseVisualStyleBackColor = true;
            // 
            // rdoDebit
            // 
            this.rdoDebit.AutoSize = true;
            this.rdoDebit.Location = new System.Drawing.Point(341, 34);
            this.rdoDebit.Name = "rdoDebit";
            this.rdoDebit.Size = new System.Drawing.Size(50, 17);
            this.rdoDebit.TabIndex = 5;
            this.rdoDebit.TabStop = true;
            this.rdoDebit.Text = "Debit";
            this.rdoDebit.UseVisualStyleBackColor = true;
            // 
            // txtamount
            // 
            this.txtamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtamount.Location = new System.Drawing.Point(157, 31);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(140, 27);
            this.txtamount.TabIndex = 4;
            this.txtamount.Enter += new System.EventHandler(this.txtamount_Enter);
            this.txtamount.Validating += new System.ComponentModel.CancelEventHandler(this.txtamount_Validating);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAmount.Location = new System.Drawing.Point(11, 34);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(131, 24);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Enter Amount:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbStudentsInfo
            // 
            this.gbStudentsInfo.Controls.Add(this.txtstatus);
            this.gbStudentsInfo.Controls.Add(this.txtendDate);
            this.gbStudentsInfo.Controls.Add(this.txtstartDate);
            this.gbStudentsInfo.Controls.Add(this.txtprogram);
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
            this.gbStudentsInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentsInfo.Location = new System.Drawing.Point(12, 187);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(636, 169);
            this.gbStudentsInfo.TabIndex = 9;
            this.gbStudentsInfo.TabStop = false;
            this.gbStudentsInfo.Text = "Student Info";
            this.gbStudentsInfo.Visible = false;
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.Location = new System.Drawing.Point(458, 120);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(140, 27);
            this.txtstatus.TabIndex = 13;
            // 
            // txtendDate
            // 
            this.txtendDate.Enabled = false;
            this.txtendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendDate.Location = new System.Drawing.Point(458, 87);
            this.txtendDate.Name = "txtendDate";
            this.txtendDate.Size = new System.Drawing.Size(140, 27);
            this.txtendDate.TabIndex = 12;
            // 
            // txtstartDate
            // 
            this.txtstartDate.Enabled = false;
            this.txtstartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstartDate.Location = new System.Drawing.Point(458, 54);
            this.txtstartDate.Name = "txtstartDate";
            this.txtstartDate.Size = new System.Drawing.Size(140, 27);
            this.txtstartDate.TabIndex = 11;
            // 
            // txtprogram
            // 
            this.txtprogram.Enabled = false;
            this.txtprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprogram.Location = new System.Drawing.Point(458, 21);
            this.txtprogram.Name = "txtprogram";
            this.txtprogram.Size = new System.Drawing.Size(140, 27);
            this.txtprogram.TabIndex = 10;
            // 
            // txtbalance
            // 
            this.txtbalance.Enabled = false;
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(157, 90);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(140, 27);
            this.txtbalance.TabIndex = 9;
            // 
            // txtlastName
            // 
            this.txtlastName.Enabled = false;
            this.txtlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(157, 57);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(140, 27);
            this.txtlastName.TabIndex = 8;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Enabled = false;
            this.txtfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(157, 24);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(140, 27);
            this.txtfirstName.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(388, 123);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 24);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(359, 90);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 24);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(359, 57);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(365, 24);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(87, 24);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Program:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(68, 93);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(83, 24);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(48, 60);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(104, 24);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(46, 27);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(106, 24);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbSearch.Controls.Add(this.lstSearchResults);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(270, 169);
            this.gbSearch.TabIndex = 10;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Students";
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.ItemHeight = 19;
            this.lstSearchResults.Location = new System.Drawing.Point(15, 57);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(241, 99);
            this.lstSearchResults.TabIndex = 3;
            this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.LstSearchResults_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(15, 25);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(165, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // MakePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.gbpayment);
            this.Name = "MakePayment";
            this.Text = "MakePayment";
            this.Load += new System.EventHandler(this.MakePayment_Load);
            this.gbpayment.ResumeLayout(false);
            this.gbpayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbpayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbStudentsInfo;
        private System.Windows.Forms.TextBox txtstatus;
        private System.Windows.Forms.TextBox txtendDate;
        private System.Windows.Forms.TextBox txtstartDate;
        private System.Windows.Forms.TextBox txtprogram;
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
        private System.Windows.Forms.Button btnmakePayment;
        private System.Windows.Forms.RadioButton rdoCredit;
        private System.Windows.Forms.RadioButton rdoDebit;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
    }
}