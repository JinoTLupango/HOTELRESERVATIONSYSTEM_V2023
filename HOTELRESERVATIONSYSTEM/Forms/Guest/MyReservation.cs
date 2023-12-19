using HOTELRESERVATIONSYSTEM.AppData;
using HOTELRESERVATIONSYSTEM.Repository;
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
    public partial class MyReservation : Form
    {
        Room room = new Room();
        tblUser userifo = frm_Login.UserInfo;
        public MyReservation()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           DataTable ret_dt = room.getListofReservationByUserID(userifo.id);
            dataGridView1.DataSource = ret_dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
