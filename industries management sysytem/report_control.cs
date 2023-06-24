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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;

namespace industries_management_sysytem
{
    public partial class report_control : UserControl
    {
        public report_control()
        {
            InitializeComponent();
        }

        SQLConfig config = new SQLConfig();
        string sql;


        private void reports(string sql, string rptname)
        {

            try
            {

                config.loadReports(sql);

                string reportname = rptname;
                


                ReportDocument reportdoc = new ReportDocument(); ;

                string strReportPath = "C:\\Users\\Dilhara\\source\\repos\\chapayev0\\industries-management-sysytem\\industries management sysytem\\report.rpt";


                reportdoc.Load(strReportPath);
                reportdoc.SetDataSource(config.dt);

                crystalReportViewer1.ReportSource = reportdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "No crystal reports installed. Pls. contact administrator.");
            }


        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnitemlisat_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM `tblitems`";
            reports(sql, "allitems");
        }

        private void btnListStockin_Click(object sender, EventArgs e)
        {

            switch (cbooption.Text)
            {

                case "Daily Report":
                    sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`,TRANSACTIONDATE FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn' AND DATE(`TRANSACTIONDATE`)=CURDATE()";
                    reports(sql, "itemlist");
                    break;

                case "Weekly Report":
                    sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`,TRANSACTIONDATE FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn' AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4";
                    reports(sql, "itemlist");
                    break;
                case "Monthly Report":
                    sql = "SELECT i.`ITEMID`, `NAME`, `DESCRIPTION`, `TYPE`, `PRICE`,so.`QTY`, `UNIT`,TRANSACTIONDATE FROM `tblitems` i ,`tblstock_in_out` so WHERE  i.`ITEMID`=so.`ITEMID` AND `REMARKS`='StockIn' AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())";
                    reports(sql, "itemlist");
                    break;

            }
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            switch (cbooption.Text)
            {
                case "Daily Report":
                    sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " +
                        " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" +
                        " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND DATE(`TRANSACTIONDATE`)=CURDATE()";
                    reports(sql, "soldList");
                    break;

                case "Weekly Report":
                    sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " +
                        " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" +
                        " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND WEEKDAY(`TRANSACTIONDATE`) >=0 AND WEEKDAY(`TRANSACTIONDATE`) <=4";
                    reports(sql, "soldList");
                    break;
                case "Monthly Report":
                    sql = "SELECT  `TRANSACTIONNUMBER` , concat(`FIRSTNAME`,' ', `LASTNAME`) as 'Customer',    `NAME` AS  'Item', io.`QTY` ,  `TOTALPRICE` ,  `TRANSACTIONDATE` " +
                        " FROM  `tblitems` i,  `tblstock_in_out` io,`tblperson` p" +
                        " WHERE i.`ITEMID` = io.`ITEMID` AND io.`SUPLIERCUSTOMERID`=p.`SUPLIERCUSTOMERID` AND REMARKS ='StockOut' AND MONTH(`TRANSACTIONDATE`)=MONTH(CURDATE())";
                    reports(sql, "soldList");
                    break;
            }
        }

        private void btnStockReturn_Click(object sender, EventArgs e)
        {
            switch (cbooption.Text)
            {
                case "Daily Report":
                    sql = "SELECT `STOCKRETURNNUMBER`,`NAME` AS 'Item', `RETURNDATE`, r.`QTY` as 'Quantity' FROM `tblstock_return` r,`tblitems` i WHERE r.`ITEMID`=i.`ITEMID` AND DATE(`RETURNDATE`)=CURDATE()";
                    reports(sql, "returnList");
                    break;
                case "Weekly Report":
                    sql = "SELECT `STOCKRETURNNUMBER`,`NAME` AS 'Item', `RETURNDATE`, r.`QTY` as 'Quantity' FROM `tblstock_return` r,`tblitems` i WHERE r.`ITEMID`=i.`ITEMID` AND WEEKDAY(`RETURNDATE`) >=0 AND WEEKDAY(`RETURNDATE`) <=4";
                    reports(sql, "returnList");
                    break;
                case "Monthly Report":
                    sql = "SELECT `STOCKRETURNNUMBER`,`NAME` AS 'Item', `RETURNDATE`, r.`QTY` as 'Quantity' FROM `tblstock_return` r,`tblitems` i WHERE r.`ITEMID`=i.`ITEMID` AND MONTH(`RETURNDATE`)=MONTH(CURDATE())";
                    reports(sql, "returnList");
                    break;
            }
        }
    }
}
