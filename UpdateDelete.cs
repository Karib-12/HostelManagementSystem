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
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
        {
            InitializeComponent();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            this.Location = new Point(478, 210);
        }
    }
}
