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
    public partial class CustomerCard : Form
    {
        List<SupportDetailsModel> supportDetailsList = new List<SupportDetailsModel>();
        Point initialLocation;
        int NoOfPayments = 0;
        int CurrentIndex = 0;
        List<PaymentsModel> paymentsList = new List<PaymentsModel>();
        List<PaymentInstallmentModel> paymentInstallmentList = new List<PaymentInstallmentModel>();
        List<JobCardHardwareModel> hardwareDetailsList = new List<JobCardHardwareModel>();
        private CustomerCard()
        {
            InitializeComponent();
        }
        //SUPPORT DETAILS FillModel
        private SupportDetailsModel SupportFillModel()
        {
            SupportDetailsModel m = new SupportDetailsModel();
            m.CutomerNo = txtCustomer_No.Text.Trim();
            m.ContactNo = txtTelephone1.Text.Trim();
            m.Name = txtNamee.Text.Trim();
            m.ShopName = txtShopNameS.Text.Trim();
            m.SupportBy = cbSupportByS.Text.Trim();
            m.SupportDetail = txtSupportDetailS.Text.Trim();
            m.Suggestions = txtSuggestionsS.Text.Trim();
            m.Notes = txtNotesS.Text.Trim();
            m.SupportDate = dtpSupportDateS.Value;
            return (m);
        }
        //SUPPORT VALIDATION
        private bool IsSupportValidData()
        {
            bool result = true;
            #region CutomerNo
            if (String.IsNullOrEmpty(txtCustomer_No.Text.Trim()))
            {
                result = false;
                txtCustomer_No.BackColor = Color.Red;
            }
            else
            {
                txtCustomer_No.BackColor = Color.White;
            }
            #endregion  CutomerNo
            #region ContactNo
            if (String.IsNullOrEmpty(txtTelephone1.Text.Trim()))
            {
                result = false;
                txtTelephone1.BackColor = Color.Red;
            }
            else
            {
                txtTelephone1.BackColor = Color.White;
            }
            #endregion  ContactNo
            #region Name
            if (String.IsNullOrEmpty(txtNamee.Text.Trim()))
            {
                result = false;
                txtNamee.BackColor = Color.Red;
            }
            else
            {
                txtNamee.BackColor = Color.White;
            }
            #endregion  Name
            #region ShopName
            if (String.IsNullOrEmpty(txtShopNameS.Text.Trim()))
            {
                result = false;
                txtShopNameS.BackColor = Color.Red;
            }
            else
            {
                txtShopNameS.BackColor = Color.White;
            }
            #endregion  ShopName
            #region SupportBy
            if (String.IsNullOrEmpty(cbSupportByS.Text.Trim()))
            {
                result = false;
                cbSupportByS.BackColor = Color.Red;
            }
            else
            {
                cbSupportByS.BackColor = Color.White;
            }
            #endregion  SupportBy
            #region SupportDetail
            if (String.IsNullOrEmpty(txtSupportDetailS.Text.Trim()))
            {
                result = false;
                txtSupportDetailS.BackColor = Color.Red;
            }
            else
            {
                txtSupportDetailS.BackColor = Color.White;
            }
            #endregion  SupportDetail
            #region SupportDate
            if (String.IsNullOrEmpty(dtpSupportDateS.Text.Trim()))
            {
                result = false;
                dtpSupportDateS.BackColor = Color.Red;
            }
            else
            {
                dtpSupportDateS.BackColor = Color.White;
            }
            #endregion  SupportDate
            return result;
        }

        /*private bool IsValidHardwareData()
        {
            bool result = true;
            #region cmbUnit
            if (String.IsNullOrEmpty(cmbUnit.Text.Trim()))
            {
                result = false;
                cmbUnit.BackColor = Color.Red;
            }
            else
            {
                cmbUnit.BackColor = Color.White;
            }
            #endregion  cmbUnit
            #region cmbCashDrawer
            if (String.IsNullOrEmpty(cmbCashDrawer.Text.Trim()))
            {
                result = false;
                cmbCashDrawer.BackColor = Color.Red;
            }
            else
            {
                cmbCashDrawer.BackColor = Color.White;
            }
            #endregion  cmbCashDrawer
        }*/

        // Payment ValidDate
        private bool IsValidPaymentData()
        {
            bool result = true;
            #region JobDetails
            if (string.IsNullOrEmpty(txtJobDetails.Text.Trim()))
            {
                result = false;
                txtJobDetails.BackColor = Color.Red;
            }
            else
            {
                txtJobDetails.BackColor = Color.White;
            }

            #endregion JobDetails
            #region Amount
            if (string.IsNullOrEmpty(txtAmount.Text.Trim()))
            {
                result = false;
                txtAmount.BackColor = Color.Red;
            }
            else
            {
                txtAmount.BackColor = Color.White;
            }

            #endregion Amount
            #region Vat
            if (string.IsNullOrEmpty(txtVat.Text.Trim()))
            {
                result = false;
                txtVat.BackColor = Color.Red;
            }
            else
            {
                txtVat.BackColor = Color.White;
            }

            #endregion Vat
            #region ExtraCharge
            if (String.IsNullOrEmpty(txtExtraCharge.Text.Trim()))
            {
                result = false;
                txtExtraCharge.BackColor = Color.Red;
            }
            else
            {
                txtExtraCharge.BackColor = Color.White;
            }

            #endregion ExtraCharge
            #region Discounts
            if (String.IsNullOrEmpty(txtDiscounts.Text.Trim()))
            {
                result = false;
                txtDiscounts.BackColor = Color.Red;
            }
            else
            {
                txtDiscounts.BackColor = Color.White;
            }
            #endregion Discounts
            #region GrandTotal
            if (String.IsNullOrEmpty(txtGrandTotal.Text.Trim()))
            {
                result = false;
                txtGrandTotal.BackColor = Color.Red;
            }
            else
            {
                txtGrandTotal.BackColor = Color.White;
            }
            #endregion GrandTotal
            #region InitailAmount
            if (String.IsNullOrEmpty(txtInitailAmount.Text.Trim()))
            {
                result = false;
                txtInitailAmount.BackColor = Color.Red;
            }
            else
            {
                txtInitailAmount.BackColor = Color.White;
            }
            #endregion InitailAmount
            #region OutStanding
            if (String.IsNullOrEmpty(txtOutStanding.Text.Trim()))
            {
                result = false;
                txtOutStanding.BackColor = Color.Red;
            }
            else
            {
                txtOutStanding.BackColor = Color.White;
            }
            #endregion OutStanding
            //InstallmentMethod
            #region PayAmount
            if (String.IsNullOrEmpty(txtPayAmount.Text.Trim()))
            {
                result = false;
                txtPayAmount.BackColor = Color.Red;
            }
            else
            {
                txtPayAmount.BackColor = Color.White;
            }
            #endregion PayAmount
            #region PayType
            if (String.IsNullOrEmpty(cbPayType.Text.Trim()))
            {
                result = false;
                cbPayType.BackColor = Color.Red;
            }
            else
            {
                cbPayType.BackColor = Color.White;
            }
            #endregion PayType
            #region CollectedBy
            if (String.IsNullOrEmpty(cbCollectedBy.Text.Trim()))
            {
                result = false;
                cbCollectedBy.BackColor = Color.Red;
            }
            else
            {
                cbCollectedBy.BackColor = Color.White;
            }
            #endregion CollectedBy
            return result;
        }

        private bool IsValidHardwareData()
        {
            bool result = true;
            #region Unit
            if (string.IsNullOrEmpty(cmbUnit.Text.Trim()))
            {
                result = false;
                cmbUnit.BackColor = Color.Red;
            }
            else
            {
                cmbUnit.BackColor = Color.White;
            }

            #endregion Unit
            #region CashDrawer
            if (string.IsNullOrEmpty(cmbCashDrawer.Text.Trim()))
            {
                result = false;
                cmbCashDrawer.BackColor = Color.Red;
            }
            else
            {
                cmbCashDrawer.BackColor = Color.White;
            }

            #endregion CashDrawer
            #region TPrinter
            if (string.IsNullOrEmpty(cmbTPrinter.Text.Trim()))
            {
                result = false;
                cmbTPrinter.BackColor = Color.Red;
            }
            else
            {
                cmbTPrinter.BackColor = Color.White;
            }

            #endregion TPrinter
            #region Scanner
            if (string.IsNullOrEmpty(cmbScanner.Text.Trim()))
            {
                result = false;
                cmbScanner.BackColor = Color.Red;
            }
            else
            {
                cmbScanner.BackColor = Color.White;
            }

            #endregion Scanner
            #region LPrinter
            if (string.IsNullOrEmpty(cmbLPrinter.Text.Trim()))
            {
                result = false;
                cmbLPrinter.BackColor = Color.Red;
            }
            else
            {
                cmbLPrinter.BackColor = Color.White;
            }

            #endregion LPrinter

            return result;
        }

        private bool IsValidSoftwareData()
        {
            bool result = true;
            //Software Details
            #region Epos
            if (string.IsNullOrEmpty(cmbEpos.Text.Trim()))
            {
                result = false;
                cmbEpos.BackColor = Color.Red;
            }
            else
            {
                cmbEpos.BackColor = Color.White;
            }

            #endregion Epos
            #region Backoffice
            if (string.IsNullOrEmpty(cmbBackoffice.Text.Trim()))
            {
                result = false;
                cmbBackoffice.BackColor = Color.Red;
            }
            else
            {
                cmbBackoffice.BackColor = Color.White;
            }

            #endregion Backoffice
            #region RemoteApp
            if (string.IsNullOrEmpty(txtRemoteApp.Text.Trim()))
            {
                result = false;
                txtRemoteApp.BackColor = Color.Red;
            }
            else
            {
                txtRemoteApp.BackColor = Color.White;
            }

            #endregion RemoteApp
            #region MenuCreate
            if (string.IsNullOrEmpty(cmbMenuCreate.Text.Trim()))
            {
                result = false;
                cmbMenuCreate.BackColor = Color.Red;
            }
            else
            {
                cmbMenuCreate.BackColor = Color.White;
            }

            #endregion MenuCreate
            #region vendorLink
            if (string.IsNullOrEmpty(cmbvendorLink.Text.Trim()))
            {
                result = false;
                cmbvendorLink.BackColor = Color.Red;
            }
            else
            {
                cmbvendorLink.BackColor = Color.White;
            }

            #endregion vendorLink
            return result;
        }



        public void LoadDetails(string customerId)
        {
            txtCustomer_No.Text = customerId;
            List<VBRAsiaCusModel> lm = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, customerId);
            if (lm.Count > 0)
            {
                FillForm(lm[0]);
            }
            else
            {
                List<CustomerModel> lm1 = CustomerDA.GetCustomerById(Config.VBR4000Connection, customerId);
                if (lm1.Count > 0)
                {
                    FillForm(lm1[0]);
                }
            }
        }
        //FOR ENTER BUTTON
        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnFind.PerformClick();
        }

        private bool IsValidData()
        {
            bool result = true;
            #region Customer_No
            if (String.IsNullOrEmpty(txtCustomer_No.Text.Trim()))
            {
                result = false;
                txtCustomer_No.BackColor = Color.Red;
            }
            else
            {
                txtCustomer_No.BackColor = Color.White;
            }
            #endregion  Customer_No
            #region Name
            if (String.IsNullOrEmpty(txtNamee.Text.Trim()))
            {
                result = false;
                txtNamee.BackColor = Color.Red;
            }
            else
            {
                txtNamee.BackColor = Color.White;
            }
            #endregion  Name
            #region Street
            if (String.IsNullOrEmpty(txtStreet.Text.Trim()))
            {
                result = false;
                txtStreet.BackColor = Color.Red;
            }
            else
            {
                txtStreet.BackColor = Color.White;
            }
            #endregion  Street
            #region Post_Code
            if (String.IsNullOrEmpty(txtPost_Code.Text.Trim()))
            {
                result = false;
                txtPost_Code.BackColor = Color.Red;
            }
            else
            {
                txtPost_Code.BackColor = Color.White;
            }
            #endregion  Post_Code
            #region Telephone1
            if (String.IsNullOrEmpty(txtTelephone1.Text.Trim()))
            {
                result = false;
                txtTelephone1.BackColor = Color.Red;
            }
            else
            {
                txtTelephone1.BackColor = Color.White;
            }
            #endregion  Telephone1
            #region No_Of_Shops
            try
            {
                int noOfShops = Convert.ToInt32(txtNo_Of_Shops.Text);
                if (noOfShops > 0)
                {
                    txtNo_Of_Shops.BackColor = Color.White;
                }
                else
                {
                    txtNo_Of_Shops.BackColor = Color.Red;
                    result = false;
                }
            }
            catch
            {
                txtNo_Of_Shops.BackColor = Color.Red;
                result = false;
            }
            #endregion No_Of_Shops
            return result;
        }
        private void CustomerCard_Load(object sender, EventArgs e)
        {

            int IFW = FormSize.Width(Singleton<Tree>.Instance.Tag.ToString());
            initialLocation.X = IFW;
            initialLocation.Y = 0;
            this.Location = initialLocation;
           // dtpSupport_End_Date.Value = Convert.ToDateTime("1990-01-01");
            //dtpDue_Date.Value = Convert.ToDateTime("1990-01-01");
            //dtpAdded_Date.Value = Convert.ToDateTime("1990-01-01");
            /****************/
        }

        private void BindSupportDetailsList(List<SupportDetailsModel> lm)
        {
            dgSupportDetails.DataSource = lm;
            supportDetailsList = lm;
            dgSupportDetails.Columns["CutomerNo"].Visible = false;
            dgSupportDetails.Columns["Name"].Visible = false;
            dgSupportDetails.Columns["ContactNo"].Visible = false;
            dgSupportDetails.Columns["Suggestions"].Visible = false;
            dgSupportDetails.Columns["Notes"].Visible = false;

            dgSupportDetails.Columns["Id"].Width = 50;
            dgSupportDetails.Columns["ShopName"].Width = 150;
            dgSupportDetails.Columns["SupportDate"].Width = 120;

        }


        private void BindPaymentInstallmentList(List<PaymentInstallmentModel> lm)
        {
            dgPaymentInstallment.DataSource = lm;
            paymentInstallmentList = lm;
            dgPaymentInstallment.Columns["Customer_No"].Visible = false;
            dgPaymentInstallment.Columns["ID"].Width = 40;
            dgPaymentInstallment.Columns["JobId"].Width =40;
            dgPaymentInstallment.Columns["PayAmount"].Width = 80;
            dgPaymentInstallment.Columns["PayAmount"].DefaultCellStyle.Format = "0.00##";
            dgPaymentInstallment.Columns["PayDate"].Width = 100;
            dgPaymentInstallment.Columns["PayType"].Width = 80;
            dgPaymentInstallment.Columns["CollectedBy"].Width = 80;

        }
        //FillHardwareSoftware
        private void FillHardwareSoftwareCard()
        {
            throw new NotImplementedException();
        }
        //FillPayment HeaderCard
        private void FillPaymentHeaderCard()
        {
            laJobID.Text = "";
            if ((NoOfPayments > 0) && (CurrentIndex >= 0) && (CurrentIndex < NoOfPayments))
            {
                PaymentsModel m = paymentsList[CurrentIndex];
                txtCustomer_No.Text = m.Customer_No;
                txtJobDetails.Text = m.JobDetails;
                txtAmount.Text = String.Format("{0:0.00}", m.Amount);
                txtVat.Text = String.Format("{0:0.00}", m.Vat);
                txtExtraCharge.Text = String.Format("{0:0.00}", m.ExtraCharge);
                txtEChargeDetails.Text = m.ExtraChargeDetails;
                txtDiscounts.Text = String.Format("{0:0.00}", m.Discounts);
                txtGrandTotal.Text = String.Format("{0:0.00}", m.GrandTotal);
                txtInitailAmount.Text = String.Format("{0:0.00}", m.InitailAmount);
                txtOutStanding.Text = String.Format("{0:0.00}", m.OutStanding);
                laJobID.Text = m.JobID.ToString();
                cbPaid.Checked = m.IsPaid;

            }

        }

        // Payment Details FillModel 
        private PaymentsModel PaymentFillModel()
        {
            PaymentsModel m = new PaymentsModel();
            m.Customer_No = txtCustomer_No.Text.Trim();
            m.JobDetails = txtJobDetails.Text.Trim();
            m.Amount = Convert.ToDecimal(txtAmount.Text.Trim());
            m.Vat = Convert.ToDecimal(txtVat.Text.Trim());
            m.ExtraCharge = Convert.ToDecimal(txtExtraCharge.Text.Trim());
            m.ExtraChargeDetails = txtEChargeDetails.Text.Trim();
            m.Discounts = Convert.ToDecimal(txtDiscounts.Text.Trim());
            m.GrandTotal = Convert.ToDecimal(txtGrandTotal.Text.Trim());
            m.InitailAmount = Convert.ToDecimal(txtInitailAmount.Text.Trim());
            m.OutStanding = Convert.ToDecimal(txtOutStanding.Text.Trim());
            m.IsPaid = cbPaid.Checked;
            return m;
        }

        //Payment Installment FillModel
        private PaymentInstallmentModel PaymentInstallmentFillModel()
        {
            PaymentInstallmentModel m = new PaymentInstallmentModel();
            m.JobId = Convert.ToInt32(laJobID.Text);
            m.Customer_No = txtCustomer_No.Text.Trim();
            
            m.PayAmount = Convert.ToDecimal(txtPayAmount.Text.Trim());
            m.PayDate = dateTimePayDate.Value;
            m.PayType = cbPayType.Text.Trim();
            m.CollectedBy = cbCollectedBy.Text.Trim();
            return m;
        }
        // Fill JobCardHardwareForm Card

        private void FillHardwareFormCard()
        {
            laJobID.Text = "";
            JobCardHardwareModel m = new JobCardHardwareModel();
            cmbUnit.Text = m.Unit;
            cmbCashDrawer.Text = m.CashDrawer;
            cmbTPrinter.Text = m.ThermalPrinter;
            cmbScanner.Text = m.Scanner;
            cbCustomerDisplay.Checked = m.CustomerDisplay;
            cmbLPrinter.Text = m.LaserPrinter;
            cbBO_Computer.Checked = m.BackOffice_Computer;
            cbBO_Scanner.Checked = m.BackOffice_Scanner;
            cbDualDisplay.Checked = m.DualDisplay;
            cbScaler.Checked = m.Scaler;
            cbCardReciver.Checked = m.CardReciver;
            cbCamerBoxLink.Checked = m.CameraBoxLink;
            cbPiccolinkSet.Checked = m.PiccolinkSet;
            cbKitchenPrinter.Checked = m.KitchenPrinter;
            cbHardDisk.Checked = m.HardDisk;
            cbNetworkCable.Checked = m.NetworkCable;
        }

        // FillModel JobCardHardwareDetails 
        private JobCardHardwareModel JobCardHardwareFillModel()
        {
            JobCardHardwareModel m = new JobCardHardwareModel();
            m.JobId = Convert.ToInt32(laJobID.Text);
            m.Customer_No = txtCustomer_No.Text.Trim();
            m.Unit = cmbUnit.Text.Trim();
            m.CashDrawer = cmbCashDrawer.Text.Trim();
            m.ThermalPrinter = cmbTPrinter.Text.Trim();
            m.Scanner = cmbScanner.Text.Trim();
            m.CustomerDisplay = cbCustomerDisplay.Checked;
            m.LaserPrinter = cmbLPrinter.Text.Trim();
            m.BackOffice_Computer = cbBO_Computer.Checked;
            m.BackOffice_Scanner = cbBO_Scanner.Checked;
            m.DualDisplay = cbDualDisplay.Checked;
            m.Scaler = cbScaler.Checked;
            m.CardReciver = cbCardReciver.Checked;
            m.CameraBoxLink = cbCamerBoxLink.Checked;
            m.PiccolinkSet = cbPiccolinkSet.Checked;
            m.KitchenPrinter = cbKitchenPrinter.Checked;
            m.HardDisk = cbHardDisk.Checked;
            m.NetworkCable = cbNetworkCable.Checked;
            return m;

        }

        private VBRAsiaCusModel FillModel()
        {
            VBRAsiaCusModel m = new VBRAsiaCusModel();
            m.Customer_No = txtCustomer_No.Text.Trim();
            m.Name = txtNamee.Text.Trim();
            m.Street = txtStreet.Text.Trim();
            m.Post_Code = txtPost_Code.Text.Trim();
            m.Telephone1 = txtTelephone1.Text.Trim();
            m.Telephone2 = txtTelephone2.Text.Trim();
            m.Address_1 = txtAddress_1.Text.Trim();
            m.Address_2 = txtAddress_2.Text.Trim();
            m.E_Mail = txtE_Mail.Text.Trim();
            m.No_Of_Shops = Convert.ToInt32(txtNo_Of_Shops.Text.Trim());
            m.Support_End_Date = dtpSupport_End_Date.Value;
            m.Due_Date = dtpDue_Date.Value;
            m.Added_Date = dtpAdded_Date.Value;
            m.IsPaid = cbIsPaid.Checked;
            return m;
        }

        private void FillForm(CustomerModel m)
        {
            #region CustomerForm
            txtCustomer_No.Text = m.No_;
            txtNamee.Text = m.Name;
            //txtE_Mail. = m.CEmail;
            dtpSupport_End_Date.Value = m.EndDate;
            dtpDue_Date.Value = m.Due;
            cbIsPaid.Checked = m.IsPaid;
            #endregion CustomerForm
        }

        private void FillForm(VBRAsiaCusModel m)
        {
            #region CustomerForm
            txtCustomer_No.Text = m.Customer_No;
            txtNamee.Text = m.Name;
            txtStreet.Text = m.Street;
            txtPost_Code.Text = m.Post_Code;
            txtTelephone1.Text = m.Telephone1;
            txtTelephone2.Text = m.Telephone2;
            txtAddress_1.Text = m.Address_1;
            txtAddress_2.Text = m.Address_2;
            txtE_Mail.Text = m.E_Mail;
            txtNo_Of_Shops.Text = m.No_Of_Shops.ToString();
            dtpSupport_End_Date.Value = m.Support_End_Date;
            dtpDue_Date.Value = m.Due_Date;
            dtpAdded_Date.Value = m.Added_Date;
            cbIsPaid.Checked = m.IsPaid;
            tbInvoiceTotal.Text = m.InvoiceTotal.ToString();
            tbTotalPaid.Text = m.TotalPaid.ToString();
            #endregion CustomerForm

            #region SupportDetail
            List<SupportDetailsModel> lsm = SupportDetailsDA.GetSupportDetail(Config.VBR4000Connection, m.Customer_No);
            BindSupportDetailsList(lsm);
            #endregion SupportDetail

            #region PaymentDetails
            List<PaymentsModel> lm = PaymentDetailsDA.GetPaymentDetails(Config.VBR4000Connection, m.Customer_No);
            NoOfPayments = lm.Count;
            paymentsList = lm;
            CurrentIndex = 0;
            FillPaymentHeaderCard();
            #endregion PaymentDetails

            #region PaymentInstallment
            List<PaymentInstallmentModel> plm = PaymentInstallmentDA.GetPaymentInstallmentDetails(Config.VBR4000Connection, m.Customer_No);
            BindPaymentInstallmentList(plm);
            #endregion PaymentInstallment

            #region HarwdareDetails
            List<JobCardHardwareModel> hlm = JobCardHardwareDA.GetHardwareDetails(Config.VBR4000Connection, m.Customer_No);
            FillHardwareFormCard();
            #endregion HardwareDetails

        }



        private void CustomerCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton<CustomerCard>.Instance = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                VBRAsiaCusModel m = FillModel();
                int i = VBRAsia_CustomersDA.UpdateVBRAsiaCustomer(Config.VBR4000Connection, m);
                if (i == 0)
                {
                    i = VBRAsia_CustomersDA.InsertVBRAsiaCustomer(Config.VBR4000Connection, m);
                    if (i == 1) MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("UPDATED");
                }
            }
        }

        //TO CLEAR ALL TEXT BOX FIELDS
        void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        //TO CLEAR ALL TEXT BOX COLOURS
        void ClearAllTextColor(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).BackColor = Color.White;
                else
                    ClearAllTextColor(c);
            }
        }

        //TO CLEAR ALL COMBOBOX FIELDS
        void ClearAllCompText(Control con)
        {
            foreach (Control d in con.Controls)
            {
                if (d is ComboBox)
                    ((ComboBox)d).Items.Clear();
                else
                    ClearAllCompText(d);
            }
        }
        //TO CLEAR ALL COMBOBOX COLOURS
        void ClearAllCompColor(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is ComboBox)
                    ((ComboBox)c).BackColor = Color.White;
                else
                    ClearAllCompColor(c);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            ClearAllTextColor(this);
            ClearAllCompText(this);
            ClearAllCompColor(this);
            List<SupportDetailsModel> lm = new List<SupportDetailsModel>();
            BindSupportDetailsList(lm);
            cbSupportByS.Text = String.Empty;
            cbSupportByS.BackColor = Color.White;
        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            string customerNo = txtCustomer_No.Text.Trim();
            if (!String.IsNullOrEmpty(customerNo))
            {
                List<VBRAsiaCusModel> lm = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, customerNo);
                if (lm.Count > 0)
                {
                    FillForm(lm[0]);
                }
            }
}

        //SUPPORT BUTTON---SUPPORT BUTTON---SUPPORT BUTTON---SUPPORT BUTTON---SUPPORT BUTTON
        private void btnSaveSupport_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                VBRAsiaCusModel c = FillModel();
                List<VBRAsiaCusModel> lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, c.Customer_No);
                if (lc.Count > 0)
                {
                    if (IsSupportValidData())
                    {
                        SupportDetailsModel m = SupportFillModel();
                        int i = SupportDetailsDA.UpdateSupportDetail(Config.VBR4000Connection, m);
                        i = SupportDetailsDA.InsertSupportDetails(Config.VBR4000Connection, m);
                        if (i == 1) 
                        { 
                            MessageBox.Show("Saved");
                             lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, m.CutomerNo);
                            if (lc.Count > 0)
                            {
                                FillForm(lc[0]);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please save the customer");
                }
            }
        }

        private void dgSupportDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                string SupportDetailsId = dgSupportDetails["Id", rowIndex].Value.ToString();
                int Id = Convert.ToInt32(SupportDetailsId);
                SupportDetailsModel m = new SupportDetailsModel();
                for(int i=0;i<supportDetailsList.Count;i++)
                {
                    if (Id == supportDetailsList[i].Id)
                    {
                        m = supportDetailsList[i];
                    }
                }
                txtSupportDetail.Text = m.SupportDetail;
                txtSuggestions.Text = m.Suggestions;
                txtNotes.Text = m.Notes;
            }
        }

        private void txtCustomer_No_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string customerNo = txtCustomer_No.Text.Trim();
                if (!String.IsNullOrEmpty(customerNo))
                {
                    List<VBRAsiaCusModel> lm = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, customerNo);
                    if (lm.Count > 0)
                    {
                        FillForm(lm[0]);
                    }  
                }
            }
        }

