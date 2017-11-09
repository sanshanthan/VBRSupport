using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PaymentInstallmentModel
{
    public PaymentInstallmentModel()
    {
        #region Empty

        ID = 0;
        JobId = 0;
        Customer_No = "";
        PayAmount = 0;
        PayDate = Convert.ToDateTime("1990-01-01");
        PayType = "";
        CollectedBy = "";

        #endregion Empty

    }

    public int ID { get; set; }
    public int JobId { get; set; }
    public String Customer_No { get; set; }
    public decimal PayAmount { get; set; }
    public DateTime PayDate { get; set; }
    public string PayType { get; set; }
    public string CollectedBy { get; set; }

}
