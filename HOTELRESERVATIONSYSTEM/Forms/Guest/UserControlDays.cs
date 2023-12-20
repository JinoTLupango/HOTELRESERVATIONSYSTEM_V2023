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
    public partial class UserControlDays : UserControl
    {
        public UserControlDays()
        {
            InitializeComponent();
        }

        public void days(int num)
        {
            lbl_days.Text = num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RequestReserveRoom().Show();
        }
    }
}
