using industries_management_sysytem.Includes;
using industries_management_sysytem.Properties;
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
        string user_type;
        string login_status;

        private bool isDragging = false;
        private Point lastLocation;


        private void button1_Click(object sender, EventArgs e)

        {

            dash_title.Text = "Store Section Dashboard";

            users_control1.BringToFront();

        }
        private void button2_Click(object sender, EventArgs e)

        {

            dash_title.Text = "Sysytem Administrator Dashboard";

            users_control1.BringToFront();

        }
        private void button3_Click(object sender, EventArgs e)

        {

            dash_title.Text = "HR Section Dashboard";

            staff_control1.BringToFront();

        }
        private void button4_Click(object sender, EventArgs e)

        {

            Console.WriteLine("codefdejnrf");

            customer_control1.BringToFront();

        }
        private void button5_Click(object sender, EventArgs e)

        {

            dash_title.Text = "Recipition Section Dashboard";

            customer_control1.BringToFront();

        }
        private void button6_Click(object sender, EventArgs e)

        {

            dash_title.Text = "Store Section Dashboard";

            item_control1.BringToFront();

        }
        private void button7_Click(object sender, EventArgs e)

        {

            dash_title.Text = "Reception Section Dashboard";

            userControl11.BringToFront();

        }
        private void button8_Click(object sender, EventArgs e)

        {

            dash_title.Text = "Store Section Dashboard";

            stock_control1.BringToFront();

        }
        private void button9_Click(object sender, EventArgs e)

        {

            dash_title.Text = user_type + " Dashboard";

            users_control1.BringToFront();

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

            panel4.BringToFront();
            timer1.Start();


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

        public void enabled_menu(string type)
        {

            

            if (type == "System Admin")
            {
                Console.WriteLine("data recieved" + type);

                users_control users_control1 = new users_control();
                users_control1.BringToFront();
                dash_title.Text = "Sysytem Administrator Dashboard";

            }
            else if (type == "HR Admin")
            {
                staff_control1.BringToFront();
                dash_title.Text = "HR Administrator Dashboard";

            }else if(type == "Recption Admin")
            {
                customer_control1.BringToFront();
                dash_title.Text = "HR Section Dashboard";

            }else if(type == "Store Admin")
            {
                item_control1.BringToFront();
                dash_title.Text = "Store Section Dashboard";
            }
            

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
           


        }

        private void users_control1_Load_1(object sender, EventArgs e)
        {

        }

        private void login_btn_Click_1(object sender, EventArgs e)
        {

            sql = " SELECT* FROM user WHERE user_name = '" + user_txt.Text + "' and pass = sha1('" + pass_txt.Text + "')";

            //config.sql_data_return(sql);

            config.singleResult(sql);

            if (config.dt.Rows.Count > 0)
            {

                string data = config.dt.Rows[0].Field<string>("type").ToString();
                string name = config.dt.Rows[0].Field<string>("name").ToString();
                user_log_name.Text = name;
                user_type = data;
                login_status = "login";
                user_txt.Clear();
                pass_txt.Clear();
                user_txt.Focus();


                pictureBox1.Image = global::industries_management_sysytem.Properties.Resources.female_profile_40px;





                if (data == "System Admin")
                {

                    
                    Console.WriteLine("data recieved" + data);
                    users_control1.BringToFront();
                    dash_title.Text = "Sysytem Administrator Dashboard";

                }
                else if (data == "HR Admin")
                {
                    
                    staff_control1.BringToFront();
                    dash_title.Text = "HR Administrator Dashboard";

                }
                else if (data == "Recption Admin")
                {
                    
                    customer_control1.BringToFront();
                    dash_title.Text = "HR Section Dashboard";

                }
                else if (data == "Store Admin")
                {
                    
                    item_control1.BringToFront();
                    dash_title.Text = "Store Section Dashboard";
                }
            }else
            {
                user_log_name.Text = "LogIn";
                login_status = "logout";
                MessageBox.Show("Account does not exist! Please contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            user_txt.Clear();
            pass_txt.Clear();
            user_txt.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
            if (login_status == "login")
            {

                login_status = "logout";
                Console.WriteLine("picclisk " + login_status);
                panel4.BringToFront();
                user_txt.Clear();
                pass_txt.Clear();
                user_txt.Focus();


                pictureBox1.Image = global::industries_management_sysytem.Properties.Resources.male_user_50px;


            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y
                );
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            
        }
    }
}
