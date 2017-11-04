using System;
using System.Reflection;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.StartUpForms
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            this.Text = String.Format("{0}", Application.ProductName);
            this.lblName.Text = Application.ProductName;
            this.lblVersion.Text = String.Format("Version {0}", Application.ProductVersion);
            var copyright = typeof(Splash).Assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            this.lblCopyright.Text = copyright;
            this.lblCompanyName.Text = Application.CompanyName;
        }

        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(15);
            if (progressBar.Value == 100)
            {
                LoadTimer.Stop();
                this.Close();
            }
        }
    }
}
