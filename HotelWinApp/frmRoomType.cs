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
    public partial class frmRoomType : Form
    {
        public frmRoomType()
        {
            InitializeComponent();
        }

        public IRoomRepository RoomRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public RoomObject RoomInfo { get; set; }

        private void frmRoomType_Load(object sender, EventArgs e)
        {
            cbRoomType.SelectedIndex = 0;
            comboBox1.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                comboBox1.Text = RoomInfo.RoomID.ToString();
                cbRoomType.Text = RoomInfo.RoomTypeID.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var room = new RoomObject
                {
                    RoomID = int.Parse(comboBox1.Text),
                    RoomTypeID = int.Parse(cbRoomType.Text)
                };
                if(InsertOrUpdate == false)
                {
                    RoomRepository.InsertRoom(room);
                }
                else
                {
                    RoomRepository.UpdateRoom(room);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add a new room" : "Update a room"); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
