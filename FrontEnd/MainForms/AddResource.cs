using ABCAutomotive.BusinessLayer;
using ABCAutomotive.Types;
using System;
using System.Drawing;
using System.IO;
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
            txtDesc.MaxLength = 50;
            txttitle.MaxLength = 30;
            txtpublisher.MaxLength = 30;
            txtreferencenumber.MaxLength = 50;
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            cbType.DataSource = Enum.GetValues(typeof(ResourceType));
            cbStatus.DataSource = Enum.GetValues(typeof(ResourceStatus));
            dtpAddDate.Value = DateTime.Now;
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            resource = ResourceFactory.Create();

            resource.purchaseDate = DateTime.Now;
            resource.resourceStatus = (ResourceStatus)cbStatus.SelectedItem;
            resource.resourceType = (ResourceType)cbType.SelectedItem;
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
                        errorProvider1.SetError(txtprice, "Price Must be a decimal amount");
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
                    parent.StatusLabel.Text = "Resource Added ID: " + resource.resourceid.ToString();                   
                }
                else
                {
                    MessageBox.Show("Some Flieds were left blank");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        #endregion

        #region House Keeping

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbResourceInfo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.ResetText();
                }
            }

            resource = ResourceFactory.Create();
            dtpAddDate.Value = DateTime.Now;
            cbStatus.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;
            cbType.SelectedIndex = -1;
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
                if (ctrl.Text == string.Empty && ctrl != txtreferencenumber && ctrl != pbImage)
                {
                    isClean = false;
                    break;
                }
            }

            return isClean;
        }

        #endregion

        #region Image Loading

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
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
