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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }


        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void login_btn_Click(object sender, EventArgs e)
        {

            sql = " SELECT* FROM user WHERE user_name = '" + user_txt.Text + "' and pass = sha1('" + pass_txt.Text + "')";

            config.sql_data_return(sql);

            Console.WriteLine(config.data);

            string data = config.data;

            dashboard frm = new dashboard();

            if (config.data != "")
            {
                frm.enabled_menu(data);
            }
            else
            {
                MessageBox.Show("Account does not exist! Please contact administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
