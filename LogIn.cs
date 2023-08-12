using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagementSystem
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if(textUserName.Text == "karib" && textPassword.Text == "1234")
            {
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                textPassword.Clear();
            }
        }
    }
}
