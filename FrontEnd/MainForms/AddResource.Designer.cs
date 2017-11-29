namespace ABCAutomotive.FrontEnd
{
    partial class AddResource
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
            this.gbResourceInfo = new System.Windows.Forms.GroupBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblreferencenumber = new System.Windows.Forms.Label();
            this.txtreferencenumber = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.dtpAddDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfPur = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txtpublisher = new System.Windows.Forms.TextBox();
            this.lblpublisher = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblreserveStatus = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbResourceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbResourceInfo
            // 
            this.gbResourceInfo.Controls.Add(this.btnLoadImage);
            this.gbResourceInfo.Controls.Add(this.cbStatus);
            this.gbResourceInfo.Controls.Add(this.cbType);
            this.gbResourceInfo.Controls.Add(this.btnClear);
            this.gbResourceInfo.Controls.Add(this.btninsert);
            this.gbResourceInfo.Controls.Add(this.lblprice);
            this.gbResourceInfo.Controls.Add(this.lblreferencenumber);
            this.gbResourceInfo.Controls.Add(this.txtreferencenumber);
            this.gbResourceInfo.Controls.Add(this.txtprice);
            this.gbResourceInfo.Controls.Add(this.dtpAddDate);
            this.gbResourceInfo.Controls.Add(this.lblDateOfPur);
            this.gbResourceInfo.Controls.Add(this.pbImage);
            this.gbResourceInfo.Controls.Add(this.txtpublisher);
            this.gbResourceInfo.Controls.Add(this.lblpublisher);
            this.gbResourceInfo.Controls.Add(this.txtDesc);
            this.gbResourceInfo.Controls.Add(this.lbldescription);
            this.gbResourceInfo.Controls.Add(this.lbltitle);
            this.gbResourceInfo.Controls.Add(this.lbltype);
            this.gbResourceInfo.Controls.Add(this.lblreserveStatus);
            this.gbResourceInfo.Controls.Add(this.txttitle);
            this.gbResourceInfo.Location = new System.Drawing.Point(13, 12);
            this.gbResourceInfo.Name = "gbResourceInfo";
            this.gbResourceInfo.Size = new System.Drawing.Size(958, 400);
            this.gbResourceInfo.TabIndex = 7;
            this.gbResourceInfo.TabStop = false;
            this.gbResourceInfo.Text = "Resource Info";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(14, 187);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(80, 22);
            this.btnLoadImage.TabIndex = 49;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(678, 198);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(139, 21);
            this.cbStatus.TabIndex = 48;
            this.cbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(332, 54);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(139, 21);
            this.cbType.TabIndex = 47;
            this.cbType.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(455, 334);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 40);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(331, 334);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(118, 40);
            this.btninsert.TabIndex = 45;
            this.btninsert.Text = "&Add Resource";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(267, 228);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(58, 24);
            this.lblprice.TabIndex = 41;
            this.lblprice.Text = "Price:";
            // 
            // lblreferencenumber
            // 
            this.lblreferencenumber.AutoSize = true;
            this.lblreferencenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreferencenumber.Location = new System.Drawing.Point(148, 261);
            this.lblreferencenumber.Name = "lblreferencenumber";
            this.lblreferencenumber.Size = new System.Drawing.Size(177, 24);
            this.lblreferencenumber.TabIndex = 42;
            this.lblreferencenumber.Text = "Reference Number:";
            // 
            // txtreferencenumber
            // 
            this.txtreferencenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferencenumber.Location = new System.Drawing.Point(331, 258);
            this.txtreferencenumber.Name = "txtreferencenumber";
            this.txtreferencenumber.Size = new System.Drawing.Size(140, 27);
            this.txtreferencenumber.TabIndex = 44;
            this.txtreferencenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(331, 225);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(140, 27);
            this.txtprice.TabIndex = 43;
            this.txtprice.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.Location = new System.Drawing.Point(678, 232);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(140, 20);
            this.dtpAddDate.TabIndex = 39;
            this.dtpAddDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // lblDateOfPur
            // 
            this.lblDateOfPur.AutoSize = true;
            this.lblDateOfPur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfPur.Location = new System.Drawing.Point(510, 228);
            this.lblDateOfPur.Name = "lblDateOfPur";
            this.lblDateOfPur.Size = new System.Drawing.Size(162, 24);
            this.lblDateOfPur.TabIndex = 36;
            this.lblDateOfPur.Text = "Date Of Purchase:";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(14, 19);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(178, 156);
            this.pbImage.TabIndex = 33;
            this.pbImage.TabStop = false;
            // 
            // txtpublisher
            // 
            this.txtpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpublisher.Location = new System.Drawing.Point(331, 192);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(140, 27);
            this.txtpublisher.TabIndex = 32;
            this.txtpublisher.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // lblpublisher
            // 
            this.lblpublisher.AutoSize = true;
            this.lblpublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpublisher.Location = new System.Drawing.Point(231, 198);
            this.lblpublisher.Name = "lblpublisher";
            this.lblpublisher.Size = new System.Drawing.Size(94, 24);
            this.lblpublisher.TabIndex = 31;
            this.lblpublisher.Text = "Publisher:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(331, 82);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(297, 104);
            this.txtDesc.TabIndex = 30;
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(216, 85);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(109, 24);
            this.lbldescription.TabIndex = 29;
            this.lbldescription.Text = "Description:";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(275, 19);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(50, 24);
            this.lbltitle.TabIndex = 22;
            this.lbltitle.Text = "Title:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(267, 52);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(58, 24);
            this.lbltype.TabIndex = 23;
            this.lbltype.Text = "Type:";
            // 
            // lblreserveStatus
            // 
            this.lblreserveStatus.AutoSize = true;
            this.lblreserveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreserveStatus.Location = new System.Drawing.Point(607, 198);
            this.lblreserveStatus.Name = "lblreserveStatus";
            this.lblreserveStatus.Size = new System.Drawing.Size(65, 24);
            this.lblreserveStatus.TabIndex = 24;
            this.lblreserveStatus.Text = "Status:";
            // 
            // txttitle
            // 
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(331, 16);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(140, 27);
            this.txttitle.TabIndex = 26;
            this.txttitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.gbResourceInfo);
            this.Name = "AddResource";
            this.Text = "AddResource";
            this.Load += new System.EventHandler(this.AddResource_Load);
            this.gbResourceInfo.ResumeLayout(false);
            this.gbResourceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbResourceInfo;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblreferencenumber;
        private System.Windows.Forms.TextBox txtreferencenumber;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.DateTimePicker dtpAddDate;
        private System.Windows.Forms.Label lblDateOfPur;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txtpublisher;
        private System.Windows.Forms.Label lblpublisher;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblreserveStatus;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}