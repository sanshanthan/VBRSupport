using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VBRSupport
{
    public partial class CustomerHistory : Form
    {
        Point initialLocation;
        List<HistoryModel> globalHistoryList;

        private CustomerHistory()
        {
            InitializeComponent();
        }

        private void CustomerHistory_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();
            List<HistoryModel> lm = CustomerHistoryDA.GetCustomerHistory(Config.VBR4000Connection);
            BindList(lm);
            
        }

        public void BindList(List<HistoryModel> lm)
        {
            dgList.DataSource = lm;
            globalHistoryList = lm;
            dgList.Columns["Address_Line_1"].Visible = false;
            dgList.Columns["Address_Line_2"].Visible = false;
            dgList.Columns["ReceiptHeader_Line_1"].Visible = false;
            dgList.Columns["ReceiptHeader_Line_2"].Visible = false;
            dgList.Columns["ReceiptHeader_Line_3"].Visible = false;
            dgList.Columns["ReceiptHeader_Line_4"].Visible = false;
            dgList.Columns["ReceiptHeader_Line_5"].Visible = false;

            dgList.Columns["Email_Address_1"].HeaderText = "EmailID_1";
            dgList.Columns["Email_Address_1"].Width = 150;

            dgList.Columns["Email_Address_2"].HeaderText = "EmailID_2";
            dgList.Columns["Email_Address_2"].Width = 150;
            dgList.Columns["FirstDate"].Visible = false;
            dgList.Columns["Serial"].Visible = false;
            dgList.Columns["Mac"].Visible = false;

            dgList.Columns["CustomerNo"].HeaderText = "Customer No";
            dgList.Columns["CustomerNo"].Width = 100;

            dgList.Columns["ShopName"].HeaderText = "Shop Name";
            dgList.Columns["ShopName"].Width = 150;

            dgList.Columns["Telephone"].HeaderText = "Phone";
            dgList.Columns["Telephone"].Width = 120;

            dgList.Columns["Post_Code"].HeaderText = "Post Code";
            dgList.Columns["Post_Code"].Width = 100;

            dgList.Columns["IsActive"].HeaderText = "Active";
            dgList.Columns["IsActive"].Width = 80;

            dgList.Columns["SupportEndDate"].HeaderText = "Support End Date";
            dgList.Columns["SupportEndDate"].Width = 100;

            dgList.Columns["LastAcitive"].HeaderText = "Last Acitive";
            dgList.Columns["LastAcitive"].Width = 80;

            dgList.Columns["No_Of_Hosts"].HeaderText = "No Of Hosts";
            dgList.Columns["No_Of_Hosts"].Width = 50;

            dgList.Columns["Till_Id"].HeaderText = "Till Id";
            dgList.Columns["Till_Id"].Width = 50;

            dgList.Columns["TillVersion"].HeaderText = "Till Version";
            dgList.Columns["TillVersion"].Width = 50;

            dgList.Columns["BackofficeVersion"].HeaderText = "Backoffice Version";
            dgList.Columns["BackofficeVersion"].Width = 80;

            dgList.Columns["SchedulerVersion"].HeaderText = "Scheduler Version";
            dgList.Columns["SchedulerVersion"].Width = 80;

        }

        private void CustomerHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<CustomerHistory>.Instance = null;

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = TBCustomerIDSearch.Text.Trim();
            if ((!String.IsNullOrEmpty(txt))&&(txt.Length>=3))
            {
                List<HistoryModel> lm = CustomerHistoryDA.SeachCustomerHistoryByCustomerId(Config.VBR4000Connection,txt);
                BindList(lm);
            }
        }

        private void TBEmailSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = TBEmailSearch.Text.Trim();
            if ((!String.IsNullOrEmpty(txt)) && (txt.Length >= 2))
            {
                List<HistoryModel> lm = CustomerHistoryDA.SearchCustomerHistoryByEmailId(Config.VBR4000Connection, txt);
                BindList(lm);
            }
        }

        private void TBPostCodeSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = TBPostCodeSearch.Text.Trim();
            if(!String.IsNullOrEmpty(txt))
            {
                List<HistoryModel> lm = CustomerHistoryDA.SearchCustomerHistoryByPostCode(Config.VBR4000Connection, txt);
                BindList(lm);
            }
        }

        private void buEndDate_Click(object sender, EventArgs e)
        {
            List<HistoryModel> lm = CustomerHistoryDA.SearchCustomerHistoryByEndDate(Config.VBR4000Connection);
            BindList(lm);
        }

        private void buReportHistory_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<CustomerHistoryReportViewer>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<CustomerHistoryReportViewer>.Instance.Historys = globalHistoryList;
            Singleton<CustomerHistoryReportViewer>.Instance.Show();
            Application.DoEvents();
            Singleton<CustomerHistoryReportViewer>.Instance.Activate();
            Application.DoEvents();
            Singleton<CustomerHistoryReportViewer>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }


       
    }
}
