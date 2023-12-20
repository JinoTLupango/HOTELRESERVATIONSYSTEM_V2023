using HOTELRESERVATIONSYSTEM.Forms.admin;
using HOTELRESERVATIONSYSTEM.Forms.Guest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELRESERVATIONSYSTEM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GuestCalendarView());
            //Application.Run(new RequestReserveRoom());
        }
    }
}
