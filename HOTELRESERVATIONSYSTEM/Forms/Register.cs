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
      
        HotelReservationDBEntities db;
        public frm_Register()
        {
            InitializeComponent();
            db = new HotelReservationDBEntities();
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
            if(cmBoxRole.SelectedItem.ToString().ToUpper() == "SELECT" || String.IsNullOrEmpty(cmBoxRole.SelectedItem.ToString()))
            {
                MessageBox.Show("Please select role!");
                return;
            }
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Empty field");
                return;
            }else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }
            else if (String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }
            else if (!txtPassword.Text.Equals(txtConfirmPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtConfirmPassword, "Password not match");
                return;
            }
            tblUser nUserAccount = new tblUser();
            nUserAccount.name = txtUsername.Text;
            nUserAccount.username = txtUsername.Text;
            nUserAccount.password = txtPassword.Text;
            nUserAccount.status = txtUsername.Text;
            nUserAccount.role_id = cmBoxRole.SelectedIndex;
            nUserAccount.is_active = true;
            nUserAccount.is_deleted = false;
            nUserAccount.tdt = DateTime.Now;
            nUserAccount.udt = DateTime.Now;

            db.tblUsers.AddObject(nUserAccount);
            db.SaveChanges();

            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtUsername.Clear();
            MessageBox.Show("Registered!");

            this.Hide();
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
