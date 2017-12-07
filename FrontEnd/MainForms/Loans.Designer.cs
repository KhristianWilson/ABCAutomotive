namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class Loans
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.lstSearchResults = new System.Windows.Forms.ListBox();
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
            this.gbStudentLoans = new System.Windows.Forms.GroupBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.gbSearchResource = new System.Windows.Forms.GroupBox();
            this.txtsearchResource = new System.Windows.Forms.TextBox();
            this.btnSearchResource = new System.Windows.Forms.Button();
            this.gbResource = new System.Windows.Forms.GroupBox();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.txtresourceStatus = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtreserveStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.lblreserveStatus = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lblresourceStatus = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btncheckOut = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbStudentsInfo.SuspendLayout();
            this.gbStudentLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.gbSearchResource.SuspendLayout();
            this.gbResource.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(15, 28);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Enter += new System.EventHandler(this.txtsearchResource_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbSearch.Controls.Add(this.lstSearchResults);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 12);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(270, 169);
            this.gbSearch.TabIndex = 2;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search Students";
            // 
            // lstSearchResults
            // 
            this.lstSearchResults.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchResults.FormattingEnabled = true;
            this.lstSearchResults.ItemHeight = 19;
            this.lstSearchResults.Location = new System.Drawing.Point(15, 63);
            this.lstSearchResults.Name = "lstSearchResults";
            this.lstSearchResults.Size = new System.Drawing.Size(249, 80);
            this.lstSearchResults.TabIndex = 2;
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
            this.gbStudentsInfo.Location = new System.Drawing.Point(303, 12);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(668, 169);
            this.gbStudentsInfo.TabIndex = 3;
            this.gbStudentsInfo.TabStop = false;
            this.gbStudentsInfo.Text = "Student Info";
            this.gbStudentsInfo.Visible = false;
            // 
            // dtpendDate
            // 
            this.dtpendDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpendDate.Location = new System.Drawing.Point(419, 86);
            this.dtpendDate.Name = "dtpendDate";
            this.dtpendDate.Size = new System.Drawing.Size(204, 26);
            this.dtpendDate.TabIndex = 29;
            // 
            // dtpstartDate
            // 
            this.dtpstartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartDate.Location = new System.Drawing.Point(419, 55);
            this.dtpstartDate.Name = "dtpstartDate";
            this.dtpstartDate.Size = new System.Drawing.Size(204, 26);
            this.dtpstartDate.TabIndex = 28;
            // 
            // cbstudentStatus
            // 
            this.cbstudentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbstudentStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstudentStatus.FormattingEnabled = true;
            this.cbstudentStatus.Location = new System.Drawing.Point(419, 116);
            this.cbstudentStatus.Name = "cbstudentStatus";
            this.cbstudentStatus.Size = new System.Drawing.Size(204, 27);
            this.cbstudentStatus.TabIndex = 27;
            // 
            // cbprogram
            // 
            this.cbprogram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbprogram.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbprogram.FormattingEnabled = true;
            this.cbprogram.Location = new System.Drawing.Point(419, 22);
            this.cbprogram.Name = "cbprogram";
            this.cbprogram.Size = new System.Drawing.Size(204, 27);
            this.cbprogram.TabIndex = 26;
            // 
            // txtbalance
            // 
            this.txtbalance.Enabled = false;
            this.txtbalance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(121, 88);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(140, 26);
            this.txtbalance.TabIndex = 9;
            // 
            // txtlastName
            // 
            this.txtlastName.Enabled = false;
            this.txtlastName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(121, 55);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(140, 26);
            this.txtlastName.TabIndex = 8;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Enabled = false;
            this.txtfirstName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(121, 22);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(140, 26);
            this.txtfirstName.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(348, 122);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 21);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(325, 94);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(83, 21);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(320, 63);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(88, 21);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(330, 30);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(78, 21);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Program:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(41, 94);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(72, 21);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(21, 61);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(94, 21);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(19, 28);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(96, 21);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // gbStudentLoans
            // 
            this.gbStudentLoans.Controls.Add(this.dgvLoans);
            this.gbStudentLoans.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentLoans.Location = new System.Drawing.Point(303, 187);
            this.gbStudentLoans.Name = "gbStudentLoans";
            this.gbStudentLoans.Size = new System.Drawing.Size(668, 214);
            this.gbStudentLoans.TabIndex = 4;
            this.gbStudentLoans.TabStop = false;
            this.gbStudentLoans.Text = "Student Loans";
            this.gbStudentLoans.Visible = false;
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(12, 28);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowTemplate.Height = 70;
            this.dgvLoans.Size = new System.Drawing.Size(650, 186);
            this.dgvLoans.TabIndex = 0;
            // 
            // gbSearchResource
            // 
            this.gbSearchResource.Controls.Add(this.txtsearchResource);
            this.gbSearchResource.Controls.Add(this.btnSearchResource);
            this.gbSearchResource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchResource.Location = new System.Drawing.Point(12, 294);
            this.gbSearchResource.Name = "gbSearchResource";
            this.gbSearchResource.Size = new System.Drawing.Size(270, 74);
            this.gbSearchResource.TabIndex = 3;
            this.gbSearchResource.TabStop = false;
            this.gbSearchResource.Text = "Search Resources";
            // 
            // txtsearchResource
            // 
            this.txtsearchResource.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchResource.Location = new System.Drawing.Point(15, 28);
            this.txtsearchResource.MaxLength = 50;
            this.txtsearchResource.Name = "txtsearchResource";
            this.txtsearchResource.Size = new System.Drawing.Size(144, 26);
            this.txtsearchResource.TabIndex = 4;
            this.txtsearchResource.Enter += new System.EventHandler(this.txtsearchResource_Enter);
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(189, 27);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(75, 27);
            this.btnSearchResource.TabIndex = 5;
            this.btnSearchResource.Text = "&Search";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
            // 
            // gbResource
            // 
            this.gbResource.Controls.Add(this.btnAddtoCart);
            this.gbResource.Controls.Add(this.txtresourceStatus);
            this.gbResource.Controls.Add(this.lbltitle);
            this.gbResource.Controls.Add(this.txtreserveStatus);
            this.gbResource.Controls.Add(this.label3);
            this.gbResource.Controls.Add(this.txttype);
            this.gbResource.Controls.Add(this.lblreserveStatus);
            this.gbResource.Controls.Add(this.txttitle);
            this.gbResource.Controls.Add(this.lblresourceStatus);
            this.gbResource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResource.Location = new System.Drawing.Point(12, 374);
            this.gbResource.Name = "gbResource";
            this.gbResource.Size = new System.Drawing.Size(270, 205);
            this.gbResource.TabIndex = 5;
            this.gbResource.TabStop = false;
            this.gbResource.Text = "Resource Info";
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Location = new System.Drawing.Point(65, 170);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(140, 29);
            this.btnAddtoCart.TabIndex = 8;
            this.btnAddtoCart.Text = "&Add To Borrowings";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.btnAddtoCart_Click);
            // 
            // txtresourceStatus
            // 
            this.txtresourceStatus.Enabled = false;
            this.txtresourceStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresourceStatus.Location = new System.Drawing.Point(113, 129);
            this.txtresourceStatus.Name = "txtresourceStatus";
            this.txtresourceStatus.Size = new System.Drawing.Size(140, 26);
            this.txtresourceStatus.TabIndex = 21;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(61, 38);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(46, 21);
            this.lbltitle.TabIndex = 14;
            this.lbltitle.Text = "Title:";
            // 
            // txtreserveStatus
            // 
            this.txtreserveStatus.Enabled = false;
            this.txtreserveStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreserveStatus.Location = new System.Drawing.Point(113, 97);
            this.txtreserveStatus.Name = "txtreserveStatus";
            this.txtreserveStatus.Size = new System.Drawing.Size(140, 26);
            this.txtreserveStatus.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type:";
            // 
            // txttype
            // 
            this.txttype.Enabled = false;
            this.txttype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(113, 65);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(140, 26);
            this.txttype.TabIndex = 19;
            // 
            // lblreserveStatus
            // 
            this.lblreserveStatus.AutoSize = true;
            this.lblreserveStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreserveStatus.Location = new System.Drawing.Point(23, 102);
            this.lblreserveStatus.Name = "lblreserveStatus";
            this.lblreserveStatus.Size = new System.Drawing.Size(84, 21);
            this.lblreserveStatus.TabIndex = 16;
            this.lblreserveStatus.Text = "Reserved:";
            // 
            // txttitle
            // 
            this.txttitle.Enabled = false;
            this.txttitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(113, 33);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(140, 26);
            this.txttitle.TabIndex = 18;
            // 
            // lblresourceStatus
            // 
            this.lblresourceStatus.AutoSize = true;
            this.lblresourceStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresourceStatus.Location = new System.Drawing.Point(47, 134);
            this.lblresourceStatus.Name = "lblresourceStatus";
            this.lblresourceStatus.Size = new System.Drawing.Size(60, 21);
            this.lblresourceStatus.TabIndex = 17;
            this.lblresourceStatus.Text = "Status:";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(523, 544);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(193, 29);
            this.btncancel.TabIndex = 6;
            this.btncancel.Text = "&Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btncheckOut
            // 
            this.btncheckOut.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheckOut.Location = new System.Drawing.Point(523, 512);
            this.btncheckOut.Name = "btncheckOut";
            this.btncheckOut.Size = new System.Drawing.Size(193, 29);
            this.btncheckOut.TabIndex = 7;
            this.btncheckOut.Text = "Check &Out";
            this.btncheckOut.UseVisualStyleBackColor = true;
            this.btncheckOut.Click += new System.EventHandler(this.btncheckOut_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 21;
            this.lstCart.Location = new System.Drawing.Point(315, 407);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(173, 130);
            this.lstCart.TabIndex = 4;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Location = new System.Drawing.Point(315, 544);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(173, 29);
            this.btnRemoveItem.TabIndex = 22;
            this.btnRemoveItem.Text = "&Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // Loans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 621);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lstCart);
            this.Controls.Add(this.btncheckOut);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.gbResource);
            this.Controls.Add(this.gbSearchResource);
            this.Controls.Add(this.gbStudentLoans);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.gbSearch);
            this.Name = "Loans";
            this.Text = "Loans";
            this.Activated += new System.EventHandler(this.Loans_Activated);
            this.Load += new System.EventHandler(this.Loans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            this.gbStudentLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.gbSearchResource.ResumeLayout(false);
            this.gbSearchResource.PerformLayout();
            this.gbResource.ResumeLayout(false);
            this.gbResource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ListBox lstSearchResults;
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
        private System.Windows.Forms.GroupBox gbStudentLoans;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.GroupBox gbSearchResource;
        private System.Windows.Forms.TextBox txtsearchResource;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.GroupBox gbResource;
        private System.Windows.Forms.TextBox txtresourceStatus;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtreserveStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label lblreserveStatus;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lblresourceStatus;
        private System.Windows.Forms.Button btncheckOut;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DateTimePicker dtpendDate;
        private System.Windows.Forms.DateTimePicker dtpstartDate;
        private System.Windows.Forms.ComboBox cbstudentStatus;
        private System.Windows.Forms.ComboBox cbprogram;
    }
}