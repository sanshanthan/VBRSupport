using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VBRStaffModel
    {
        public VBRStaffModel()
      {
        #region Empty
          Id = 0;
          Name = "";
          Password = "";
          #endregion Empty
    }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

    }
    /*
    CREATE TABLE [VBRStaff](
        [ID] [int] NOT NULL,
        [Name] [varchar](50) NULL,
        [Password] [varchar](50) NULL,
        )
	
    */
