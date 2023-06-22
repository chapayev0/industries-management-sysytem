using industries_management_sysytem.Includes;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace industries_management_sysytem
{
    public partial class staff_control : UserControl
    {
        public staff_control()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;


        private void btn_New_Click(object sender, EventArgs e)
        {
            trigger.Text = "id";
            cbo_type.Text = "Administrator";

            config.Load_DTG("Select emp_id as 'emp_id' ,staff_name as 'Name',birth_day as 'Birth Day',address as 'Address', gender as 'Gender', nic as 'NIC', contact as 'Contact', staff_section as 'Section' From staff_table", dtg_listUser);
            dtg_listUser.Columns[0].Visible = true;

            if (lbl_id.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }

            funct.clearTxt(Panel1);
        }

        private void staff_control_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {

            if (staff_name.Text == "" || staff_nic.Text == "" || staff_contct.Text == "" || Staff_address.Text == "" || staff_id.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "insert into staff_table (staff_name, birth_day, address, gender, nic, contact, staff_section) "
                     + "values('" + staff_name.Text + "','" + staff_bd_picker.Value.ToString("yyyy-MM-dd")
                     + "','" + Staff_address.Text + "','" + gender_box.Text
                     + "', '" + staff_nic.Text + "', '" + staff_contct.Text + "', '" + cbo_type.Text + "')";
                config.Execute_CUD(sql, "Unable to saved", "Data has been saved in the database.");

                staff_control_Load(sender, e);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            if (staff_name.Text == "" || staff_nic.Text == "" || staff_contct.Text == "" || Staff_address.Text == "" || staff_id.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                
                sql = "update staff_table set staff_name = '" + staff_name.Text + "',birth_day= '" + staff_bd_picker.Value.ToString("yyyy-MM-dd")
                          + "',address= '" + Staff_address.Text + "',gender= '" + gender_box.Text
                          + "', ,nic= '" + cbo_type.Text
                          + "' ,contact= '" + staff_contct.Text + "',staff_section= '" + cbo_type.Text + "' where user_id = " + trigger.Text;
                config.Execute_CUD(sql, "Unable to update", "Data has been updated in the database.");
                staff_control_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "delete from staff_table where emp_id = '" + trigger.Text + "'";
            config.Execute_CUD(sql, "unable to delete", "Data has been deleted in the database");
            staff_control_Load(sender, e);
        }

        private void dtg_listUser_CellContentClick(object sender, DataGridViewCellEventArgs e)

            
        {
            trigger.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
            staff_id.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();

            string date = dtg_listUser.CurrentRow.Cells[2].Value.ToString();

            staff_name.Text = dtg_listUser.CurrentRow.Cells[1].Value.ToString() ;
            staff_bd_picker.Value = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Staff_address.Text = dtg_listUser.CurrentRow.Cells[3].Value.ToString();
            gender_box.Text = dtg_listUser.CurrentRow.Cells[4].Value.ToString();
            staff_nic.Text = dtg_listUser.CurrentRow.Cells[5].Value.ToString();
            staff_contct.Text = dtg_listUser.CurrentRow.Cells[6].Value.ToString();
            cbo_type.Text = dtg_listUser.CurrentRow.Cells[7].Value.ToString();
        }


        private void trigger_TextChanged(object sender, EventArgs e)


        {

            Console.WriteLine(trigger.Text);
            Console.WriteLine("trigger");


            if (trigger.Text == "id")
            {
                btn_update.Enabled = false;
                btn_delete.Enabled = false;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;
            }



        }


    }
}
