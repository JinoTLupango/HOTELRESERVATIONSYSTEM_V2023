using HOTELRESERVATIONSYSTEM.AppData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELRESERVATIONSYSTEM
{
    public class Repository
    {
        private HotelReservationDBEntities db;
        public Repository()
        {
            db = new HotelReservationDBEntities();
        }

        internal static object Login(string text1, object text2, ref string role, ref object szResponse)
        {
            throw new NotImplementedException();
        }

        public tblUser GetUserByUsername(String username)
        {
            // re-initialize db object because sometimes data in the list not updated
            using (db = new HotelReservationDBEntities())
            {
                // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
                return db.tblUsers.Where(s => s.username == username).FirstOrDefault();
            }
        }

        public ErrorCode NewUser(tblUser aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                db.tblUsers.AddObject(aUserAccount);
                db.SaveChanges();

                outMessage = "Account Created";
                retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public List<tblUser> UserAccounts()
        {
            db = new HotelReservationDBEntities();

            return db.tblUsers.ToList();
        }


        public ErrorCode UpdateUser(int? userId, tblUser aUserAccount, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                //// Find the user with id
                //tblUser user = db.tblUser.Where(m => m.RoomNo == userId).FirstOrDefault();

                //if (user != null)
                //{
                //    //Update the value of the retrieved user
                //    user.RoomNo = aUserAccount.RoomNo;
                //    user.GuestName = aUserAccount.GuestName;
                //    user.RoomType = aUserAccount.RoomType;
                //    user.CheckIn = aUserAccount.CheckIn;
                //    user.CheckOut = aUserAccount.CheckOut;
                    

                //    db.SaveChanges(); // Execute the update

                //    outMessage = "Updated";
                //    retValue = ErrorCode.Success;
                //}
                //else
                //{
                //    outMessage = "User not found";
                //}
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }

        public ErrorCode RemoveUser(int? userId, ref String outMessage)
        {
            ErrorCode retValue = ErrorCode.Error;
            try
            {
                //UserAccount user = db.UserAccounts.Where(m => m.RoomNo == userId).FirstOrDefault();
                //// Remove the user
                //db.UserAccounts.Remove(user);
                //db.SaveChanges();       // Execute the update

                //outMessage = "Deleted";
                //retValue = ErrorCode.Success;
            }
            catch (Exception ex)
            {
                outMessage = ex.Message;
                retValue = ErrorCode.Error;
                MessageBox.Show(ex.Message);
            }
            return retValue;
        }
        //public UserAccount GetUserByUsername(String username)
        //{
        //    // re-initialize db object because sometimes data in the list not updated
        //    using (db = new HotelModelEntities())
        //    {
        //        // SELECT TOP 1 * FROM USERACCOUNT WHERE userName == username
        //        return db.UserAccounts.Where(s => s.GuestName == username).FirstOrDefault();
        //    }
        //}
        public List<tblUser> UserAccount()
        {
            using (db = new HotelReservationDBEntities())
            {
                return db.tblUsers.ToList();
            }
        }

        public List<tblRole> AllUserRole()
        {
            using (db = new HotelReservationDBEntities())
            {
                return db.tblRoles.ToList();
            }
        }
        public ErrorCode CreateUserUsingStoredProf(String username, String password, int role, String status, int createdBy, ref String szResponse)
        {
            try
            {
                using (db = new HotelReservationDBEntities())
                {
                    // Call the create stored procedure
                    //
                    //db.sp_CreateUser(username, password, role, status, createdBy);
                    szResponse = "Created";
                    return ErrorCode.Success;
                }
            }
            catch (Exception ex)
            {
                szResponse = ex.Message;
                return ErrorCode.Error;
            }
        }
    }
}

