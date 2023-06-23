using industries_management_sysytem.Includes;
using MySqlX.XDevAPI.Common;
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

            users_control1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)

        {

            Console.WriteLine("codefdejnrf");

            users_control1.SendToBack();

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

        private void staff_control1_Load(object sender, EventArgs e)
        {

            staff_control1.lbl_id.Text = "id";
            staff_control1.cbo_type.Text = "Administrator";

            config.Load_DTG("Select emp_id as 'EMP ID' ,staff_name as 'Name',birth_day as 'Birth Day',address as 'Address', gender as 'Gender', nic as 'NIC', contact as 'Contact', staff_section as 'Section' From staff_table", staff_control1.dtg_listUser);
            staff_control1.dtg_listUser.Columns[0].Visible = true;

            if (staff_control1.lbl_id.Text == "id")
            {
                staff_control1.btn_update.Enabled = false;
                staff_control1.btn_delete.Enabled = false;
                staff_control1.btn_saveuser.Enabled = true;
            }
            else
            {
                staff_control1.btn_saveuser.Enabled = false;
                staff_control1.btn_update.Enabled = true;
                staff_control1.btn_delete.Enabled = true;
            }

            funct.clearTxt(staff_control1.Panel1);

        }

            private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void dashboard_Load(object sender, EventArgs e)

        {

            Console.WriteLine("dash load");

            string result;
            result = config.data;

            Console.WriteLine(result);

            if (result == "System Admin")


            {

                dash_title.Text = "Administrator Dashboard";
 
                users_control1.BringToFront();


            }
            else if (result == "HR Admin")

            {

                dash_title.Text = "Human Resource Dashboard";


                staff_control1.BringToFront();

            }
            else if (result == "Recption Admin")
            {

 
                staff_control1.BringToFront();

            }
            else if (result == "Store Admin")
            {


                staff_control1.BringToFront();

            }

        }

        private void customer_control1_Load(object sender, EventArgs e)
        {

            customer_control1.lbl_id.Text = "id";


            config.Load_DTG("Select customer_id as 'Customer ID' ,name as 'Name',contact as 'Contact', address as 'Address',vat_num as 'VAT/SVAT Number' From customer_table", customer_control1.dtg_listUser);
            customer_control1.dtg_listUser.Columns[0].Visible = true;

            if (customer_control1.lbl_id.Text == "id")
            {
                customer_control1.btn_update.Enabled = false;
                customer_control1.btn_delete.Enabled = false;
                customer_control1.btn_saveuser.Enabled = true;
            }
            else
            {
                customer_control1.btn_saveuser.Enabled = false;
                customer_control1.btn_update.Enabled = true;
                customer_control1.btn_delete.Enabled = true;
            }

            funct.clearTxt(customer_control1.Panel1);
        }
    }
}
