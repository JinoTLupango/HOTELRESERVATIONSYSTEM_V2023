using HOTELRESERVATIONSYSTEM.AppData;
using HOTELRESERVATIONSYSTEM.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELRESERVATIONSYSTEM.Forms.Guest
{
    public partial class RequestReserveRoom : Form
    {
        Room room;
        tblUser userinfo = frm_Login.UserInfo;
        List<tblRoom> listRoom = new List<tblRoom>();
        public RequestReserveRoom()
        {
            InitializeComponent();
            room = new Room();
        }

        private void RequestReserveRoom_Load(object sender, EventArgs e)
        {
            time_checkIn.Format = DateTimePickerFormat.Time;
            time_checkIn.ShowUpDown = true;
            time_check_out.Format = DateTimePickerFormat.Time;
            time_check_out.ShowUpDown = true;

            listRoom = room.getListofRoom();

            cmb_floor.ValueMember = "floor_no";
            cmb_floor.DisplayMember = "floor_no";
            cmb_floor.DataSource = listRoom.Select(x => x.floor_no).Distinct().ToList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblRoomBooked model = new tblRoomBooked();
            model.room_id = Int32.Parse(cmb_RoomNo.SelectedValue.ToString());
            model.user_id = userinfo.id;
            model.check_in_date = DateTime.Parse(dt_checkIn.Value.ToString());
            model.check_out_date = DateTime.Parse(dt_check_out.Value.ToString());
            model.check_in_time = TimeSpan.Parse(time_checkIn.Value.ToString("HH:mm:ss"));
            model.Check_out_time = TimeSpan.Parse(time_check_out.Value.ToString("HH:mm:ss"));
            model.status = "Request to Reserved";
            model.is_active = true;

            var ret = room.insertRoomReservation(model);

            if(ret)
            {
                /// code after condition.
            }

        }

        private void cmb_floor_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_RoomNo.ValueMember = "id";
            cmb_RoomNo.DisplayMember = "room_no";
            cmb_RoomNo.DataSource = listRoom.Where(i => 
            i.floor_no.ToString() == cmb_floor.SelectedItem.ToString())
            .Select(x => new
            {
                id = x.id,
                room_no = x.room_id
            }).Distinct().ToList();
        }
    }
}
