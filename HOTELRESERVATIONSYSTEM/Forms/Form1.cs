using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HOTELRESERVATIONSYSTEM.AppData;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace HOTELRESERVATIONSYSTEM
{
    public partial class frm_Login : Form
    {
        Repository userRepo;

        public frm_Login()
        {
            InitializeComponent();
            userRepo = new Repository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                ErrorProvider1.SetError(txtUsername, "Empty Field!");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                ErrorProvider1.SetError(txtPassword, "Empty Field!");
                return;
            }

            var userLogged = userRepo.GetUserByUsername(txtUsername.Text);

            if (userLogged != null)
            {
                if (userLogged.RoomType.Equals(txtPassword.Text))
                {
                    switch ((Role)Int32.Parse(userLogged.roleId))
                    {
                        case Role.Admin:
                            // Load student Dashboard
                            new frm_Admin().Show();
                            this.Hide();
                            break;

                        case Role.Guest:
                            // Load Teacher Dashboard
                            new frm_Guest().Show();
                            this.Hide();
                            break;

                        case Role.Staff:
                            // Load Admin Dashboard
                            new frm_Staff().Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Log In Success");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Password");
                }
            }
            else
            {
                MessageBox.Show("Successfully!");
                //frm_Guest frm = new frm_Guest();
                //frm.ShowDialog();

                
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Register frm = new frm_Register();
            frm.ShowDialog();

            //txtUsername.Text = frm.username;
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {

        }

        private void chBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
    
}
