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
    public partial class AddNewRoom : Form
    {
        Function fn = new Function();
        String query;
        
        public AddNewRoom()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewRoom_Load(object sender, EventArgs e)
        {
            this.Location = new Point(478, 210);

            labelRoomExist.Visible = false;
            labelRoom.Visible = false;

            query = "select * from [dbo].[Table]";
            DataSet ds = fn.getData(query);
            dataGridViewAllRoom.DataSource = ds.Tables[0];
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            query = "select * from [dbo].[Table] = "+textBoxAddRoomNum.Text+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                String status;
                if (checkBoxRoomAdd.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelRoomExist.Visible = false;
                query = "insert into [dbo].[Table](RoomNo, RoomStatus) value(" + textBoxAddRoomNum + ", '" + status + "')";
                fn.setData(query, "Room added.");
                AddNewRoom_Load(this, null);
            }
            else
            {
                labelRoomExist.Text = "Room already exist.";
                labelRoomExist.Visible = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            query = "select * from [dbo].[Table] where RoomNo=" + textBoxUpdateRoomNum.Text + "";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                labelRoom.Text = "NO room exist.";
                labelRoom.Visible = true;
                checkBoxActivate.Checked = false;
            }
            else
            {
                labelRoom.Text = "Room Found.";
                labelRoom.Visible = true;
            }
        }
    }
}
