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
    public partial class NotAvailableCustomersReportViewer : Form
    {
        Point initialLocation;
        private NotAvailableCustomersReportViewer()
        {
            InitializeComponent();
        }
        public List<CustomerModel> Customers { get; set; }
        private void NotAvailableCustomersReportViewer_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();

            this.BindingSource.DataSource = Customers;
            this.reportViewer1.RefreshReport();
        }

        private void NotAvailableCustomersReportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<NotAvailableCustomersReportViewer>.Instance = null;
        }
    }
}
