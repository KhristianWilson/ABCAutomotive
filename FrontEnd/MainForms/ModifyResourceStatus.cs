using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class ModifyResourceStatus : Form
    { 
        
        private Main parent;
        public ModifyResourceStatus(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region Start Up

        private Resource objRes;

        private void ModifyResourceStatus_Load(object sender, System.EventArgs e)
        {
            setupForm();
        }

        #endregion

        #region Retrieve

        private void cmdRetrieve_Click(System.Object eventSender, System.EventArgs eventArgs)
        {
            try
            {
                if(Int32.TryParse(txtsearchResource.Text, out int id))
                {
                    objRes = ResourceFactory.CreateNotLoaned(id);
                    LoadFields();
                    txtsearchResource.Enabled = false;
                    enableUpdate(true);
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
            pbImage.Image = getImage(objRes.image);
            cbStatus.SelectedItem = objRes.resourceStatus;

            if(objRes.removealDate  != default(DateTime))
            {
                dtpRemovelDate.Value = objRes.removealDate;
                lblDateOfRem.Visible = true;
                dtpRemovelDate.Visible = true;
            }
            else
            {
                lblDateOfRem.Visible = false;
                dtpRemovelDate.Visible = false;
            }
        }

        #endregion

        #region House Keeping

        private void setupForm()
        {
            objRes = ResourceFactory.Create();
            List<ResourceStatus> status = Enum.GetValues(typeof(ResourceStatus)).Cast<ResourceStatus>().ToList();
            status.RemoveAt(1);
            cbStatus.DataSource = status;

            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            enableUpdate(false);
            gbResourceInfo.Enabled = false;
            txtsearchResource.MaxLength = 8;           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            foreach (Control x in gbResourceInfo.Controls)
            {
                if (x is TextBox)
                {
                    x.Text = string.Empty;
                }
                if(x is ComboBox)
                {
                    (x as ComboBox).SelectedIndex = -1;
                    (x as ComboBox).SelectedIndex = -1;
                }

                this.errorProvider1.SetError(x, string.Empty);
            }

            objRes = ResourceFactory.Create();
            dtpAddDate.Value = DateTime.Now;
            dtpRemovelDate.Value = DateTime.Now;      
            enableUpdate(false);
            parent.StatusLabel.Text = "";
            txtsearchResource.Enabled = true;
            txtsearchResource.Focus();
        }

        private void enableUpdate(bool mode)
        {
            btnClear.Visible = mode;
            btnUpdate.Visible = mode;
            cbStatus.Visible = mode;
            lblStatus.Visible = mode;
            gbResourceInfo.Visible = mode;
        }

        private void txtsearchResource_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtsearchResource.SelectAll();
        }

        private void ModifyResourceStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        private static Image getImage(byte[] ImageData)
        {
            Image Image;
            if (ImageData == null)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(ImageData))
            {
                Image = Image.FromStream(ms);
            }
            return Image;
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
                cmdRetrieve_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
