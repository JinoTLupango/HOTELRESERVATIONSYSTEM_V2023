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

namespace HOTELRESERVATIONSYSTEM.Forms
{
    public partial class GuestDashboard : Form
    {
        public GuestDashboard()
        {
            InitializeComponent();
        }

        private void roomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reserveARoomToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listOfAvaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RequestReserveRoom().Show();
            
        }

        private void myReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
