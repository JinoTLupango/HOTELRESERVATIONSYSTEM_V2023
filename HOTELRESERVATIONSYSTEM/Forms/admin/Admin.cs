using HOTELRESERVATIONSYSTEM.Forms.admin;
using HOTELRESERVATIONSYSTEM.Forms.Guest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELRESERVATIONSYSTEM
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        private void listOfGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfRequestReserveRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListOfRequestReserveRoom().Show();
        }

        private void calendarViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestCalendarView frm = new GuestCalendarView();
            frm.ShowDialog();
            //GuestCalendarView
        }

        private void frm_Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
