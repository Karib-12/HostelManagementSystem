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
    public partial class NewStudents : Form
    {
        public NewStudents()
        {
            InitializeComponent();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewStudents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(478, 210);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxMbl.Clear();
            textBoxName.Clear();
            textBoxFname.Clear();
            textBoxMname.Clear();
            textBoxCname.Clear();
            textBoxAddress.Clear();
            textBoxId.Clear();
            textBoxMail.Clear();
            comboBoxRoomno.Items.Clear();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data saved");
            textBoxMbl.Clear();
            textBoxName.Clear();
            textBoxFname.Clear();
            textBoxMname.Clear();
            textBoxCname.Clear();
            textBoxAddress.Clear();
            textBoxId.Clear();
            textBoxMail.Clear();
            comboBoxRoomno.Items.Clear();
        }
    }
}
