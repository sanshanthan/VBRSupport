using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

   public static class VBRAsia_CustomersDA
    {
       public static List<VBRAsiaCusModel> GetVBRAsiaCustomer(string Connection, string CustomerNo)
       {
           List<VBRAsiaCusModel> lm = new List<VBRAsiaCusModel>();
           string sql = "";
           #region SQL
           sql += "SELECT [Customer_No],[Name],[Street],[Post_Code],[Telephone1]";
           sql += ",[Telephone2],[Address_1],[Address_2],[E_Mail]";
           sql += ",[No_Of_Shops],[Support_End_Date],[Due_Date],[Added_Date]";
           sql += ",[IsPaid] FROM VBRAsia_Customers where [Customer_No]=@Customer_No";
           #endregion SQL
           using (SqlConnection conn = new SqlConnection(Connection))
           {
               conn.Open();
               using (SqlCommand command = new SqlCommand(sql, conn))
               {
                   SqlParameter param = new SqlParameter();
                   param.ParameterName = "@Customer_No";
                   param.Value = CustomerNo;
                   param.DbType = DbType.String;
                   param.Size = 10;
                   command.Parameters.Add(param);
                   using (SqlDataReader reader = command.ExecuteReader())
                   {
                       while (reader.Read())
                       {
                           VBRAsiaCusModel m = new VBRAsiaCusModel();
                            #region Fill Model
                           for (int i = 0; i < reader.FieldCount; i++)
                           {
                               if (i == 0) try { m.Customer_No = reader.GetString(i); }
                                   catch { }
                               else if (i == 1) try { m.Name = reader.GetString(i); }
                                   catch { }
                               else if (i == 2) try { m.Street = reader.GetString(i); }
                                   catch { }
                               else if (i == 3) try { m.Post_Code = reader.GetString(i); }
                                   catch { }
                               else if (i == 4) try { m.Telephone1 = reader.GetString(i); }
                                   catch { }
                               else if (i == 5) try { m.Telephone2 = reader.GetString(i); }
                                   catch { }
                               else if (i == 6) try { m.Address_1 = reader.GetString(i); }
                                   catch { }
                               else if (i == 7) try { m.Address_2 = reader.GetString(i); }
                                   catch { }
                               else if (i == 8) try { m.E_Mail = reader.GetString(i); }
                                   catch { }
                               else if (i == 9) try { m.No_Of_Shops = reader.GetInt32(i); }
                                   catch { }
                               else if (i == 10) try { m.Support_End_Date = reader.GetDateTime(i); }
                                   catch { }
                               else if (i == 11) try { m.Due_Date = reader.GetDateTime(i); }
                                   catch { }
                               else if (i == 12) try { m.Added_Date = reader.GetDateTime(i); }
                                   catch { }
                               else if (i == 13) try { m.IsPaid = reader.GetBoolean(i); }
                                   catch { }

                           }
                            #endregion Fill Model
                           lm.Add(m);
                       }
                   }
               }
           }
           return lm;
       }
       public static int UpdateVBRAsiaCustomer(string Connection, VBRAsiaCusModel m)
       { 
           int affectedRows=0;
           string sql = "";
           #region SQL
           sql += "UPDATE VBRAsia_Customers ";
           sql += "SET [Name]=@Name,[Street]=@Street,[Post_Code]=@Post_Code ";
           sql += ",[Telephone1]=@Telephone1,[Telephone2]=@Telephone2,[Address_1]=@Address_1, ";
           sql += "[Address_2]=@Address_2,[E_Mail]=@E_Mail,[No_Of_Shops]=@No_Of_Shops, ";
           sql += "[Support_End_Date]=@Support_End_Date ,[Due_Date]=@Due_Date, ";
           sql += "[Added_Date]=@Added_Date,[IsPaid]=@IsPaid where [Customer_No]=@Customer_No";
           #endregion SQL

           using (SqlConnection conn = new SqlConnection(Connection))
           {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    #region Params
                    #region LINE1
                    //[Name]=@Name,[Street]=@Street,[Post_Code]=@Post_Code
                    #region @Name
                    SqlParameter param = new SqlParameter();
                    param = new SqlParameter();
                    param.ParameterName = "@Name";
                    param.Value = m.Name;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Name
                    #region @Street
                    param = new SqlParameter();
                    param.ParameterName = "@Street";
                    param.Value = m.Street;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Street
                    #region @Post_Code
                    param = new SqlParameter();
                    param.ParameterName = "@Post_Code";
                    param.Value = m.Post_Code;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Post_Code

                    #endregion LINE1
                    #region LINE2
                    //[Telephone1]=@Telephone1,[Telephone2]=@Telephone2,[Address_1]=@Address_1
                    #region @Telephone1
                    param = new SqlParameter();
                    param.ParameterName = "@Telephone1";
                    param.Value = m.Telephone1;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Telephone1
                    #region @Telephone2
                    param = new SqlParameter();
                    param.ParameterName = "@Telephone2";
                    param.Value = m.Telephone2;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Telephone2
                    #region @Address_1
                    param = new SqlParameter();
                    param.ParameterName = "@Address_1";
                    param.Value = m.Address_1;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Address_1
                    #endregion LINE2
                    #region LINE3
                    //[Address_2]=@Address_2,[E_Mail]=@E_Mail,[No_Of_Shops]=@No_Of_Shops,
                    #region @Address_2
                    param = new SqlParameter();
                    param.ParameterName = "@Address_2";
                    param.Value = m.Address_2;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Address_2
                    #region @E_Mail
                    param = new SqlParameter();
                    param.ParameterName = "@E_Mail";
                    param.Value = m.E_Mail;
                    param.DbType = DbType.String;
                    param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @E_Mail
                    #region @No_Of_Shops
                    param = new SqlParameter();
                    param.ParameterName = "@No_Of_Shops";
                    param.Value = m.No_Of_Shops;
                    param.DbType = DbType.Int32;
                    //param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @No_Of_Shops

                    #endregion LINE3
                    #region LINE4
                    //[Support_End_Date]=@Support_End_Date ,[Due_Date]=@Due_Date
                    #region @Support_End_Date
                    param = new SqlParameter();
                    param.ParameterName = "@Support_End_Date";
                    param.Value = m.Support_End_Date;
                    param.DbType = DbType.DateTime;
                    //param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Support_End_Date
                    #region @Due_Date
                    param = new SqlParameter();
                    param.ParameterName = "@Due_Date";
                    param.Value = m.Due_Date;
                    param.DbType = DbType.DateTime;
                    //param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Due_Date
                    #endregion LINE4
                    #region LINE5
                    //[Added_Date]=@Added_Date,[IsPaid]=@IsPaid where [Customer_No]=@Customer_No
                    #region @Added_Date
                    param = new SqlParameter();
                    param.ParameterName = "@Added_Date";
                    param.Value = m.Added_Date;
                    param.DbType = DbType.DateTime;
                    //param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @Added_Date
                    #region @IsPaid
                    param = new SqlParameter();
                    param.ParameterName = "@IsPaid";
                    param.Value = m.IsPaid;
                    param.DbType = DbType.Boolean;
                    //param.Size = 50;
                    command.Parameters.Add(param);
                    #endregion @IsPaid
                    #region @Customer_No
                    param = new SqlParameter();
                    param.ParameterName = "@Customer_No";
                    param.Value = m.Customer_No;
                    param.DbType = DbType.String;
                    param.Size = 10;
                    command.Parameters.Add(param);
                    #endregion @Customer_No
                    #endregion LINE5
                    #endregion Params
                    affectedRows = command.ExecuteNonQuery();
                }
           }
           return affectedRows;
       }

       public static int InsertVBRAsiaCustomer(string Connection,VBRAsiaCusModel m)
       {
           int affectedRows=0;
           string sql = "";
           #region SQL
           sql += "INSERT INTO [VBRAsia_Customers] ";
           sql += "([Customer_No],[Name],[Street],[Post_Code],[Telephone1], ";
           sql += "[Telephone2],[Address_1],[Address_2],[E_Mail],[No_Of_Shops] ";
           sql += ",[Support_End_Date],[Due_Date],[Added_Date],[IsPaid]) ";
           sql += "VALUES(@Customer_No,@Name,@Street,@Post_Code,@Telephone1,@Telephone2,@Address_1, ";
           sql += "@Address_2,@E_Mail,@No_Of_Shops,@Support_End_Date,@Due_Date,@Added_Date,@IsPaid)";
           #endregion SQL

           using (SqlConnection conn = new SqlConnection(Connection))
           {
               conn.Open();
               using (SqlCommand command = new SqlCommand(sql, conn))
               {
                   #region Params
                   //@Customer_No,@Name,@Street,@Post_Code,@Telephone1,@Telephone2,@Address_1,
                   #region Line 1
                   #region @Customer_No
                   SqlParameter param = new SqlParameter();
                   param.ParameterName = "@Customer_No";
                   param.Value = m.Customer_No;
                   param.DbType = DbType.String;
                   param.Size = 10;
                   command.Parameters.Add(param);
                   #endregion @Customer_No
                   #region @Name
                   param = new SqlParameter();
                   param.ParameterName = "@Name";
                   param.Value = m.Name;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Name
                   #region @Street
                   param = new SqlParameter();
                   param.ParameterName = "@Street";
                   param.Value = m.Street;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Street
                   #region @Post_Code
                   param = new SqlParameter();
                   param.ParameterName = "@Post_Code";
                   param.Value = m.Post_Code;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Post_Code
                   #region @Telephone1
                   param = new SqlParameter();
                   param.ParameterName = "@Telephone1";
                   param.Value = m.Telephone1;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Telephone1
                   #region @Telephone2
                   param = new SqlParameter();
                   param.ParameterName = "@Telephone2";
                   param.Value = m.Telephone2;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Telephone2
                   #region @Address_1
                   param = new SqlParameter();
                   param.ParameterName = "@Address_1";
                   param.Value = m.Address_1;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Address_1
                  

                   #endregion Line 1
                   #region Line 2
                   //@Address_2,@E_Mail,@No_Of_Shops,@Support_End_Date,@Due_Date,@Added_Date,@IsPaid
                   #region @Address_2
                   param = new SqlParameter();
                   param.ParameterName = "@Address_2";
                   param.Value = m.Address_2;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Address_2
                   #region @E_Mail
                   param = new SqlParameter();
                   param.ParameterName = "@E_Mail";
                   param.Value = m.E_Mail;
                   param.DbType = DbType.String;
                   param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @E_Mail
                   #region @No_Of_Shops
                   param = new SqlParameter();
                   param.ParameterName = "@No_Of_Shops";
                   param.Value = m.No_Of_Shops;
                   param.DbType = DbType.Int32;
                   //param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @No_Of_Shops
                   #region @Support_End_Date
                   param = new SqlParameter();
                   param.ParameterName = "@Support_End_Date";
                   param.Value = m.Support_End_Date;
                   param.DbType = DbType.DateTime;
                   //param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Support_End_Date
                   #region @Due_Date
                   param = new SqlParameter();
                   param.ParameterName = "@Due_Date";
                   param.Value = m.Due_Date;
                   param.DbType = DbType.DateTime;
                   //param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Due_Date
                   #region @Added_Date
                   param = new SqlParameter();
                   param.ParameterName = "@Added_Date";
                   param.Value = m.Added_Date;
                   param.DbType = DbType.DateTime;
                   //param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @Added_Date
                   #region @IsPaid
                   param = new SqlParameter();
                   param.ParameterName = "@IsPaid";
                   param.Value = m.IsPaid;
                   param.DbType = DbType.Boolean;
                   //param.Size = 50;
                   command.Parameters.Add(param);
                   #endregion @IsPaid

                   #endregion Line 2
                   #endregion Params

                   affectedRows = command.ExecuteNonQuery();

               }
           }
           return affectedRows;
       }
    }

