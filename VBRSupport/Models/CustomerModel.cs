using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class CustomerModel
{
    public CustomerModel()
    {
        #region Empty
        No_ = "";
        Name = "";
        CActive = 0;
        CNewsMag = 0;
        CNisaProd = 0;
        CBooker = 0;
        CAuto = 0;
        CEmail = 0;
        EndDate = Convert.ToDateTime("1990-01-01");
        Due = Convert.ToDateTime("1990-01-01");
        IsPaid = false;
        #endregion Empty
    }
    public string No_ { get; set; }
    public string Name { get; set; }
    public byte CActive { get; set; }
    public byte CNewsMag { get; set; }
    public byte CNisaProd { get; set; }
    public byte CBooker { get; set; }
    public byte CAuto { get; set; }
    public byte CEmail { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime Due { get; set; }
    public bool IsPaid { get; set; }
}

