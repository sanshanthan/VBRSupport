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
    public partial class NoRespondLast30Days : Form
    {
        Point initialLocation;
        List<HistoryModel> globalHistoryList;
        private NoRespondLast30Days()
        {
            InitializeComponent();
        }

        private void NoRespondLast30Days_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();

            List<HistoryModel> lm = NoRespondLast30DaysDA.NoRespondLast30Days(Config.VBR4000Connection);
            BindList(lm);
        }

        private void BindList(List<HistoryModel> lm)
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
            dgList.Columns["Email_Address_1"].Visible = false;
            dgList.Columns["Email_Address_2"].Visible = false;
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

        private void NoRespondLast30Days_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<NoRespondLast30Days>.Instance = null;
        }

        private void TSBReport_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<NoRespondLast30DaysReportViewer>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<NoRespondLast30DaysReportViewer>.Instance.Historys = globalHistoryList;
            Singleton<NoRespondLast30DaysReportViewer>.Instance.Show();
            Application.DoEvents();
            Singleton<NoRespondLast30DaysReportViewer>.Instance.Activate();
            Application.DoEvents();
            Singleton<NoRespondLast30DaysReportViewer>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }

        private void TSBDelete_Click(object sender, EventArgs e)
        {

        }



       
    }
}
