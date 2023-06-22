using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using industries_management_sysytem.Includes;

namespace industries_management_sysytem
{
    public partial class login_frm : Form
    {
        public login_frm()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            usr_txt.Clear();
            passw_txt.Clear();
            usr_txt.Focus();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            sql = " SELECT* FROM user WHERE user_name = '" + usr_txt.Text + "' and pass = sha1('" + passw_txt.Text + "')";
            config.singleResult(sql);
            if (config.dt.Rows.Count > 0)


            {
                // Create an instance of the new form
                dashboard form2 = new dashboard();

                // Show the new form


                this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Account does not exist! Please contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void usr_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
