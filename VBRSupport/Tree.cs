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
    public partial class Tree : Form
    {
        Point initialLocation;
        private Tree()
        {
            InitializeComponent();
        }

        private void Tree_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            initialLocation.X = 0;
            initialLocation.Y = 0;
            this.Location = initialLocation;
        }

        private void buClose_Click(object sender, EventArgs e)
        {
            Main.mdi.Close();
        }

        private void buMinimize_Click(object sender, EventArgs e)
        {
            Main.mdi.WindowState = FormWindowState.Minimized;
        }

        private void buNotAvailableNow_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<Not_AvailableCustomers>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<Not_AvailableCustomers>.Instance.Show();
            Application.DoEvents();
            Singleton<Not_AvailableCustomers>.Instance.Activate();
            Application.DoEvents();
            Singleton<Not_AvailableCustomers>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<NoRespondLast30Days>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<NoRespondLast30Days>.Instance.Show();
            Application.DoEvents();
            Singleton<NoRespondLast30Days>.Instance.Activate();
            Application.DoEvents();
            Singleton<NoRespondLast30Days>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<DueCustomers>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<DueCustomers>.Instance.Show();
            Application.DoEvents();
            Singleton<DueCustomers>.Instance.Activate();
            Application.DoEvents();
            Singleton<DueCustomers>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<CustomerCard>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<CustomerCard>.Instance.Show();
            Application.DoEvents();
            Singleton<CustomerCard>.Instance.Activate();
            Application.DoEvents();
            Singleton<CustomerCard>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<CustomerList>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<CustomerList>.Instance.Show();
            Application.DoEvents();
            Singleton<CustomerList>.Instance.Activate();
            Application.DoEvents();
            Singleton<CustomerList>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }

        private void buCusHistory_Click(object sender, EventArgs e)
        {
            Application.DoEvents();
            Singleton<CustomerHistory>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<CustomerHistory>.Instance.Show();
            Application.DoEvents();
            Singleton<CustomerHistory>.Instance.Activate();
            Application.DoEvents();
            Singleton<CustomerHistory>.Instance.WindowState = FormWindowState.Normal;
            Application.DoEvents();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


    }
}
