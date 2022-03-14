using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using Data_Access.Repository;
using HotelWinApp;

namespace HotelWinApp
{
    public partial class frmService : Form
    {
        IEmployeeRepository emloyeeRepository = new EmployeeRepository();
        BindingSource source;
        public frmService()
        {
            InitializeComponent();
        }

        private void txtServiceID_TextChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            dataGridView.CellDoubleClick += label3_Click;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }
        private void clearText()
        {
            txtServiceID.Text = string.Empty;
            txtServiceName.Text = string.Empty;
            txtServicePrice.Text = string.Empty;

        }
        //--
        private ServiceObject GetServiceObject()
        {
            ServiceObject serviceObject = null;
            try
            {
                serviceObject = new ServiceObject
                {
                    ServiceID = int.Parse(txtServiceID.Text),
                    ServiceName = txtServiceName.Text,
                    ServicePrice = decimal.Parse(txtServicePrice.Text),
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Get Service ");
            }
            return serviceObject;
        }
        public void LoadList()
        {
            var services = EmployeeRepository.GetEmployeeObject();
            try
            {
                // The BindingSource component is designed to simplify 
                // the process of binding controls to an underlying data source 
                source = new BindingSource();
                source.DataSource = services;
                txtServiceID.DataBindings.Clear();
                txtServiceName.DataBindings.Clear();
                txtServicePrice.DataBindings.Clear();

                txtServiceID.DataBindings.Add(" Text ", source, " ServiceID ");
                txtServiceName.DataBindings.Add(" Text ", source, " ServiceName ");
                txtServicePrice.DataBindings.Add(" Text ", source, " Price ");

                dataGridView.DataSource = null;
                dataGridView.DataSource = source;
                if (services.Count() == 0)
                {
                    clearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Load Service list ");
            }
        }
        // -- 
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadList();
        }
        private void btnReturn_Click(object sender, EventArgs e) => Close();
        // ----- 
        private void btnNew_Click(object sender, EventArgs e)
        {
            frmRoomDetail frmRoomDetail = new frmRoomDetail
            {
                Text = " Add Service ",
                InsertorUpdate = false,
                EmployeeRepository = employeeRepository
            };
            if (frmRoomDetail.ShowDialog() == DialogResult.OK)
            {
                LoadList()  ;
                // Set focus car inserted source . Position = source . Count -1 ; 
            }
        }
        // -- 
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var service = GetServiceObject();
                EmployeeRepository.DeleteEmployee(service.ServiceID);
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Delete a car ");
            }
            // end btnDelete_Click


        }

    }
}