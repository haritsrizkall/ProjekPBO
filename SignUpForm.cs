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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            using (TestdbEntities context = new TestdbEntities())
            {
                Akun akun = new Akun();
                akun.Username = tbUsername.Text;
                akun.Password = tbPassword.Text;
                akun.Name = tbName.Text;
                akun.Age = Int16.Parse(tbAge.Text);

                context.Akuns.Add(akun);
                context.SaveChanges();

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }
    }
}
