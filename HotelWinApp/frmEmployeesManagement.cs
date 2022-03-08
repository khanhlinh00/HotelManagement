using BusinessObject;
using Data_Access.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelWinApp
{
    public partial class frmEmployeesManagement : Form
    {
        public frmEmployeesManagement()
        {
            InitializeComponent();
        }
        public IEmployeeRepository employeeRepository = new EmployeeRepository();
        BindingSource source;

        private void ClearText()
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
            txtPathImage.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {

        }
        public void LoadEmployeeList()
        {
            List<EmployeeObject> listMember = null;

            listMember = employeeRepository.GetEmployees().ToList<EmployeeObject>();
            if(listMember != null)
            { 
                try
                {
                    source = new BindingSource();
                    source.DataSource = listMember;

                    // Clear binding data
                    txtEmployeeID.DataBindings.Clear();
                    txtEmployeeName.DataBindings.Clear();
                    txtPathImage.DataBindings.Clear();
                    txtUsername.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();


                    txtEmployeeID.DataBindings.Add("Text", source, "EmployeeID");
                    txtEmployeeName.DataBindings.Add("Text", source, "EmployeeName");
                    txtPathImage.DataBindings.Add("Text", source, "PathImage");
                    txtUsername.DataBindings.Add("Text", source, "Username");
                    txtPassword.DataBindings.Add("Text", source, "Password");


                    dvgEmployees.DataSource = null;  // Clear grid data
                    dvgEmployees.DataSource = source;


                    if (listMember.Count() == 0)
                    {
                        ClearText();
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                    
                        btnDelete.Enabled = true;
                    
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load employee list");
                }
            }
            else
            {
                MessageBox.Show("Empty Data", "Alert");
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEmployeeList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployeesManagement_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
        }

        private void dvgEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new string('*', e.Value.ToString().Length);

            }
        }
    }
}
