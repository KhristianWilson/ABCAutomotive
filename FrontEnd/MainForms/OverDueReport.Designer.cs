namespace ABCAutomotive.FrontEnd.MainForms
{
    partial class OverDueReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OverDueReport));
            this.dgvoverDueLoans = new System.Windows.Forms.DataGridView();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbldateText = new System.Windows.Forms.Label();
            this.lblnoRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvoverDueLoans)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvoverDueLoans
            // 
            this.dgvoverDueLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvoverDueLoans.Location = new System.Drawing.Point(12, 71);
            this.dgvoverDueLoans.Name = "dgvoverDueLoans";
            this.dgvoverDueLoans.Size = new System.Drawing.Size(892, 417);
            this.dgvoverDueLoans.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(113, 21);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Today\'s Date:";
            // 
            // lbldateText
            // 
            this.lbldateText.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateText.Location = new System.Drawing.Point(131, 24);
            this.lbldateText.Name = "lbldateText";
            this.lbldateText.Size = new System.Drawing.Size(211, 43);
            this.lbldateText.TabIndex = 2;
            // 
            // lblnoRecords
            // 
            this.lblnoRecords.AutoSize = true;
            this.lblnoRecords.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoRecords.Location = new System.Drawing.Point(433, 26);
            this.lblnoRecords.Name = "lblnoRecords";
            this.lblnoRecords.Size = new System.Drawing.Size(0, 21);
            this.lblnoRecords.TabIndex = 3;
            // 
            // OverDueReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 621);
            this.Controls.Add(this.lblnoRecords);
            this.Controls.Add(this.lbldateText);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dgvoverDueLoans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OverDueReport";
            this.Text = "Overdue Loans";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OverDueReport_FormClosing);
            this.Load += new System.EventHandler(this.OverDueLoans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvoverDueLoans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvoverDueLoans;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lbldateText;
        private System.Windows.Forms.Label lblnoRecords;
    }
}