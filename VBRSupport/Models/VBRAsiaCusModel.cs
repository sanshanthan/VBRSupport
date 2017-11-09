using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VBRAsiaCusModel
    {
    public VBRAsiaCusModel()
    {
        #region Empty
        Customer_No = "";
        Name = "";
        Street = "";
        Post_Code = "";
        Telephone1 = "";
        Telephone2 = "";
        Address_1 = "";
        Address_2 = "";
        E_Mail = "";
        No_Of_Shops = 0;
        Support_End_Date = Convert.ToDateTime("1990-01-01");
        Due_Date =Convert.ToDateTime("1990-01-01");
        Added_Date = Convert.ToDateTime("1990-01-01");
        IsPaid = false;
        InvoiceTotal= 0;
        TotalPaid = 0;

        #endregion Empty
    }
    public string Customer_No { get; set; }
    public string Name { get; set; }
    public string Street { get; set; }
    public string Post_Code { get; set; }
    public string Telephone1 { get; set; }
    public string Telephone2 { get; set; }
    public string Address_1 { get; set; }
    public string Address_2 { get; set; }
    public string E_Mail { get; set; }
    public int No_Of_Shops { get; set; }
    public DateTime Support_End_Date { get; set; }
    public DateTime Due_Date { get; set; }
    public DateTime Added_Date { get; set; }
    public bool IsPaid { get; set; }
    public decimal InvoiceTotal { get; set; }
    public decimal TotalPaid { get; set; }
    }
