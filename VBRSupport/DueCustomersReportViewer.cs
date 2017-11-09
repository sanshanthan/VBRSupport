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
    public partial class DueCustomersReportViewer : Form
    {
        Point initialLocation;
        private DueCustomersReportViewer()
        {
            InitializeComponent();
        }
        public List<CustomerModel> Customers { get; set; }
        private void DueCustomersReportViewer_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();

            this.CustomerModelBindingSource.DataSource = Customers;
            this.reportViewer1.RefreshReport();
        }

        private void DueCustomersReportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<DueCustomersReportViewer>.Instance = null;
        }

    }
    }