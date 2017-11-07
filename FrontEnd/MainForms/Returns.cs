using ABCAutomotive.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class Returns : Form
    {
        public Returns()
        {
            InitializeComponent();
        }

        List<LoansLookup> LoansList;
        List<StudentLookup> StudentList;

        private void Returns_Load(object sender, EventArgs e)
        {
            txtsearchResource.MaxLength = 50;
            dgvLoans.Visible = false;
            gbStudentsInfo.Visible = false;
            btnReturn.Visible = false;
            rdoDamged.Visible = false;
            rdoLost.Visible = false;
        }

        private void btnSearchResource_Click(object sender, EventArgs e)
        {
            try
            {
                LoansList = LoansLookupFactory.Create(Convert.ToInt32(txtsearchResource.Text));
                loadResourceInfo(LoansList);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtsearchResource, ex.Message);
            }
        }

        private void loadResourceInfo(List<LoansLookup> loansList)
        {
            throw new NotImplementedException();
        }

        private void loadStudentInfo()
        {
            throw new NotImplementedException();
        }
    }
}
