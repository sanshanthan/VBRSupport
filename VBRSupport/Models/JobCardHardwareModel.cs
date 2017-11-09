using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class JobCardHardwareModel
{
    public JobCardHardwareModel()
    {

        #region Empty
        ID = 0;
        Customer_No = "";
        JobId = 0;
        Unit = "";
        CashDrawer = "";
        ThermalPrinter = "";
        Scanner = "";
        CustomerDisplay = false;
        LaserPrinter = "";
        BackOffice_Computer = false;
        BackOffice_Scanner = false;
        DualDisplay = false;
        Scaler = false;
        CardReciver = false;
        CameraBoxLink = false;
        PiccolinkSet = false;
        KitchenPrinter = false;
        HardDisk = false;
        NetworkCable = false;
        #endregion Empty
    }
    public int ID { get; set; }
    public string Customer_No { get; set; }
    public int JobId { get; set; }
    public string Unit { get; set; }
    public string CashDrawer { get; set; }
    public string ThermalPrinter { get; set; }
    public string Scanner { get; set; }
    public Boolean CustomerDisplay { get; set; }
    public string LaserPrinter { get; set; }
    public Boolean BackOffice_Computer { get; set; }
    public Boolean BackOffice_Scanner { get; set; }
    public Boolean DualDisplay { get; set; }
    public Boolean Scaler { get; set; }
    public Boolean CardReciver { get; set; }
    public Boolean CameraBoxLink { get; set; }
    public Boolean PiccolinkSet { get; set; }
    public Boolean KitchenPrinter { get; set; }
    public Boolean HardDisk { get; set; }
    public Boolean NetworkCable { get; set; }
}

