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
    public partial class Main : Form
    {
        Point initialLocation;
        public static Form mdi;
        public Main()
        {
            InitializeComponent();
            mdi = this;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            initialLocation.X = 0;
            initialLocation.Y = 0;
            this.Location = initialLocation;

            Singleton<Tree>.Instance.MdiParent = Main.mdi;
            Application.DoEvents();
            Singleton<Tree>.Instance.Show();
            Application.DoEvents();
            Singleton<Tree>.Instance.Activate();
            Application.DoEvents();
        }



    }
}
