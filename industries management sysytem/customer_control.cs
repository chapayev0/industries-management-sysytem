using industries_management_sysytem.Includes;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace industries_management_sysytem
{
    public partial class customer_control : UserControl
    {
        public customer_control()
        {
            InitializeComponent();
        }


        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;


        private void btn_New_Click(object sender, EventArgs e)
        {

            trigger.Text = "id";
            

            config.Load_DTG("Select customer_id as 'Customer ID' ,name as 'Name',contact as 'Contact', address as 'Address',vat_num as 'VAT/SVAT Number' From customer_table", dtg_listUser);
            dtg_listUser.Columns[0].Visible = true;

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

            funct.clearTxt(Panel1);
        }

        private void customer_control_Load(object sender, EventArgs e)
        {
            btn_New_Click(sender, e);
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {
            if (staff_name.Text == "" || vat_id.Text == "" || staff_contct.Text == "" || Staff_address.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "insert into customer_table (name, contact, address, vat_num ) "
                     + "values('" + staff_name.Text + "','" + staff_contct.Text + "','" + Staff_address.Text
                     + "', '" + vat_id.Text + "')";
                config.Execute_CUD(sql, "Unable to saved", "Data has been saved in the database.");

                customer_control_Load(sender, e);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (staff_name.Text == "" || vat_id.Text == "" || staff_contct.Text == "" || Staff_address.Text == "" )
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                sql = "update customer_table set name = '" + staff_name.Text + "',contact= '" + staff_contct.Text
                          + "',address= '" + Staff_address.Text + "',vat_num= '" + vat_id.Text
                          +  "' where customer_id = " + trigger.Text;
                config.Execute_CUD(sql, "Unable to update", "Data has been updated in the database.");
                customer_control_Load(sender, e);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            sql = "delete from customer_table where customer_id = '" + trigger.Text + "'";
            config.Execute_CUD(sql, "unable to delete", "Data has been deleted in the database");
            customer_control_Load(sender, e);
        }

        private void dtg_listUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trigger.Text = dtg_listUser.CurrentRow.Cells[0].Value.ToString();
            

            staff_name.Text = dtg_listUser.CurrentRow.Cells[1].Value.ToString();
            staff_contct.Text = dtg_listUser.CurrentRow.Cells[2].Value.ToString();
            Staff_address.Text = dtg_listUser.CurrentRow.Cells[3].Value.ToString();
            vat_id.Text = dtg_listUser.CurrentRow.Cells[4].Value.ToString();

            Console.WriteLine(trigger.Text);
            Console.WriteLine("trigger text changed");


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
