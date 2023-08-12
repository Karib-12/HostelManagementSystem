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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonManageRoom_Click(object sender, EventArgs e)
        {
            AddNewRoom ar = new AddNewRoom();
            ar.Show();
        }

        private void buttonNewStudent_Click(object sender, EventArgs e)
        {
            NewStudents ns = new NewStudents();
            ns.Show();
        }

        private void buttonUpdateDelete_Click(object sender, EventArgs e)
        {
            UpdateDelete ud = new UpdateDelete();
            ud.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StudentsFees sf = new StudentsFees();
            sf.Show();
        }
    }
}