// START PAYMNET TAB CONTROLS 

        // PAYMNET NEW BUTTON 
        private void buPaymentNew_Click_1(object sender, EventArgs e)
        {
            #region PAYMNET NEW BUTTON
            List<PaymentsModel> lm = new List<PaymentsModel>();
            FillPaymentHeaderCard();
            txtJobDetails.Text = string.Empty;
            txtJobDetails.BackColor = Color.White;

            txtAmount.Text = string.Empty;
            txtAmount.BackColor = Color.White;

            txtVat.Text = string.Empty;
            txtVat.BackColor = Color.White;

            txtDiscounts.Text = string.Empty;
            txtDiscounts.BackColor = Color.White;

            txtExtraCharge.Text = string.Empty;
            txtExtraCharge.BackColor = Color.White;

            txtGrandTotal.Text = string.Empty;
            txtGrandTotal.BackColor = Color.White;

            txtInitailAmount.Text = string.Empty;
            txtInitailAmount.BackColor = Color.White;

            txtOutStanding.Text = string.Empty;
            txtOutStanding.BackColor = Color.White;

            #endregion PAYMNET NEW BUTTON
        }

        // PAYMENT SAVE BUTTON  // PAYMENT SAVE BUTTON 
        private void buPaymentSave_Click_1(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                VBRAsiaCusModel c = FillModel();
                List<VBRAsiaCusModel> lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, c.Customer_No);
                if (lc.Count > 0)
                {
                    if (IsValidPaymentData())
                    {
                        PaymentsModel m = PaymentFillModel();
                        int i = PaymentDetailsDA.UpdatePaymentDetails(Config.VBR4000Connection, m);
                        i = PaymentDetailsDA.InsertPaymentDetails(Config.VBR4000Connection, m);
                        if (i == 1)
                        {
                            MessageBox.Show("Saved");
                            lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, m.Customer_No);
                            if (lc.Count > 0)
                            {
                                FillForm(lc[0]);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please First save the customer");
            }
        }

        private void buNext_Click_1(object sender, EventArgs e)
        {
            if (CurrentIndex < (NoOfPayments - 1))
            {
                CurrentIndex++;
                FillPaymentHeaderCard();
            }
        }

        private void buPrev_Click_1(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                FillPaymentHeaderCard();
            }
        }
        
        // PAYMNET INSTALLEMENT SAVE BUTTON 
        private void buInstallmentSave_Click_1(object sender, EventArgs e)
        {
            if (IsValidPaymentData())
            {
                VBRAsiaCusModel c = FillModel();
                List<VBRAsiaCusModel> lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, c.Customer_No);
                if (lc.Count > 0)
                {
                    int jobid;
                    if (int.TryParse(laJobID.Text, out jobid))
                    {
                        PaymentInstallmentModel m = PaymentInstallmentFillModel();
                        int i = PaymentInstallmentDA.InsertPaymentInstallment(Config.VBR4000Connection, m);

                        if (i == 1) MessageBox.Show("Saved");
                        {

                            lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, m.Customer_No);
                            if (lc.Count > 0)
                            {
                                FillForm(lc[0]);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO PAYMENT HEADER");
                    }
                }
                else
                {
                    MessageBox.Show("Please First save the customer");
                }
            }
        }
