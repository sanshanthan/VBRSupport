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
    public partial class NoRespondLast30DaysReportViewer : Form
    {
        Point initialLocation;
        private NoRespondLast30DaysReportViewer()
        {
            InitializeComponent();
        }
        public List<HistoryModel> Historys { get; set; }
        private void NoRespondLast30DaysReportViewer_Load(object sender, EventArgs e)
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

        private void NoRespondLast30DaysReportViewer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<NoRespondLast30DaysReportViewer>.Instance = null;
        }

    }
}
