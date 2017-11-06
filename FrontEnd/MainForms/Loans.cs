using ABCAutomotive.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ABCAutomotive.FrontEnd.MainForms
{
    public partial class Loans : Form
    {
        public Loans()
        {
            InitializeComponent();
        }

        private void Loans_Load(object sender, System.EventArgs e)
        {
            dgvStudents.Visible = false;
            txtSearch.MaxLength = 50;
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            try
            {
                List<StudentLookup> StudentList;
                int x;

                if (int.TryParse(txtSearch.Text, out x))
                {
                    StudentList = StudentsLookupFactory.Create(x);
                }
                else
                {
                    StudentList = StudentsLookupFactory.Create(txtSearch.Text);
                }
                dgvStudents.DataSource = StudentList;
                dgvStudents.Visible = true;
                errorProvider1.Clear();
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtSearch, ex.Message);
            }
        }
    }
}
