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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Register f1 = new Register();
            f1.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            
        }
    }
}
