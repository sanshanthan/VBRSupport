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
    public partial class CustomerListReportViewer : Form
    {
        public CustomerListReportViewer()
        {
            InitializeComponent();
        }

        private void CustomerListReportViewer_Load(object sender, EventArgs e)
        {

            this.rvCusList.RefreshReport();
        }
    }
}