// END PAYMNET TAB CONTROLS 


        private void buHardwareSave_Click(object sender, EventArgs e)
        {
            if (IsValidHardwareData())
            {
                VBRAsiaCusModel c = FillModel();
                List<VBRAsiaCusModel> lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, c.Customer_No);
                if (lc.Count > 0)
                {
                    int jobid;
                    if (int.TryParse(laJobID.Text, out jobid))
                    {
                        JobCardHardwareModel m = JobCardHardwareFillModel();
                        int i = JobCardHardwareDA.InsertHardwareDetails(Config.VBR4000Connection, m);

                        if (i == 1) MessageBox.Show("Saved");
                        {

                            lc = VBRAsia_CustomersDA.GetVBRAsiaCustomer(Config.VBR4000Connection, m.Customer_No);
                            if (lc.Count > 0)
                            {
                                FillForm(lc[0]);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("NO JOBIB SELECT!!");
                    }
                }
                else
                {
                    MessageBox.Show("Please First save the customer");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidSoftwareData())
            { 
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtGrandTotal.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text)).ToString();
                txtOutStanding.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text) + float.Parse(txtExtraCharge.Text) - float.Parse(txtDiscounts.Text) - float.Parse(txtInitailAmount.Text)).ToString();
            }
            catch { }
        }

        private void txtGrandTotal_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtExtraCharge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtGrandTotal.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text) + float.Parse(txtExtraCharge.Text)).ToString();
                txtOutStanding.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text) + float.Parse(txtExtraCharge.Text) - float.Parse(txtDiscounts.Text) - float.Parse(txtInitailAmount.Text)).ToString();
            }
            catch { }
        }

        private void txtDiscounts_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtGrandTotal.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text) + float.Parse(txtExtraCharge.Text) - float.Parse(txtDiscounts.Text)).ToString();
                txtOutStanding.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text) + float.Parse(txtExtraCharge.Text) - float.Parse(txtDiscounts.Text) - float.Parse(txtInitailAmount.Text)).ToString();
            }
            catch { }
        }

        private void txtVat_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtGrandTotal.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text)).ToString();
                txtOutStanding.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text) + float.Parse(txtExtraCharge.Text) - float.Parse(txtDiscounts.Text) - float.Parse(txtInitailAmount.Text)).ToString();
            }
            catch { }
        }

        private void txtInitailAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtOutStanding.Text = (float.Parse(txtAmount.Text) + float.Parse(txtVat.Text) + float.Parse(txtExtraCharge.Text) - float.Parse(txtDiscounts.Text) - float.Parse(txtInitailAmount.Text)).ToString();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (CurrentIndex > 0)
            {
                CurrentIndex--;
                FillHardwareSoftwareCard();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentIndex < (NoOfPayments - 1))
            {
                CurrentIndex++;
                FillHardwareSoftwareCard();
            }
        }

      




    }
}
