using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd
{
    public partial class AddResource : Form
    {
        private Main parent;
        public AddResource(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region Start Up

        Resource resource;

        private void AddResource_Load(object sender, EventArgs e)
        {
            setupForm();
        }

        #endregion

        #region Validating

        private void txtDesc_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.errorProvider1.SetError((Control)sender, string.Empty);

            try
            {
                if (object.ReferenceEquals(sender, txtDesc))
                {
                    resource.description = txtDesc.Text;
                }
                if (object.ReferenceEquals(sender, txtprice))
                {
                    string tempPrice;
                    if (txtprice.Text.StartsWith("$"))
                    {
                        tempPrice = txtprice.Text.Remove(0, 1);
                    }
                    else
                    {
                        tempPrice = txtprice.Text;
                    }
                    if (Double.TryParse(tempPrice, out double price))
                    {
                        resource.price = price;
                    }
                    else
                    {
                        errorProvider1.SetError(txtprice, "Price must be a decimal amount");
                    }
                }
                if (object.ReferenceEquals(sender, txtpublisher))
                {
                    resource.publisher = txtpublisher.Text;
                }
                if (object.ReferenceEquals(sender, txtreferencenumber))
                {
                    resource.referenceNumber = txtreferencenumber.Text;
                }
                if (object.ReferenceEquals(sender, txttitle))
                {
                    resource.title = txttitle.Text;
                }
                if (object.ReferenceEquals(sender, cbStatus))
                {
                    resource.resourceStatus = (ResourceStatus)cbStatus.SelectedItem;
                }
                if (object.ReferenceEquals(sender, cbType))
                {
                    resource.resourceType = (ResourceType)cbType.SelectedItem;
                }
                if (object.ReferenceEquals(sender, dtpAddDate))
                {
                    resource.purchaseDate = dtpAddDate.Value;
                }
            }
            catch (Exception ex)
            {
                this.errorProvider1.SetError((Control)sender, ex.Message);
            }
        }

        #endregion

        #region Add Resource

        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormIsClean())
                {
                    ResourceMethods.InsertResource(resource);
                    txtResourceID.Text = resource.resourceid.ToString();
                    parent.StatusLabel.Text = "Resource Added ID: " + resource.resourceid.ToString();
                }
                else
                {
                    parent.StatusLabel.Text = "Flieds were left blank" + " , " + "Insert Rejected";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region House Keeping

        private void setupForm()
        {
            parent.StatusLabel.Text = "";
            txtDesc.MaxLength = 50;
            txttitle.MaxLength = 30;
            txtpublisher.MaxLength = 30;
            txtreferencenumber.MaxLength = 50;
            txtResourceID.Enabled = false;

            pbImage.BorderStyle = BorderStyle.FixedSingle;
            cbType.DataSource = Enum.GetValues(typeof(ResourceType));
            List<ResourceStatus> status = Enum.GetValues(typeof(ResourceStatus)).Cast<ResourceStatus>().ToList();
            status.RemoveAt(1);
            cbStatus.DataSource = status;
            dtpAddDate.Value = DateTime.Now;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            resource = ResourceFactory.Create();
            resource.purchaseDate = DateTime.Now;
            resource.resourceStatus = (ResourceStatus)cbStatus.SelectedItem;
            resource.resourceType = (ResourceType)cbType.SelectedItem;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbResourceInfo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.ResetText();
                }
                if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).SelectedIndex = -1;
                    (ctrl as ComboBox).SelectedIndex = -1;
                }
            }

            resource = ResourceFactory.Create();
            dtpAddDate.Value = DateTime.Now;
            resource.purchaseDate = dtpAddDate.Value;
            pbImage.Image = null;
            errorProvider1.Clear();
            parent.StatusLabel.Text = "";
        }

        private bool FormIsClean()
        {
            bool isClean = true;

            foreach (Control ctrl in gbResourceInfo.Controls)
            {
                if (errorProvider1.GetError(ctrl) != string.Empty)
                {
                    isClean = false;
                    break;
                }
                if (ctrl.Text == string.Empty && ctrl != txtreferencenumber && ctrl != txtResourceID && ctrl != pbImage)
                {
                    isClean = false;
                    break;
                }
            }
            if (pbImage.Image == null)
            {
                isClean = false;
            }

            return isClean;
        }

        private void txttitle_Enter(object sender, EventArgs e)
        {
            errorProvider1.SetError((sender as Control), "");
            (sender as TextBox).SelectAll();
        }

        private void AddResource_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.StatusLabel.Text = "";
        }

        #endregion

        #region Image Loading

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.png, *.jpg)|*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(openFileDialog1.FileName);
                MemoryStream stream = new MemoryStream();
                pbImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.GetBuffer();
                resource.image = pic;
            }
        }

        #endregion

    }
}
