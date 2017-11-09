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
    public partial class Not_AvailableCustomers : Form
    {
        Point initialLocation;
        List<CustomerModel> globalCustomersList;
        private Not_AvailableCustomers()
        {
            InitializeComponent();
        }
        
        private void Not_AvailableCustomers_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();
            List<CustomerModel> lm = NotAvailableCustomersDA.GetNotAvailableCustomers(Config.VBR4000Connection);
            BindList(lm);
        }

        private void BindList(List<CustomerModel> lm)
        {
            dgList.DataSource = lm;
            globalCustomersList = lm;
            dgList.Columns["No_"].HeaderText = "Customer No.";
            dgList.Columns["No_"].Width = 150;

            dgList.Columns["Name"].Width = 200;

            dgList.Columns["CActive"].HeaderText = "Active";
            dgList.Columns["CActive"].Width = 100;

            dgList.Columns["CNewsMag"].Visible = false;
            dgList.Columns["CNisaProd"].Visible = false;
            dgList.Columns["CBooker"].Visible = false;
            dgList.Columns["CAuto"].Visible = false;

            dgList.Columns["CEmail"].HeaderText ="Email";
            dgList.Columns["EndDate"].HeaderText = "End Date";
            dgList.Columns["EndDate"].Width = 150;

            dgList.Columns["Due"].HeaderText = "Due Date";
            dgList.Columns["Due"].Width = 150;

            dgList.Columns["IsPaid"].Width = 100;

        }

        private void Not_AvailableCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<Not_AvailableCustomers>.Instance = null;
        }

        private void TSBReport_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<NotAvailableCustomersReportViewer>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<NotAvailableCustomersReportViewer>.Instance.Customers = globalCustomersList;
            Singleton<NotAvailableCustomersReportViewer>.Instance.Show();
            Application.DoEvents();
            Singleton<NotAvailableCustomersReportViewer>.Instance.Activate();
            Application.DoEvents();
            Singleton<NotAvailableCustomersReportViewer>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }


    }
}
