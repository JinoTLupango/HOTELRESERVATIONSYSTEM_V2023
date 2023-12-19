using HOTELRESERVATIONSYSTEM.AppData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTELRESERVATIONSYSTEM.Repository
{
    public class Room
    {
        private HotelReservationDBEntities db;
        public Room()
        {
            db = new HotelReservationDBEntities();
        }

        public List<tblRoom> getListofRoom()
        {
            return db.tblRooms.ToList();           
        }

        public Boolean insertRoomReservation(tblRoomBooked model)
        {
            try
            {
                db.tblRoomBookeds.AddObject(model);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public DataTable getListofReservationByUserID(int id)
        {
            DataTable dt = new DataTable();

            var ret = from resRoom in db.tblRoomBookeds.AsEnumerable()
                       join rm in db.tblRooms.AsEnumerable()
                             on resRoom.room_id equals rm.id
                       where resRoom.user_id == id
                       select new
                       {
                           id = resRoom.id,
                           room_no = rm.room_id,
                           floor_no = rm.floor_no,
                           check_From_To = resRoom.check_in_time.ToString() + " Of "
                                           + resRoom.check_in_date.ToString() + " - "
                                           + resRoom.Check_out_time.ToString() + " Of "
                                           + resRoom.check_in_date.ToString(),
                           status = resRoom.is_booked == true ? "Confirmed" : "Waiting for Review"
                       };

            dt.Columns.Add("id");
            dt.Columns.Add("room_no");
            dt.Columns.Add("floor_no");
            dt.Columns.Add("check_From_To");
            dt.Columns.Add("status");

            foreach (var i in ret.ToList())
            {
                dt.Rows.Add(i.id, i.room_no, i.floor_no, i.check_From_To, i.status);
            }

            return dt;
        }
        
        public DataTable listofRequestReserveRoom()
        {
            DataTable dt = new DataTable();
            var ret = from resRoom in db.tblRoomBookeds.AsEnumerable()
                      join rm in db.tblRooms.AsEnumerable()
                            on resRoom.room_id equals rm.id
                      where resRoom.is_booked != true
                      select new
                      {
                          id = resRoom.id,
                          room_no = rm.room_id,
                          floor_no = rm.floor_no,
                          check_From_To = resRoom.check_in_time.ToString() + " Of "
                                          + resRoom.check_in_date.ToString() + " - "
                                          + resRoom.Check_out_time.ToString() + " Of "
                                          + resRoom.check_in_date.ToString(),
                          status = resRoom.is_booked == true ? "Confirmed" : "Waiting for Review"
                      };

            dt.Columns.Add("request_id");
            dt.Columns.Add("room_no");
            dt.Columns.Add("floor_no");
            dt.Columns.Add("check_From_To");
            dt.Columns.Add("status");

            foreach (var i in ret.ToList())
            {
                dt.Rows.Add(i.id, i.room_no, i.floor_no, i.check_From_To, i.status);
            }
            return dt;
        }

        public bool updateRequestReserveRoom(int reqID, int user_id)
        {
            var model = db.tblRoomBookeds.Where(s => s.id == reqID).FirstOrDefault();
            model.approved_by = user_id;
            model.is_booked = true;
            model.approved_datetime = DateTime.Now;
            model.status = "Reserved";
            db.SaveChanges();

            return true;
        }
    }
}
