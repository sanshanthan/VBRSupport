using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class HistoryModel
{
    public HistoryModel()
    {
        #region Empty
        CustomerNo = "";
        ShopName = "";
        Address_Line_1 = "";
        Address_Line_2 = "";
        Telephone = "";
        Post_Code = "";
        ReceiptHeader_Line_1 = "";
        ReceiptHeader_Line_2 = "";
        ReceiptHeader_Line_3 = "";
        ReceiptHeader_Line_4 = "";
        ReceiptHeader_Line_5 = "";
        Email_Address_1 = "";
        Email_Address_2 = "";

        IsActive = false;
        SupportEndDate =Convert.ToDateTime("1990-01-01");
        LastAcitive = Convert.ToDateTime("1990-01-01");
        No_Of_Hosts = 0;
        Till_Id = "";
        FirstDate = Convert.ToDateTime("1990-01-01");
        TillVersion = "";
        BackofficeVersion = "";
        SchedulerVersion = "";
        Serial = "";
        Mac = "";
        #endregion Empty
    }
    #region 13
    public string CustomerNo { get; set; }
    public string ShopName { get; set; }
    public string Address_Line_1 { get; set; }
    public string Address_Line_2 { get; set; }
    public string Telephone { get; set; }
    public string Post_Code { get; set; }
    public string ReceiptHeader_Line_1 { get; set; }
    public string ReceiptHeader_Line_2 { get; set; }
    public string ReceiptHeader_Line_3 { get; set; }
    public string ReceiptHeader_Line_4 { get; set; }
    public string ReceiptHeader_Line_5 { get; set; }
    public string Email_Address_1 { get; set; }
    public string Email_Address_2 { get; set; }
    #endregion 13

    public bool IsActive { get; set; }
    public DateTime SupportEndDate { get; set; }
    public DateTime LastAcitive { get; set; }
    public int No_Of_Hosts { get; set; }
    public string Till_Id { get; set; }

    public DateTime FirstDate { get; set; }
    public string TillVersion { get; set; }
    public string BackofficeVersion { get; set; }
    public string SchedulerVersion { get; set; }
    public string Serial { get; set; }
    public string Mac { get; set; }
}

