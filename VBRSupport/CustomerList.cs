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
    public partial class CustomerList : Form
    {
        Point initialLocation;
        List<CustomerModel> globalCustomersList;
        //List<VBRAsiaCusModel> CustomerList = new List<VBRAsiaCusModel>();
        private CustomerList()
        {
            InitializeComponent();
        }



        private void CustomerList_Load(object sender, EventArgs e)
        {
            this.Width = FormSize.Width(this.Tag.ToString());
            this.Height = FormSize.Heigth(this.Tag.ToString());

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
            Application.DoEvents();
            List<CustomerModel> lm = CustomerDA.GetAllCustomer(Config.VBR4000Connection);
            BindList(lm);
        }

        private void BindList(List<CustomerModel> lm)
        {
            dgListCL.DataSource = lm;
            globalCustomersList = lm;
            dgListCL.Columns["No_"].HeaderText = "Customer No.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["Name"].HeaderText = "NAME.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["CActive"].HeaderText = "CActive.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["CNewsMag"].HeaderText = "CNewsMag.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["CNisaProd"].HeaderText = "CNisaProd.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["CBooker"].HeaderText = "CBooker.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["CAuto"].HeaderText = "CAuto.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["CEmail"].HeaderText = "CEmail.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["EndDate"].HeaderText = "EndDate.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["Due"].HeaderText = "Due.";
            dgListCL.Columns["No_"].Width = 100;
            dgListCL.Columns["IsPaid"].HeaderText = "IsPaid.";
            dgListCL.Columns["No_"].Width = 100;
        }

        private void CustomerList_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<CustomerList>.Instance = null;
        }


        private void TBCustomerIDSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = TBCustomerIDSearch.Text.Trim();
            if ((!String.IsNullOrEmpty(txt)) && (txt.Length >= 3))
            {
                List<CustomerModel> lm = CustomerDA.GetCustomer(Config.VBR4000Connection, txt);
                BindList(lm);
            }
        }

        private void TBEmailSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = TBEmailSearch.Text.Trim();
            if ((!String.IsNullOrEmpty(txt)) && (txt.Length >= 3))
            {
                List<CustomerModel> lm = CustomerDA.GetCustomerByName(Config.VBR4000Connection, txt);
                BindList(lm);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            List<CustomerModel> lm = CustomerDA.GetAllCustomer(Config.VBR4000Connection);
            BindList(lm);
        }

        private void dgListCL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                string CustomerID = dgListCL["No_", rowIndex].Value.ToString();
                if (!String.IsNullOrEmpty(CustomerID))
                {
                    Application.DoEvents();
                    Singleton<CustomerCard>.Instance.MdiParent = Main.mdi;
                    Singleton<CustomerCard>.Instance.LoadDetails(CustomerID);
                    Application.DoEvents();
                    Singleton<CustomerCard>.Instance.Show();
                    Application.DoEvents();
                    Singleton<CustomerCard>.Instance.Activate();
                    Application.DoEvents();
                    Singleton<CustomerCard>.Instance.WindowState = FormWindowState.Normal;
                    Application.DoEvents();

                    /*List<VBRAsiaCusModel> lm=VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, CustomerID);
                    if(lm.Count>0)
                    {

                    }*/
                }
               /* else 
                {

                }*/


            }

        }
    }
}
