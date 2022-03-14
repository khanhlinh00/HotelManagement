﻿using BusinessObject;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public EmployeeObject EmployeeInfo { get; set; }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult alert = MessageBox.Show("Are you sure?", "Logout", MessageBoxButtons.YesNo);
            if(alert == DialogResult.Yes)
            {
                Close();
            }           
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmployeesManagement frmEmployeesManagement = new frmEmployeesManagement();
                frmEmployeesManagement.ShowDialog();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee");
            }
            

        }

        private void btnDetail1_Click(object sender, EventArgs e)
        {
            try
            {
                frmRoomDetail frmRoomDetail = new frmRoomDetail();
                frmRoomDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee");
            }
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            try
            {
                frmRoomManagement frmRoomManagement = new frmRoomManagement();
                frmRoomManagement.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee");
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                frmCustomerManagement frmCustomerManagement = new frmCustomerManagement();
                frmCustomerManagement.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee");
            }
        }
    }
}
