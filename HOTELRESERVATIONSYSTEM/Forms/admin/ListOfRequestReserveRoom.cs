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

namespace HOTELRESERVATIONSYSTEM.Forms.admin
{
    public partial class ListOfRequestReserveRoom : Form
    {
        tblUser userinfo = frm_Login.UserInfo;
        Room room = new Room();
        public ListOfRequestReserveRoom()
        {
            InitializeComponent();
        }

        private void ListOfRequestReserveRoom_Load(object sender, EventArgs e)
        {
            DataTable ret_dt = room.listofRequestReserveRoom();
            dataGridView1.DataSource = ret_dt;

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(btn);
            btn.HeaderText = "Approved";
            btn.Text = "Approved";
            btn.Name = "btnClick";
            btn.UseColumnTextForButtonValue = true;
            btn.DisplayIndex = 0;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string getValue = (string)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if(getValue == "Approved")
            {
                var requestId = dataGridView1.Rows[e.RowIndex].Cells["request_id"].Value.ToString();
                var retval = room.updateRequestReserveRoom(Int32.Parse(requestId), userinfo.id);
            }

        }
    }
}
