using HOTELRESERVATIONSYSTEM.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELRESERVATIONSYSTEM
{
    internal class userLogged
    {
        //
        private static userLogged _instance;
        internal static Role roleId;


        // *********** Member 
        public UserAccount UserAccount { get; set; }


        //************
        private userLogged()
        {

        }

        public static userLogged GetInstance()
        {
            if (_instance == null)
                _instance = new userLogged();
            return _instance;
        }
    }
}
