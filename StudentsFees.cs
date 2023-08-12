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
    public partial class StudentsFees : Form
    {
        public StudentsFees()
        {
            InitializeComponent();
        }

        private void StudentsFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(478, 210);
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
