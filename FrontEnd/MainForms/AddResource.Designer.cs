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
            this.txtResourceID = new System.Windows.Forms.TextBox();
            this.lblResourceId = new System.Windows.Forms.Label();
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
            this.gbResourceInfo.Controls.Add(this.txtResourceID);
            this.gbResourceInfo.Controls.Add(this.lblResourceId);
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
            this.gbResourceInfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResourceInfo.Location = new System.Drawing.Point(13, 12);
            this.gbResourceInfo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbResourceInfo.Name = "gbResourceInfo";
            this.gbResourceInfo.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.gbResourceInfo.Size = new System.Drawing.Size(958, 503);
            this.gbResourceInfo.TabIndex = 7;
            this.gbResourceInfo.TabStop = false;
            this.gbResourceInfo.Text = "Resource Info";
            // 
            // txtResourceID
            // 
            this.txtResourceID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResourceID.Location = new System.Drawing.Point(332, 40);
            this.txtResourceID.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtResourceID.Name = "txtResourceID";
            this.txtResourceID.Size = new System.Drawing.Size(210, 26);
            this.txtResourceID.TabIndex = 51;
            // 
            // lblResourceId
            // 
            this.lblResourceId.AutoSize = true;
            this.lblResourceId.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResourceId.Location = new System.Drawing.Point(211, 45);
            this.lblResourceId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResourceId.Name = "lblResourceId";
            this.lblResourceId.Size = new System.Drawing.Size(109, 21);
            this.lblResourceId.TabIndex = 50;
            this.lblResourceId.Text = "Resource ID:";
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(14, 199);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(80, 30);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(719, 285);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(198, 27);
            this.cbStatus.TabIndex = 7;
            this.cbStatus.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.ItemHeight = 19;
            this.cbType.Location = new System.Drawing.Point(333, 120);
            this.cbType.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(210, 27);
            this.cbType.TabIndex = 47;
            this.cbType.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(456, 409);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(332, 409);
            this.btninsert.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(118, 30);
            this.btninsert.TabIndex = 10;
            this.btninsert.Text = "&Add Resource";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(268, 327);
            this.lblprice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(52, 21);
            this.lblprice.TabIndex = 41;
            this.lblprice.Text = "Price:";
            // 
            // lblreferencenumber
            // 
            this.lblreferencenumber.AutoSize = true;
            this.lblreferencenumber.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreferencenumber.Location = new System.Drawing.Point(166, 360);
            this.lblreferencenumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreferencenumber.Name = "lblreferencenumber";
            this.lblreferencenumber.Size = new System.Drawing.Size(154, 21);
            this.lblreferencenumber.TabIndex = 42;
            this.lblreferencenumber.Text = "Reference Number:";
            // 
            // txtreferencenumber
            // 
            this.txtreferencenumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreferencenumber.Location = new System.Drawing.Point(332, 355);
            this.txtreferencenumber.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtreferencenumber.Name = "txtreferencenumber";
            this.txtreferencenumber.Size = new System.Drawing.Size(210, 26);
            this.txtreferencenumber.TabIndex = 6;
            this.txtreferencenumber.Click += new System.EventHandler(this.txttitle_Click);
            this.txtreferencenumber.Enter += new System.EventHandler(this.txttitle_Enter);
            this.txtreferencenumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(332, 322);
            this.txtprice.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(210, 26);
            this.txtprice.TabIndex = 5;
            this.txtprice.Click += new System.EventHandler(this.txttitle_Click);
            this.txtprice.Enter += new System.EventHandler(this.txttitle_Enter);
            this.txtprice.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // dtpAddDate
            // 
            this.dtpAddDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddDate.Location = new System.Drawing.Point(719, 322);
            this.dtpAddDate.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.dtpAddDate.Name = "dtpAddDate";
            this.dtpAddDate.Size = new System.Drawing.Size(198, 26);
            this.dtpAddDate.TabIndex = 8;
            this.dtpAddDate.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // lblDateOfPur
            // 
            this.lblDateOfPur.AutoSize = true;
            this.lblDateOfPur.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfPur.Location = new System.Drawing.Point(569, 330);
            this.lblDateOfPur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateOfPur.Name = "lblDateOfPur";
            this.lblDateOfPur.Size = new System.Drawing.Size(146, 21);
            this.lblDateOfPur.TabIndex = 36;
            this.lblDateOfPur.Text = "Date Of Purchase:";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(14, 28);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(178, 156);
            this.pbImage.TabIndex = 33;
            this.pbImage.TabStop = false;
            // 
            // txtpublisher
            // 
            this.txtpublisher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpublisher.Location = new System.Drawing.Point(333, 286);
            this.txtpublisher.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtpublisher.Name = "txtpublisher";
            this.txtpublisher.Size = new System.Drawing.Size(210, 26);
            this.txtpublisher.TabIndex = 4;
            this.txtpublisher.Click += new System.EventHandler(this.txttitle_Click);
            this.txtpublisher.Enter += new System.EventHandler(this.txttitle_Enter);
            this.txtpublisher.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // lblpublisher
            // 
            this.lblpublisher.AutoSize = true;
            this.lblpublisher.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpublisher.Location = new System.Drawing.Point(239, 294);
            this.lblpublisher.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblpublisher.Name = "lblpublisher";
            this.lblpublisher.Size = new System.Drawing.Size(83, 21);
            this.lblpublisher.TabIndex = 31;
            this.lblpublisher.Text = "Publisher:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(333, 164);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(297, 104);
            this.txtDesc.TabIndex = 3;
            this.txtDesc.Click += new System.EventHandler(this.txttitle_Click);
            this.txtDesc.Enter += new System.EventHandler(this.txttitle_Enter);
            this.txtDesc.Validating += new System.ComponentModel.CancelEventHandler(this.txtDesc_Validating);
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldescription.Location = new System.Drawing.Point(220, 164);
            this.lbldescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(100, 21);
            this.lbldescription.TabIndex = 29;
            this.lbldescription.Text = "Description:";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(274, 87);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(46, 21);
            this.lbltitle.TabIndex = 22;
            this.lbltitle.Text = "Title:";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltype.Location = new System.Drawing.Point(268, 126);
            this.lbltype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(52, 21);
            this.lbltype.TabIndex = 23;
            this.lbltype.Text = "Type:";
            // 
            // lblreserveStatus
            // 
            this.lblreserveStatus.AutoSize = true;
            this.lblreserveStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreserveStatus.Location = new System.Drawing.Point(655, 293);
            this.lblreserveStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblreserveStatus.Name = "lblreserveStatus";
            this.lblreserveStatus.Size = new System.Drawing.Size(60, 21);
            this.lblreserveStatus.TabIndex = 24;
            this.lblreserveStatus.Text = "Status:";
            // 
            // txttitle
            // 
            this.txttitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitle.Location = new System.Drawing.Point(333, 82);
            this.txttitle.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(211, 26);
            this.txttitle.TabIndex = 1;
            this.txttitle.Click += new System.EventHandler(this.txttitle_Click);
            this.txttitle.Enter += new System.EventHandler(this.txttitle_Enter);
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
            this.ClientSize = new System.Drawing.Size(983, 620);
            this.Controls.Add(this.gbResourceInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "AddResource";
            this.Text = "Add Resource";
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
        private System.Windows.Forms.TextBox txtResourceID;
        private System.Windows.Forms.Label lblResourceId;
    }
}