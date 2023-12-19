using HOTELRESERVATIONSYSTEM.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTELRESERVATIONSYSTEM
{
    public partial class frm_Guest : Form
    {
        HotelReservationDBEntities db;
        private DataTable dataTable;
        RepositoryClass userRepo;
        int? userSelectedId = null;
        public frm_Guest()
        {
            InitializeComponent();
        }
        private void AddDataToDataTable()
        {
            DataRow newRow = dataTable.NewRow();
            newRow["Guest Name"] = txtGuestName.Text;
            newRow["Room Number"] = txtRoomNumber.Text;
            newRow["Room Type"] = txtRoomType.Text;
            newRow["Check-In Date"] = dateTimePicker1.Text;
            newRow["Check-Out Date"] = dateTimePicker2.Text;

            dataTable.Rows.Add(newRow);
        }
        private void loadUser()
        {
            dataGridView1.DataSource = userRepo.UserAccounts();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {


            String Guest_Name = txtGuestName.Text;
            String Room_No = txtRoomNumber.Text;
            String Room_Type = txtRoomType.Text;
            String Check_In = dateTimePicker1.Text;
            String Check_Out = dateTimePicker2.Text;
            //String Role = RoleComboBox.Text;

            String strOutputMsg = "";
            if (String.IsNullOrEmpty(txtGuestName.Text))
            {
                errorProvider1.SetError(txtGuestName, "Empty field");
                return;

            }

            if (String.IsNullOrEmpty(txtRoomNumber.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRoomNumber, "Empty field");
                return;
            }

            if (String.IsNullOrEmpty(txtRoomType.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRoomType, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(dateTimePicker1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dateTimePicker1, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(dateTimePicker2.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dateTimePicker2, "Empty field");
                return;
            }

           // tblUser newUserAcc = new tblUser();
           // newUserAcc.GuestName = txtGuestName.Text;
           // newUserAcc.RoomNo = (Convert.ToInt32(txtRoomNumber.Text));
           ////newUserAcc.roleId = cmBoxRole.SelectedIndex;
           // newUserAcc.RoomType = txtRoomType.Text;
           // newUserAcc.CheckIn = dateTimePicker1.Text;
           // newUserAcc.CheckOut = dateTimePicker2.Text;

            //db.UserAccounts.Add(newUserAcc);
            //db.SaveChanges();
            //ErrorCode retValue = userRepo.NewUser(newUserAcc, ref strOutputMsg);
            //if (retValue == ErrorCode.Success)
            //{
            //    //Clear the errors
            //    errorProvider1.Clear();
            //    MessageBox.Show(strOutputMsg, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    loadUser();

            //    txtGuestName.Clear();
            //    txtRoomNumber.Clear();
            //    txtRoomType.Clear();
            //   // dateTimePicker1.Clear();
            //    //dateTimePicker2.Clear();
            //    //RoleComboBox.ResetText();

            //}
            //else
            //{
            //    // error 
            //    MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }



        // Create new object of USER_ACCOUNT
        //  UserAccount newUserAcc = new UserAccount();
        //    newUserAcc.GuestName = txtGuestName.Text;
        //    newUserAcc.RoomNo = txtRoomNo.TextLength;
        // // newUserAcc.RoleID = RoleComboBox.SelectedIndex;
        //    newUserAcc.RoomType = txtRoomType.Text;
        //    newUserAcc.CheckIn = dateTimePicker1.Text;
        //    newUserAcc.CheckOut = dateTimePicker2.Text;

        //    ErrorCode retValue = userRepo.NewUser(newUserAcc, ref strOutputMsg);
        //    if (retValue == ErrorCode.Success)
        //    {
        //        //Clear the errors
        //        //ErrorProviderUsername.Clear();
        //        MessageBox.Show(strOutputMsg, "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        loadUser();

        //        txtGuestName.Clear();
        //        txtRoomNo.Clear();
        //        txtRoomType.Clear();
        //        dateTimePicker1 = new DateTimePicker();
        //        dateTimePicker2 = new DateTimePicker();

        //    }
        //    else
        //    {
        //        // error 
        //        MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    }
        //}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtGuestName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as String;
                txtRoomNumber.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as String;
                txtRoomType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value as String;
                dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value as String;
                dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value as String;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void frm_Guest_Load(object sender, EventArgs e)
        {
            userRepo = new RepositoryClass();
            loadUser();
           
        }
        private void loadCbRole()
        {
            using (var db = new HotelReservationDBEntities ())
            {
                var roles = db.tblRoles.ToList();

                //cmBoxRole.ValueMember = "roleId";
                //cmBoxRole.DisplayMember = "roleName";
                //cmBoxRole.DataSource = roles;
            }

        }

        private void txtGuestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment();
            payment.ShowDialog();
        }
    }
}
