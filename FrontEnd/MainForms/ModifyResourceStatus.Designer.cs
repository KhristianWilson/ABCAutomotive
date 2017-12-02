namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class ModifyResourceStatus
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
            this.gbResourceInfo = new System.Windows.Forms.GroupBox();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblreferencenumber = new System.Windows.Forms.Label();
            this.txtreferencenumber = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.dtpRemovelDate = new System.Windows.Forms.DateTimePicker();
            this.dtpAddDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfRem = new System.Windows.Forms.Label();
            this.lblDateOfPur = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.lblpublisher = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.txtreserveStatus = new System.Windows.Forms.TextBox();
            this.lbltype = new System.Windows.Forms.Label();
            this.txttype = new System.Windows.Forms.TextBox();
            this.lblreserveStatus = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.lblresourceStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSearchResource.SuspendLayout();
            this.gbResourceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbSearchResource
            // 
            this.gbSearchResource.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.gbSearchResource.Controls.Add(this.txtsearchResource);
            this.gbSearchResource.Controls.Add(this.btnSearchResource);
            this.gbSearchResource.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSearchResource.Location = new System.Drawing.Point(12, 4);
            this.gbSearchResource.Name = "gbSearchResource";
            this.gbSearchResource.Size = new System.Drawing.Size(270, 68);
            this.gbSearchResource.TabIndex = 5;
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
            this.btnSearchResource.Location = new System.Drawing.Point(165, 27);
            this.btnSearchResource.Name = "btnSearchResource";
            this.btnSearchResource.Size = new System.Drawing.Size(75, 26);
            this.btnSearchResource.TabIndex = 5;
            this.btnSearchResource.Text = "&Search";
            this.btnSearchResource.UseVisualStyleBackColor = true;
            this.btnSearchResource.Click += new System.EventHandler(this.cmdRetrieve_Click);
            // 
            // gbResourceInfo
            // 
            this.gbResourceInfo.Controls.Add(this.lblprice);
            this.gbResourceInfo.Controls.Add(this.lblreferencenumber);
            this.gbResourceInfo.Controls.Add(this.txtreferencenumber);
            this.gbResourceInfo.Controls.Add(this.txtprice);
            this.gbResourceInfo.Controls.Add(this.dtpRemovelDate);
            this.gbResourceInfo.Controls.Add(this.dtpAddDate);
            this.gbResourceInfo.Controls.Add(this.lblDateOfRem);
            this.gbResourceInfo.Controls.Add(this.lblDateOfPur);
            this.gbResourceInfo.Controls.Add(this.pbImage);
            this.gbResourceInfo.Controls.Add(this.txtpublisher);
            this.gbResourceInfo.Controls.Add(this.lblpublisher);
            this.gbResourceInfo.Controls.Add(this.txtDesc);
            this.gbResourceInfo.Controls.Add(this.lbldescription);
            this.gbResourceInfo.Controls.Add(this.lbltitle);
            this.gbResourceInfo.Controls.Add(this.txtreserveStatus);
            this.gbResourceInfo.Controls.Add(this.lbltype);
            this.gbResourceInfo.Controls.Add(this.txttype);
            this.gbResourceInfo.Controls.Add(this.lblreserveStatus);
            this.gbResourceInfo.Controls.Add(this.txttitle);
            this.gbResourceInfo.Controls.Add(this.lblresourceStatus);
            this.gbResourceInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResourceInfo.Location = new System.Drawing.Point(13, 79);
            this.gbResourceInfo.Name = "gbResourceInfo";
            this.gbResourceInfo.Size = new System.Drawing.Size(958, 328);
            this.gbResourceInfo.TabIndex = 6;
            this.gbResourceInfo.TabStop = false;
            this.gbResourceInfo.Text = "Resource Info";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(267, 228);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(52, 21);
            this.lblprice.TabIndex = 41;
            this.lblprice.Text = "Price:";
            // 
            // lblreferencenumber
            // 
            this.lblreferencenumber.AutoSize = true;
            this.lblreferencenumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreferencenumber.Location = new System.Drawing.Point(165, 263);
            this.lblreferencenumber.Name = "lblreferencenumber";
            this.lblreferencenumber.Size = new System.Drawing.Size(154, 21);
            this.lblreferencenumber.TabIndex = 42;
            this.lblreferencenumber.Text = "Reference Number:";
            // 
            // txtreferencenumber
            // 
            this.txtreferencenumber.Enabled = false;
            this.txtreferencenumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferencenumber.Location = new System.Drawing.Point(331, 258);
            this.txtreferencenumber.Name = "txtreferencenumber";
            this.txtreferencenumber.Size = new System.Drawing.Size(140, 26);
            this.txtreferencenumber.TabIndex = 44;
            // 
            // txtprice
            // 
            this.txtprice.Enabled = false;
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(331, 225);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(140, 26);
            this.txtprice.TabIndex = 43;
            // 
            // dtpRemovelDate
            // 
            this.dtpRemovelDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRemovelDate.Location = new System.Drawing.Point(678, 259);
            this.dtpRemovelDate.Name = "dtpRemovelDate";
            this.dtpRemovelDate.Size = new System.Drawing.Size(168, 26);
            this.dtpRemovelDate.TabIndex = 40;
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddDate.Location = new System.Drawing.Point(678, 226);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(168, 26);
            this.dtpAddDate.TabIndex = 39;
            // 
            // lblDateOfRem
            // 
            this.lblDateOfRem.AutoSize = true;
            this.lblDateOfRem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfRem.Location = new System.Drawing.Point(518, 264);
            this.lblDateOfRem.Name = "lblDateOfRem";
            this.lblDateOfRem.Size = new System.Drawing.Size(144, 21);
            this.lblDateOfRem.TabIndex = 38;
            this.lblDateOfRem.Text = "Date Of Removal:";
            // 
            // lblDateOfPur
            // 
            this.lblDateOfPur.AutoSize = true;
            this.lblDateOfPur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfPur.Location = new System.Drawing.Point(516, 231);
            this.lblDateOfPur.Name = "lblDateOfPur";
            this.lblDateOfPur.Size = new System.Drawing.Size(146, 21);
            this.lblDateOfPur.TabIndex = 36;
            this.lblDateOfPur.Text = "Date Of Purchase:";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(14, 28);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(178, 156);
            this.pbImage.TabIndex = 33;
            this.pbImage.TabStop = false;
            // 
            // txtpublisher
            // 
            this.txtpublisher.Enabled = false;
            this.txtpublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpublisher.Location = new System.Drawing.Point(331, 192);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(140, 26);
            this.txtpublisher.TabIndex = 32;
            // 
            // lblpublisher
            // 
            this.lblpublisher.AutoSize = true;
            this.lblpublisher.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpublisher.Location = new System.Drawing.Point(236, 198);
            this.lblpublisher.Name = "lblpublisher";
            this.lblpublisher.Size = new System.Drawing.Size(83, 21);
            this.lblpublisher.TabIndex = 31;
            this.lblpublisher.Text = "Publisher:";
            // 
            // txtDesc
            // 
            this.txtDesc.Enabled = false;
            this.txtDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(331, 82);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(297, 104);
            this.txtDesc.TabIndex = 30;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(221, 85);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(100, 21);
            this.lbldescription.TabIndex = 29;
            this.lbldescription.Text = "Description:";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(275, 19);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(46, 21);
            this.lbltitle.TabIndex = 22;
            this.lbltitle.Text = "Title:";
            // 
            // txtreserveStatus
            // 
            this.txtreserveStatus.Enabled = false;
            this.txtreserveStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreserveStatus.Location = new System.Drawing.Point(678, 192);
            this.txtreserveStatus.Name = "txtreserveStatus";
            this.txtreserveStatus.Size = new System.Drawing.Size(168, 26);
            this.txtreserveStatus.TabIndex = 28;
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(269, 51);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(52, 21);
            this.lbltype.TabIndex = 23;
            this.lbltype.Text = "Type:";
            // 
            // txttype
            // 
            this.txttype.Enabled = false;
            this.txttype.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.Location = new System.Drawing.Point(331, 49);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(140, 26);
            this.txttype.TabIndex = 27;
            // 
            // lblreserveStatus
            // 
            this.lblreserveStatus.AutoSize = true;
            this.lblreserveStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreserveStatus.Location = new System.Drawing.Point(578, 198);
            this.lblreserveStatus.Name = "lblreserveStatus";
            this.lblreserveStatus.Size = new System.Drawing.Size(84, 21);
            this.lblreserveStatus.TabIndex = 24;
            this.lblreserveStatus.Text = "Reserved:";
            // 
            // txttitle
            // 
            this.txttitle.Enabled = false;
            this.txttitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(331, 16);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(140, 26);
            this.txttitle.TabIndex = 26;
            // 
            // lblresourceStatus
            // 
            this.lblresourceStatus.AutoSize = true;
            this.lblresourceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresourceStatus.Location = new System.Drawing.Point(287, 307);
            this.lblresourceStatus.Name = "lblresourceStatus";
            this.lblresourceStatus.Size = new System.Drawing.Size(0, 24);
            this.lblresourceStatus.TabIndex = 25;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 431);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 21);
            this.lblStatus.TabIndex = 34;
            this.lblStatus.Text = "Status:";
            // 
            // cbStatus
            // 
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(89, 425);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(140, 27);
            this.cbStatus.TabIndex = 35;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(248, 425);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 29);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "&Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(329, 425);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 29);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModifyResourceStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 464);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.gbResourceInfo);
            this.Controls.Add(this.gbSearchResource);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cbStatus);
            this.Name = "ModifyResourceStatus";
            this.Text = "Modify Resource Status";
            this.Load += new System.EventHandler(this.ModifyResourceStatus_Load);
            this.gbSearchResource.ResumeLayout(false);
            this.gbSearchResource.PerformLayout();
            this.gbResourceInfo.ResumeLayout(false);
            this.gbResourceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSearchResource;
        private System.Windows.Forms.TextBox txtsearchResource;
        private System.Windows.Forms.Button btnSearchResource;
        private System.Windows.Forms.GroupBox gbResourceInfo;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.TextBox txtreserveStatus;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.TextBox txttype;
        private System.Windows.Forms.Label lblreserveStatus;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label lblresourceStatus;
        private System.Windows.Forms.Label lblpublisher;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblreferencenumber;
        private System.Windows.Forms.TextBox txtreferencenumber;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DateTimePicker dtpRemovelDate;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.Label lblDateOfRem;
        private System.Windows.Forms.Label lblDateOfPur;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtpublisher;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}