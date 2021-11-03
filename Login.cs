using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_System
{
    public partial class Login : Form
    {
        
        
        public Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            bool t = true;
            {
               
                foreach (Users user in Register.MyList)
                {

                    if (txtUserName.Text == user.UserName && txtPassword.Text == user.Password)
                    {
                        t = true;
                        MessageBox.Show("Hey " + user.FirstName +" "+ user.LastName + " have a nice day");
                        break;
                    }
                    t = false;
                }

                if (t == false || txtUserName.Text=="" || txtPassword.Text=="")
                {
                    MessageBox.Show("User Name or Password not match");
                    
                }

            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }
    }
}
