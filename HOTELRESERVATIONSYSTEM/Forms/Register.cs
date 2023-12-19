using HOTELRESERVATIONSYSTEM.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HOTELRESERVATIONSYSTEM
{
    public partial class frm_Register : Form
    {
      
        HotelModelEntities db;
        public frm_Register()
        {
            InitializeComponent();
            db = new HotelModelEntities();
        }
        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            //var roles = db.Roles.ToList();

            cmBoxRole.ValueMember = "roleId";
            cmBoxRole.DisplayMember = "roleName";
            cmBoxRole.DataSource = Enum.GetValues(typeof(Role));

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }

            if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Password not match");
                return;
            }
            UserAccount nUserAccount = new UserAccount();
            nUserAccount.GuestName = txtUsername.Text;
            //nUserAccount.HotelCode = txtRoomNo.Text;
            //nUserAccount.roleId = (String)cbBoxRole.SelectedValue;
            //nUserAccount.RoomNo = "Active";

            //Username = txtUsername.Text;

            db.UserAccounts.Add(nUserAccount);
            db.SaveChanges();

            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtUsername.Clear();
            MessageBox.Show("Registered!");

            frm_Login frm = new frm_Login();
            frm.ShowDialog();

        }

        private void frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Login frm = new frm_Login();
            frm.ShowDialog();
        }
    }
}
