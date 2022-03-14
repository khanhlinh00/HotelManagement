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

namespace HotelWinApp
{
    public partial class frmRoomManagement : Form
    {
        public frmRoomManagement()
        {
            InitializeComponent();
        }
        public IRoomRepository roomRepository = new RoomRepository();
        BindingSource source;
        private IEnumerable<RoomObject> RoomList;

        public void LoadRoomList()
        {
            List<RoomObject> listRoom = null;

            listRoom = roomRepository.GetRooms().ToList<RoomObject>();
            if (listRoom != null)
            {
                try
                {
                    source = new BindingSource();
                    source.DataSource = listRoom;

                    dvgRoom.DataSource = null;  // Clear grid data
                    dvgRoom.DataSource = source;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Load room list");
                }
            }
            else
            {
                MessageBox.Show("Empty Data", "Alert");
            }
        }
        private void frmRoomManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadRoomList();
        }

        private void btnModifyService_Click(object sender, EventArgs e)
        {
            try
            {
                frmService frmService = new frmService();
                frmService.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Service");
            }

        }

    }
}
