using industries_management_sysytem.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace industries_management_sysytem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void users_control1_Load(object sender, EventArgs e)
        {

            users_control1.lbl_id.Text = "id";
            users_control1.cbo_type.Text = "Administrator";

            config.Load_DTG("Select user_id as 'ID' ,name as 'Name',user_name as 'Username',type as 'Type' From user", users_control1.dtg_listUser);
            users_control1.dtg_listUser.Columns[0].Visible = false;

            if (users_control1.lbl_id.Text == "id")
            {
                users_control1.btn_update.Enabled = false;
                users_control1.btn_delete.Enabled = false;
                users_control1.btn_saveuser.Enabled = true;
            }
            else
            {
                users_control1.btn_saveuser.Enabled = false;
                users_control1.btn_update.Enabled = true;
                users_control1.btn_delete.Enabled = true;
            }

            funct.clearTxt(users_control1.Panel1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
