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
    public partial class frmRoomDetail : Form
    {
        public frmRoomDetail()
        {
            InitializeComponent();
        }
        public EmployeeObject EmployeeInfo { get; set; }
        public int roomNumber { get; set; } // Receive Room Number from Main
        public string roomType { get; set; }
        public decimal price { get; set; }

        public IOrderRepository OrderRepository = new OrderRepository();
        //Data for sending back to Main
        public static string CustomerNameValue = "";
        public static string NumberCustomerValue = "";
        public static string NationalityValue = "";
        public static string CheckInValue = "";
        public static string CheckOutValue = "";
        public static int isRoom = 0;
        //-------------------------------
        public OrderObject CustomerInfo { get; set; }
        private void frmRoomDetail_Load(object sender, EventArgs e)
        {
            firstLoad();
        }

        public void firstLoad()
        {
            var roomTypeID = OrderRepository.GetRoomByID(roomNumber).RoomTypeID;
            roomType = OrderRepository.GetRoomTypeByID(roomTypeID).RoomType;
            price = OrderRepository.GetRoomByID(roomNumber).RoomPrice;

            txtRoomNumber.Text = roomNumber.ToString();
            txtRoomType.Text = roomType.ToString();
            txtRoomPrice.Text = price.ToString();
            lbTotalDetailInfo.Text = price.ToString();
            lbTotal.Text = price.ToString();
            ClearText();

            txtRoomNumber.Enabled = false;
            txtRoomType.Enabled = false;
            txtRoomPrice.Enabled = false;
        }

        private void ClearText()
        {
            txtOrderID.Text = "";
            dtpCheckInDay.Value = DateTime.Now;
            txtCustomerName.Text = "";
            txtCustomerID.Text = "";
            txtNationality.Text = "";
            txtNumberOfCustomer.Text = "1";
            dtpCheckOutDay.Value = DateTime.Now;
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            try
            {
                frmAddService frmRoomDetail = new frmAddService();
                frmRoomDetail.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Employee");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void saveOrder()
        {
            try
            {
                var order = new OrderObject
                {
                    OrderID = int.Parse(txtOrderID.Text),
                    EmployeeID = EmployeeInfo.EmployeeID,
                    CustomerID = int.Parse(txtCustomerID.Text),
                    RoomID = roomNumber,
                    RoomType = roomType,
                    CheckInDay = dtpCheckInDay.Value,
                    NumberOfCustomer = int.Parse(txtNumberOfCustomer.Text),
                    OrderDay = dtpCheckOutDay.Value,
                    Total = Decimal.Parse(lbTotalDetailInfo.Text),

                };
                if (txtOrderID.Text.Trim() == string.Empty || txtCustomerID.Text.Trim() == string.Empty ||
                    txtRoomType.Text.Trim() == string.Empty || txtNumberOfCustomer.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Your field is Empty", "Add Alert");
                    DialogResult = DialogResult.None;
                }
                else
                {
                    OrderRepository.InsertOrder(order);
                    MessageBox.Show("Add Success!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Order Alert");
            }
        }

        public void saveCustomer()
        {
            try
            {
                var customer = new CustomerObject
                {
                    CustomerID = int.Parse(txtCustomerID.Text),
                    CustomerName = txtCustomerName.Text,
                    Nationality = txtNationality.Text,
                };
                if (txtCustomerID.Text.Trim() == string.Empty || txtCustomerName.Text.Trim() == string.Empty ||
                    txtNationality.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Your field is Empty", "Add Alert");
                    DialogResult = DialogResult.None;
                }
                else
                {
                    OrderRepository.InsertCustomer(customer);
                    //MessageBox.Show("Add Success!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Customer Alert");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerNameValue = txtCustomerName.Text;
            NumberCustomerValue = txtNumberOfCustomer.Text;
            NationalityValue = txtNationality.Text;
            CheckInValue = dtpCheckInDay.Text;
            CheckOutValue = dtpCheckOutDay.Text;
            isRoom = roomNumber;
            MessageBox.Show("Save Success!");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            saveCustomer();
            saveOrder();
            var numberCustomer = txtNumberOfCustomer.Text;
            if (numberCustomer == null || numberCustomer.Trim() == string.Empty || numberCustomer == "0")
            {
                MessageBox.Show("Please check number again!", "Add Alert");
                DialogResult = DialogResult.None;
            }
            else
            {
                price = price * Decimal.Parse(numberCustomer);
                lbTotalDetailInfo.Text = price.ToString();
                lbTotal.Text = price.ToString();

            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            firstLoad();
        }
    }
}
