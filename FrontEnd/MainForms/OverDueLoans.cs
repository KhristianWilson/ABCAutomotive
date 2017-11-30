using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class OverDueLoans : Form
    {
        private Main parent;
        public OverDueLoans(Main p)
        {
            parent = p;
            InitializeComponent();
        }

        #region Start Up

        private void OverDueLoans_Load(object sender, System.EventArgs e)
        {

        }

        #endregion

    }
}
