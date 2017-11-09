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
    public partial class CustomerHistoryReportViewer : Form
    {
        Point initialLocation;
        private CustomerHistoryReportViewer()
        {
            InitializeComponent();
        }
        public List<HistoryModel> Historys { get; set; }
        private void CustomerHistoryReportViewer_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();

            this.BindingSource.DataSource = Historys;
            this.ReportViewer.RefreshReport();
        }

        private void CustomerHistoryReportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<CustomerHistoryReportViewer>.Instance = null;
        }
    }
}
