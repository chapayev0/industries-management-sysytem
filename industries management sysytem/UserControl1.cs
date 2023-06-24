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

namespace industries_management_sysytem
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            
        }

        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void UserControl1_Load(object sender, EventArgs e)
        {

            sql = "SELECT SUPLIERCUSTOMERID FROM tblperson WHERE TYPE = 'CUSTOMER'";
            config.autocomplete(sql, txt_cusid);

            sql = "SELECT `ITEMID` as 'Item Id', `NAME` as 'Name', `DESCRIPTION` as 'Description', `PRICE` as 'Price', `QTY` as 'Available Quantity' FROM `tblitems`";
            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);

        }

        private void txt_cusid_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("text chnge working");
            sql = "select * from tblperson where SUPLIERCUSTOMERID =" + txt_cusid.Text;

            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)
            {
                txtCus_fname.Text = config.dt.Rows[0].Field<string>("FIRSTNAME");
                Console.WriteLine(txtCus_fname.Text);
                txtCus_lname.Text = config.dt.Rows[0].Field<string>("LASTNAME");
            }
            else
            {
                Console.WriteLine("text chnge");
                txtCus_fname.Clear();
                txtCus_lname.Clear();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `ITEMID` as 'Item Id', `NAME` as 'Name', `DESCRIPTION` as 'Description', `PRICE` as 'Price', `QTY` as 'Available Quantity' FROM `tblitems` WHERE  `NAME` like '%" + txtsearch.Text + "%' or `ITEMID` = '" + txtsearch.Text + "'";
            config.Load_DTG(sql, dtgCus_itemlist);
            funct.ResponsiveDtg(dtgCus_itemlist);
        }

        private void dtgCus_itemlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            double tot;
            int qty;

            if (dtCus_addedlist.RowCount == 0)
            {


                qty = 1;
                tot = double.Parse(dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString()) * 1;
                string[] row = new string[] { dtgCus_itemlist.CurrentRow.Cells[0].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[1].Value.ToString(),
                dtgCus_itemlist.CurrentRow.Cells[2].Value.ToString(),
                dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString(),
                 qty.ToString(),
                tot.ToString()};

                dtCus_addedlist.Rows.Add(row);


            }
            else
            {
                foreach (DataGridViewRow r in dtCus_addedlist.Rows)
                {
                    if (dtgCus_itemlist.CurrentRow.Cells[0].Value == r.Cells[0].Value)
                    {
                        MessageBox.Show("Item is already in the cart", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }

                if (dtCus_addedlist.CurrentRow.Cells[0].Value != dtgCus_itemlist.CurrentRow.Cells[0].Value)
                {
                    qty = 1;
                    tot = double.Parse(dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString()) * 1;
                    string[] row = new string[] { dtgCus_itemlist.CurrentRow.Cells[0].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[1].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[2].Value.ToString(),
                    dtgCus_itemlist.CurrentRow.Cells[3].Value.ToString(),
                     qty.ToString(),
                    tot.ToString()};
                    dtCus_addedlist.Rows.Add(row);
                }
                else
                {
                    MessageBox.Show("Item is already in the cart", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }



            }
        }

        private void btnCus_save_Click(object sender, EventArgs e)
        {
            string stockoutID;

            config.singleResult("SELECT concat(STRT,END) FROM tblautonumber WHERE ID = 5");
            stockoutID = config.dt.Rows[0].Field<string>(0);

            if (txt_cusid.Text == "")
            {
                MessageBox.Show("There are empty fields left that must be fill up!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (dtCus_addedlist.RowCount == 0)
            {
                MessageBox.Show("Cart is empty!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sql = "SELECT ITEMID,`QTY` FROM `tblitems`";
            config.singleResult(sql);

            foreach (DataRow row in config.dt.Rows)
            {
                for (int i = 0; i < dtCus_addedlist.Rows.Count; i++)
                {
                    if (dtCus_addedlist.Rows[i].Cells[0].Value.ToString() == row.Field<string>(0))
                    {
                        if (int.Parse(dtCus_addedlist.Rows[i].Cells[4].Value.ToString()) > row.Field<int>(1))
                        {
                            MessageBox.Show("The Quantity of the item ( " + dtCus_addedlist.Rows[i].Cells[1].Value.ToString() + " ) is greater than the available quantity of it.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    if (dtCus_addedlist.Rows[i].Cells[4].Value.ToString() == "")
                    {
                        MessageBox.Show("Set your purpose.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }

            foreach (DataGridViewRow r in dtCus_addedlist.Rows)
            {
                sql = "INSERT INTO `tblstock_in_out` ( `TRANSACTIONNUMBER`, `ITEMID`, `TRANSACTIONDATE`, `QTY`, `TOTALPRICE`, `SUPLIERCUSTOMERID`,REMARKS)" +
                " VALUES ('" + stockoutID + "','" + r.Cells[0].Value + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + r.Cells[4].Value +
                "','" + r.Cells[5].Value + "','" + txt_cusid.Text + "','StockOut')";
                config.Execute_Query(sql);

                sql = "UPDATE `tblitems`  SET `QTY`= QTY - '" + r.Cells[4].Value + "' WHERE ITEMID='" + r.Cells[0].Value + "'";
                config.Execute_Query(sql);
            }


            sql = "INSERT INTO  `tbltransaction` (`TRANSACTIONNUMBER`,  `TRANSACTIONDATE`,  `TYPE`, `SUPLIERCUSTOMERID`)" +
                   " VALUES ('" + stockoutID + "','" + DateTime.Now.ToString("yyyy-MM-dd") + "','StockOut','" + txt_cusid.Text + "')";
            config.Execute_Query(sql);

            // '-----------------------------------------------update autonumber
            config.Execute_Query("UPDATE tblautonumber SET END= END + INCREMENT WHERE ID = 5");

            // '------------------------------------------------------------
            MessageBox.Show("Item(s) has been save in the database.");
            // '------------------------------------------------------------clearing
            funct.clearTxt(Panel1);
            dtCus_addedlist.Rows.Clear();

            UserControl1_Load(sender, e);
        }

        private void btnCus_Remove_Click(object sender, EventArgs e)
        {

            dtCus_addedlist.Rows.Remove(dtCus_addedlist.CurrentRow);
        }

        private void btnCus_clear_Click(object sender, EventArgs e)
        {
            dtCus_addedlist.Rows.Clear();
        }
    }
}
