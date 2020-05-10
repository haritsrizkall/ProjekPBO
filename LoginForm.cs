using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekUAS2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (TestdbEntities context = new TestdbEntities())
            {
                /*foreach (var akun in context.Akuns)
                {
                    if (akun.Username == tbUsername.Text && akun.Password == tbPassword.Text)
                    {
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username/Password Salah");
                    }
                }*/
                Akun akun = context.Akuns.FirstOrDefault(a => a.Username == tbUsername.Text);
                if (akun.Username == tbUsername.Text && akun.Password == tbPassword.Text)
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username / Password Salah");
                }

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using (TestdbEntities context = new TestdbEntities())
            {
                SignUpForm signUpForm = new SignUpForm();
                signUpForm.Show();
                this.Hide();
            }
                
            
        }
    }
}
