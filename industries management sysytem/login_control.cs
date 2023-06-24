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
    public partial class login_control : UserControl
    {

       
        public login_control()
        {
            InitializeComponent();
            
        }

        SQLConfig config = new SQLConfig();
        string sql;
        dashboard form2 = new dashboard();


        private void login_btn_Click(object sender, EventArgs e)
        {
            sql = " SELECT* FROM user WHERE user_name = '" + usr_txt.Text + "' and pass = sha1('" + passw_txt.Text + "')";
            config.sql_data_return(sql);
            string result = config.data;

            form2.enabled_menu();

               

        }

        private void login_clear_Click(object sender, EventArgs e)
        {
            usr_txt.Clear();
            passw_txt.Clear();
            usr_txt.Focus();
        }
    }
}
