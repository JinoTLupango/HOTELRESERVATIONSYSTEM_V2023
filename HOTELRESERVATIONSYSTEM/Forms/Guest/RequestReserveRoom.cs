using HOTELRESERVATIONSYSTEM.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELRESERVATIONSYSTEM.Forms.Guest
{
    public partial class RequestReserveRoom : Form
    {
        tblUser userinfo = frm_Login.UserInfo;
        List<tblRoom> listRoom = new List<tblRoom>();
        public RequestReserveRoom()
        {
            InitializeComponent();
        }

        private void RequestReserveRoom_Load(object sender, EventArgs e)
        {
            time_checkIn.Format = DateTimePickerFormat.Time;
            time_checkIn.ShowUpDown = true;
            time_check_out.Format = DateTimePickerFormat.Time;
            time_check_out.ShowUpDown = true;   

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
