using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PaymentsModel
{
    public PaymentsModel()
    {
        #region Empty

        Customer_No = "";
        JobID = 0;
        JobDetails = "";
        Amount = 0;
        Vat = 0;
        ExtraCharge = 0;
        ExtraChargeDetails = "";
        Discounts = 0;
        GrandTotal = 0;
        InitailAmount = 0;
        OutStanding = 0;
        IsPaid = false;
        #endregion Empty
    }


    public string Customer_No { get; set; }
    public int JobID { get; set; }
    public string JobDetails { get; set; }
    public decimal Amount { get; set; }
    public decimal Vat { get; set; }
    public decimal ExtraCharge { get; set; }
    public string ExtraChargeDetails { get; set; }
    public decimal Discounts { get; set; }
    public decimal GrandTotal { get; set; }
    public decimal InitailAmount { get; set; }
    public decimal OutStanding { get; set; }
    public Boolean IsPaid { get; set; }
}
