namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class Returns
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnReturn = new System.Windows.Forms.Button();
            this.gbStudentLoans = new System.Windows.Forms.GroupBox();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.rdoDamged = new System.Windows.Forms.RadioButton();
            this.rdoLost = new System.Windows.Forms.RadioButton();
            this.gbReturn = new System.Windows.Forms.GroupBox();
            this.chkLate = new System.Windows.Forms.CheckBox();
            this.txtResourceID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.gbSearchResource.SuspendLayout();
            this.gbStudentsInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbStudentLoans.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            this.gbReturn.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSearchResource
            // 
            this.gbSearchResource.Controls.Add(this.txtsearchResource);
            this.gbSearchResource.Controls.Add(this.btnSearchResource);
            this.gbSearchResource.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchResource.Location = new System.Drawing.Point(12, 12);
            this.gbSearchResource.Name = "gbSearchResource";
            this.gbSearchResource.Size = new System.Drawing.Size(270, 60);
            this.gbSearchResource.TabIndex = 4;
            this.gbSearchResource.TabStop = false;
            this.gbSearchResource.Text = "Search Resources";
            // 
            // txtsearchResource
            // 
            this.txtsearchResource.Location = new System.Drawing.Point(15, 19);
            this.txtsearchResource.MaxLength = 50;
            this.txtsearchResource.Name = "txtsearchResource";
            this.txtsearchResource.Size = new System.Drawing.Size(144, 22);
            this.txtsearchResource.TabIndex = 4;
            this.txtsearchResource.Enter += new System.EventHandler(this.txtsearchResource_Enter);
            // 
            // btnSearchResource
            // 
            this.btnSearchResource.Location = new System.Drawing.Point(181, 19);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(75, 23);
            this.btnSearchResource.TabIndex = 5;
            this.btnSearchResource.Text = "&Search";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.btnSearchResource_Click);
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
            this.gbStudentsInfo.Location = new System.Drawing.Point(11, 78);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(674, 175);
            this.gbStudentsInfo.TabIndex = 5;
            this.gbStudentsInfo.TabStop = false;
            this.gbStudentsInfo.Text = "Student Info";
            this.gbStudentsInfo.Visible = false;
            // 
            // txtstatus
            // 
            this.txtstatus.Enabled = false;
            this.txtstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstatus.Location = new System.Drawing.Point(464, 131);
            this.txtstatus.Name = "txtstatus";
            this.txtstatus.Size = new System.Drawing.Size(140, 27);
            this.txtstatus.TabIndex = 13;
            // 
            // txtendDate
            // 
            this.txtendDate.Enabled = false;
            this.txtendDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtendDate.Location = new System.Drawing.Point(464, 98);
            this.txtendDate.Name = "txtendDate";
            this.txtendDate.Size = new System.Drawing.Size(140, 27);
            this.txtendDate.TabIndex = 12;
            // 
            // txtstartDate
            // 
            this.txtstartDate.Enabled = false;
            this.txtstartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstartDate.Location = new System.Drawing.Point(464, 65);
            this.txtstartDate.Name = "txtstartDate";
            this.txtstartDate.Size = new System.Drawing.Size(140, 27);
            this.txtstartDate.TabIndex = 11;
            // 
            // txtprogram
            // 
            this.txtprogram.Enabled = false;
            this.txtprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprogram.Location = new System.Drawing.Point(464, 32);
            this.txtprogram.Name = "txtprogram";
            this.txtprogram.Size = new System.Drawing.Size(140, 27);
            this.txtprogram.TabIndex = 10;
            // 
            // txtbalance
            // 
            this.txtbalance.Enabled = false;
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.Location = new System.Drawing.Point(126, 101);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(140, 27);
            this.txtbalance.TabIndex = 9;
            // 
            // txtlastName
            // 
            this.txtlastName.Enabled = false;
            this.txtlastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastName.Location = new System.Drawing.Point(126, 68);
            this.txtlastName.Name = "txtlastName";
            this.txtlastName.Size = new System.Drawing.Size(140, 27);
            this.txtlastName.TabIndex = 8;
            // 
            // txtfirstName
            // 
            this.txtfirstName.Enabled = false;
            this.txtfirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirstName.Location = new System.Drawing.Point(126, 35);
            this.txtfirstName.Name = "txtfirstName";
            this.txtfirstName.Size = new System.Drawing.Size(140, 27);
            this.txtfirstName.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(394, 134);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(65, 24);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(365, 101);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(93, 24);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(365, 68);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(94, 24);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(371, 35);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(87, 24);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Program:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(37, 104);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(83, 24);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(17, 71);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(104, 24);
            this.lblLname.TabIndex = 1;
            this.lblLname.Text = "Last Name:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.Location = new System.Drawing.Point(15, 38);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(106, 24);
            this.lblFname.TabIndex = 0;
            this.lblFname.Text = "First Name:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 82);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "&Return Resource";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // gbStudentLoans
            // 
            this.gbStudentLoans.Controls.Add(this.dgvLoans);
            this.gbStudentLoans.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentLoans.Location = new System.Drawing.Point(12, 259);
            this.gbStudentLoans.Name = "gbStudentLoans";
            this.gbStudentLoans.Size = new System.Drawing.Size(679, 199);
            this.gbStudentLoans.TabIndex = 8;
            this.gbStudentLoans.TabStop = false;
            this.gbStudentLoans.Text = "Student Loans";
            this.gbStudentLoans.Visible = false;
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(12, 19);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowTemplate.Height = 70;
            this.dgvLoans.Size = new System.Drawing.Size(661, 174);
            this.dgvLoans.TabIndex = 0;
            this.dgvLoans.SelectionChanged += new System.EventHandler(this.dgvLoans_SelectionChanged);
            // 
            // rdoDamged
            // 
            this.rdoDamged.AutoSize = true;
            this.rdoDamged.Location = new System.Drawing.Point(17, 67);
            this.rdoDamged.Name = "rdoDamged";
            this.rdoDamged.Size = new System.Drawing.Size(77, 17);
            this.rdoDamged.TabIndex = 9;
            this.rdoDamged.TabStop = true;
            this.rdoDamged.Text = "Damaged ";
            this.rdoDamged.UseVisualStyleBackColor = true;
            // 
            // rdoLost
            // 
            this.rdoLost.AutoSize = true;
            this.rdoLost.Location = new System.Drawing.Point(17, 44);
            this.rdoLost.Name = "rdoLost";
            this.rdoLost.Size = new System.Drawing.Size(46, 17);
            this.rdoLost.TabIndex = 10;
            this.rdoLost.TabStop = true;
            this.rdoLost.Text = "Lost";
            this.rdoLost.UseVisualStyleBackColor = true;
            // 
            // gbReturn
            // 
            this.gbReturn.Controls.Add(this.btnClear);
            this.gbReturn.Controls.Add(this.gbStatus);
            this.gbReturn.Controls.Add(this.chkLate);
            this.gbReturn.Controls.Add(this.txtResourceID);
            this.gbReturn.Controls.Add(this.btnReturn);
            this.gbReturn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReturn.Location = new System.Drawing.Point(24, 464);
            this.gbReturn.Name = "gbReturn";
            this.gbReturn.Size = new System.Drawing.Size(533, 145);
            this.gbReturn.TabIndex = 11;
            this.gbReturn.TabStop = false;
            this.gbReturn.Text = "Return Resource";
            // 
            // chkLate
            // 
            this.chkLate.AutoSize = true;
            this.chkLate.Location = new System.Drawing.Point(137, 42);
            this.chkLate.Name = "chkLate";
            this.chkLate.Size = new System.Drawing.Size(47, 17);
            this.chkLate.TabIndex = 12;
            this.chkLate.Text = "Late";
            this.chkLate.UseVisualStyleBackColor = true;
            // 
            // txtResourceID
            // 
            this.txtResourceID.Enabled = false;
            this.txtResourceID.Location = new System.Drawing.Point(12, 37);
            this.txtResourceID.Name = "txtResourceID";
            this.txtResourceID.Size = new System.Drawing.Size(102, 22);
            this.txtResourceID.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(385, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "&Cancel";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(17, 21);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(62, 17);
            this.rdoNormal.TabIndex = 14;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.rdoLost);
            this.gbStatus.Controls.Add(this.rdoDamged);
            this.gbStatus.Controls.Add(this.rdoNormal);
            this.gbStatus.Location = new System.Drawing.Point(190, 21);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(133, 100);
            this.gbStatus.TabIndex = 13;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Status";
            // 
            // Returns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.gbReturn);
            this.Controls.Add(this.gbStudentLoans);
            this.Controls.Add(this.gbStudentsInfo);
            this.Controls.Add(this.gbSearchResource);
            this.Name = "Returns";
            this.Text = "Returns";
            this.Load += new System.EventHandler(this.Returns_Load);
            this.gbSearchResource.ResumeLayout(false);
            this.gbSearchResource.PerformLayout();
            this.gbStudentsInfo.ResumeLayout(false);
            this.gbStudentsInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbStudentLoans.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            this.gbReturn.ResumeLayout(false);
            this.gbReturn.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.gbStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchResource;
        private System.Windows.Forms.TextBox txtsearchResource;
        private System.Windows.Forms.Button btnSearchResource;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox gbStudentLoans;
        private System.Windows.Forms.DataGridView dgvLoans;
        private System.Windows.Forms.RadioButton rdoLost;
        private System.Windows.Forms.RadioButton rdoDamged;
        private System.Windows.Forms.GroupBox gbReturn;
        private System.Windows.Forms.TextBox txtResourceID;
        private System.Windows.Forms.CheckBox chkLate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.GroupBox gbStatus;
    }
}