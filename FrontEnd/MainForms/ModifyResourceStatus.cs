﻿using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class ModifyResourceStatus : Form
    {
        private Resource objRes;
        private Main parent;

        public ModifyResourceStatus(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region Start Up

        private void ModifyResourceStatus_Load(object sender, System.EventArgs e)
        {
            List<ResourceStatus> status = Enum.GetValues(typeof(ResourceStatus)).Cast<ResourceStatus>().ToList();
            status.RemoveAt(1);
            cbStatus.DataSource = status;

            gbResourceInfo.Enabled = false;
            btnClear.Visible = false;
            btnUpdate.Visible = false;
            cbStatus.Visible = false;
            lblStatus.Visible = false;
            txtsearchResource.MaxLength = 8;
        }

        #endregion

        #region Retrieve

        private void cmdRetrieve_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            btnClear_Click(null, null);
            try
            {
                if(Int32.TryParse(txtsearchResource.Text, out int id))
                {
                    objRes = ResourceFactory.Create(id);
                    LoadFields();
                    txtsearchResource.Enabled = false;
                    enableUpdate();
                }
                else
                {
                    errorProvider1.SetError(txtsearchResource, "Invalid Resource ID");
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsearchResource, ex.Message);
            }
        }

        private void LoadFields()
        {
            txttitle.Text = objRes.title;
            txttype.Text = objRes.resourceType.ToString();
            txtDesc.Text = objRes.description;
            txtpublisher.Text = objRes.publisher;
            txtprice.Text = objRes.price.ToString("c2");
            txtreferencenumber.Text = objRes.referenceNumber;
            txtreserveStatus.Text = objRes.reserveStatus.ToString();
            dtpAddDate.Value = objRes.purchaseDate;
            dtpRemovelDate.Value = objRes.removealDate;
            cbStatus.SelectedItem = objRes.resourceStatus;
        }

        #endregion

        #region House Keeping

        private void btnClear_Click(object sender, EventArgs e)
        {

            foreach (Control x in gbResourceInfo.Controls)
            {
                if (x is TextBox | x is ComboBox)
                {
                    x.Text = string.Empty;
                }

                this.errorProvider1.SetError(x, string.Empty);
            }

            dtpAddDate.Value = System.DateTime.Now;
            dtpRemovelDate.Value = System.DateTime.Now;
            cbStatus.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            objRes = ResourceFactory.Create();
            txtsearchResource.Enabled = true;
            cbStatus.Visible = false;
            btnClear.Visible = false;
            btnUpdate.Visible = false;
        }

        private void enableUpdate()
        {
            btnClear.Visible = true;
            btnUpdate.Visible = true;
            cbStatus.Visible = true;
            lblStatus.Visible = true;
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            parent.StatusLabel.Text = "";
        }

        #endregion

        #region Update Status

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                objRes.resourceStatus = (ResourceStatus)cbStatus.SelectedItem;
                ResourceMethods.UpdateStatus(objRes);
                parent.StatusLabel.Text = "Status Updated";
                LoadFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}