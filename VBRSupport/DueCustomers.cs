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
    public partial class DueCustomers : Form
    {
        Point initialLocation;
        List<CustomerModel> globalCustomersList;
        private DueCustomers()
        {
            InitializeComponent();
        }

        private void DueCustomers_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();
            List<CustomerModel> lm = DueCustomersDA.GetDueCustomers(Config.VBR4000Connection);
            BindList(lm);
        }

        private void BindList(List<CustomerModel> lm)
        {
            dataGridView1.DataSource = lm;
            globalCustomersList = lm;
            dataGridView1.Columns["No_"].HeaderText = "Customer No.";
            dataGridView1.Columns["No_"].Width = 150;
            dataGridView1.Columns["Name"].HeaderText = "Name";
            dataGridView1.Columns["Name"].Width = 200;
            dataGridView1.Columns["CActive"].HeaderText = "Active";
            dataGridView1.Columns["CActive"].Width = 100;

            dataGridView1.Columns["CNewsMag"].Visible = false;
            dataGridView1.Columns["CNisaProd"].Visible = false;
            dataGridView1.Columns["CBooker"].Visible = false;
            dataGridView1.Columns["CAuto"].Visible = false;

            dataGridView1.Columns["CEmail"].HeaderText = "Email";
            dataGridView1.Columns["EndDate"].HeaderText = "End Date";
            dataGridView1.Columns["EndDate"].Width = 150;

            dataGridView1.Columns["Due"].HeaderText = "Due Date";
            dataGridView1.Columns["Due"].Width = 150;

            dataGridView1.Columns["IsPaid"].HeaderText = "IsPaid";
            dataGridView1.Columns["IsPaid"].Width = 100;

        }

        private void DueCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<DueCustomers>.Instance = null;
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void TSBReport_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<DueCustomersReportViewer>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<DueCustomersReportViewer>.Instance.Customers = globalCustomersList;
            Singleton<DueCustomersReportViewer>.Instance.Show();
            Application.DoEvents();
            Singleton<DueCustomersReportViewer>.Instance.Activate();
            Application.DoEvents();
            Singleton<DueCustomersReportViewer>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }
    }
}
