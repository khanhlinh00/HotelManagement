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

        private void frmRoomDetail_Load(object sender, EventArgs e)
        {

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
    }
}
