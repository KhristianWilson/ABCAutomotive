﻿namespace ABCAutomotive.FrontEnd.MainForms
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
            this.txtresourceStatus = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtreserveStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.lblreserveStatus = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lblresourceStatus = new System.Windows.Forms.Label();
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
            this.gbSearchResource.Controls.Add(this.txtsearchResource);
            this.gbSearchResource.Controls.Add(this.btnSearchResource);
            this.gbSearchResource.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchResource.Location = new System.Drawing.Point(12, 12);
            this.gbSearchResource.Name = "gbSearchResource";
            this.gbSearchResource.Size = new System.Drawing.Size(270, 116);
            this.gbSearchResource.TabIndex = 5;
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
            // gbResource
            // 
            this.gbResource.Controls.Add(this.txtresourceStatus);
            this.gbResource.Controls.Add(this.lbltitle);
            this.gbResource.Controls.Add(this.txtreserveStatus);
            this.gbResource.Controls.Add(this.label3);
            this.gbResource.Controls.Add(this.txttype);
            this.gbResource.Controls.Add(this.lblreserveStatus);
            this.gbResource.Controls.Add(this.txttitle);
            this.gbResource.Controls.Add(this.lblresourceStatus);
            this.gbResource.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResource.Location = new System.Drawing.Point(288, 12);
            this.gbResource.Name = "gbResource";
            this.gbResource.Size = new System.Drawing.Size(636, 116);
            this.gbResource.TabIndex = 6;
            this.gbResource.TabStop = false;
            this.gbResource.Text = "Resource Info";
            // 
            // txtresourceStatus
            // 
            this.txtresourceStatus.Enabled = false;
            this.txtresourceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresourceStatus.Location = new System.Drawing.Point(425, 68);
            this.txtresourceStatus.Name = "txtresourceStatus";
            this.txtresourceStatus.Size = new System.Drawing.Size(176, 27);
            this.txtresourceStatus.TabIndex = 21;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(19, 38);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(50, 24);
            this.lbltitle.TabIndex = 14;
            this.lbltitle.Text = "Title:";
            // 
            // txtreserveStatus
            // 
            this.txtreserveStatus.Enabled = false;
            this.txtreserveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreserveStatus.Location = new System.Drawing.Point(425, 35);
            this.txtreserveStatus.Name = "txtreserveStatus";
            this.txtreserveStatus.Size = new System.Drawing.Size(176, 27);
            this.txtreserveStatus.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type:";
            // 
            // txttype
            // 
            this.txttype.Enabled = false;
            this.txttype.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(75, 68);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(222, 27);
            this.txttype.TabIndex = 19;
            // 
            // lblreserveStatus
            // 
            this.lblreserveStatus.AutoSize = true;
            this.lblreserveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreserveStatus.Location = new System.Drawing.Point(326, 38);
            this.lblreserveStatus.Name = "lblreserveStatus";
            this.lblreserveStatus.Size = new System.Drawing.Size(96, 24);
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
            this.lblresourceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresourceStatus.Location = new System.Drawing.Point(354, 71);
            this.lblresourceStatus.Name = "lblresourceStatus";
            this.lblresourceStatus.Size = new System.Drawing.Size(65, 24);
            this.lblresourceStatus.TabIndex = 17;
            this.lblresourceStatus.Text = "Status:";
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
            this.gbStudentsInfo.Location = new System.Drawing.Point(288, 154);
            this.gbStudentsInfo.Name = "gbStudentsInfo";
            this.gbStudentsInfo.Size = new System.Drawing.Size(636, 169);
            this.gbStudentsInfo.TabIndex = 8;
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
            this.gbSearch.Controls.Add(this.lstSearchResults);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearch.Location = new System.Drawing.Point(12, 154);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(270, 169);
            this.gbSearch.TabIndex = 7;
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
            this.lstSearchResults.SelectedIndexChanged += new System.EventHandler(this.LstSearchResults_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(15, 19);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(144, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Enter += new System.EventHandler(this.txtsearchResource_Enter);
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
            // btnReserveResource
            // 
            this.btnReserveResource.Location = new System.Drawing.Point(638, 329);
            this.btnReserveResource.Name = "btnReserveResource";
            this.btnReserveResource.Size = new System.Drawing.Size(140, 34);
            this.btnReserveResource.TabIndex = 9;
            this.btnReserveResource.Text = "&Reserve";
            this.btnReserveResource.UseVisualStyleBackColor = true;
            this.btnReserveResource.Click += new System.EventHandler(this.btnReserveResource_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(784, 329);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(140, 34);
            this.btnclear.TabIndex = 10;
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
        private System.Windows.Forms.TextBox txtresourceStatus;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtreserveStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label lblreserveStatus;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lblresourceStatus;
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
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ListBox lstSearchResults;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReserveResource;
        private System.Windows.Forms.Button btnclear;
    }
}