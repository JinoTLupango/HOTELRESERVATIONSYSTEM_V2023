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
    public partial class GuestCalendarView : Form
    {
        public GuestCalendarView()
        {
            InitializeComponent();
        }

        private void GuestCalendarView_Load(object sender, EventArgs e)
        {
            this.DisplayDaysoftheMonth();
        }

        public void DisplayDaysoftheMonth()
        {
            DateTime now = DateTime.Now;

            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);

            int countDays = DateTime.DaysInMonth(now.Year, now.Month);
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            for (int i = 0; i < dayoftheweek; i++)
            {
                UserControlBlank userControlBlank = new UserControlBlank();
                flowLayoutPanel1.Controls.Add(userControlBlank);
            }

            for (int i = 1; i <= countDays; i++)
            {
                UserControlDays userControlDays = new UserControlDays();
                userControlDays.days(i);
                flowLayoutPanel1.Controls.Add(userControlDays);
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
