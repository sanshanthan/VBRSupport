using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

  public class  SupportDetailsModel
    {
      public SupportDetailsModel()
      {
          #region Empty
          Id = 0;
          CutomerNo = "";
          Name = "";
          ContactNo = "";
          ShopName = "";
          SupportBy = "";
          SupportDetail = "";
          Suggestions = "";
          Notes = "";
          SupportDate = Convert.ToDateTime("1990-01-01");
          #endregion Empty
      }
      public int Id { get; set; }
      public string CutomerNo { get; set; }
      public string Name { get; set; }
      public string ContactNo { get; set; }
      public string ShopName { get; set; }
      public string SupportBy { get; set; }
      public string SupportDetail { get; set; }
      public string Suggestions { get; set; }
      public string Notes { get; set; }
      public DateTime SupportDate { get; set; }
    }
