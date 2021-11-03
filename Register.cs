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
    public partial class Register : Form
    {
        public static List<Users> MyList { get; set; } = new List<Users>();
        public Register()
        {
            InitializeComponent();
            
        }
        
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool t = true;
            DateTime dt = DateTime.Now.AddYears(-18);
            
            foreach (var item in MyList)
            {
                if (item.UserName == txtUserName.Text)
                {
                    MessageBox.Show("User Name already exist");
                    t = false;
                    break;
                }

            }
                
              
            if (dateTimePicker1.Value > dt)
            {
                
                lbDate.ForeColor=Color.Red;
                t = false;   
            }
            else
                lbDate.ForeColor = Color.Black;
            if (txtPassword.Text.Length < 8)
            {
                lbPassword.ForeColor= Color.Red;
                t = false;
            }
            else
                lbPassword.ForeColor = Color.Black;
            if (txtFirstName.Text.Length < 2)
            {
                lbFirstN.ForeColor = Color.Red;
                t = false;
            }
            else
                lbFirstN.ForeColor = Color.Black;
            if (txtLastName.Text.Length < 2)
            {
                lbLastN.ForeColor = Color.Red;
                t = false;
            }
            else
                lbLastN.ForeColor = Color.Black;
            if (txtUserName.Text.Length < 5)
            {
                lbUserN.ForeColor = Color.Red;
                t = false;
            }
            else
                lbUserN.ForeColor = Color.Black;

            if (t==true)
                {
                Users users = new Users(txtFirstName.Text,txtLastName.Text,txtUserName.Text,txtPassword.Text,dateTimePicker1.Value);
                MyList.Add(users);
                MessageBox.Show("sign-up sucsses");
                Login l1 = new Login();
                l1.Show();
                this.Close();
                }
            
        }

 

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

            txtPassword.PasswordChar = '*';
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
