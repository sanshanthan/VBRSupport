using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

    public static class DueCustomersDA
    {

        public static List<CustomerModel> GetDueCustomers(string Connection)
        {
            List<CustomerModel> lm = new List<CustomerModel>();
            string sql = "";
            #region SQL
            sql += "declare @CustomerNos Table(No_ varchar(20))  ";
            sql += "Insert into @CustomerNos(No_) ";
            sql += "select distinct No_ from Customer ";
            sql += "where No_ not in (select distinct CustomerNo from History) ";

            sql += "select distinct No_,Name,CActive,CNewsMag,CNisaProd,CBooker,CAuto, ";
            sql += "CEmail,EndDate,Due,IsPaid from Customer ";
            sql += "where IsPaid=0 and  Due < DATEADD(day,10,GETDATE()) and cactive=1 ";
            #endregion SQL

            using (SqlConnection conn = new SqlConnection(Connection))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sql, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerModel m = new CustomerModel();
                            #region Fill Model
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                if (i == 0) try { m.No_ = reader.GetString(i); }
                                    catch { }
                                else if (i == 1) try { m.Name = reader.GetString(i); }
                                    catch { }
                                else if (i == 2) try { m.CActive = reader.GetByte(i); }
                                    catch { }
                                else if (i == 3) try { m.CNewsMag = reader.GetByte(i); }
                                    catch { }
                                else if (i == 4) try { m.CNisaProd = reader.GetByte(i); }
                                    catch { }
                                else if (i == 5) try { m.CBooker = reader.GetByte(i); }
                                    catch { }
                                else if (i == 6) try { m.CAuto = reader.GetByte(i); }
                                    catch { }
                                else if (i == 7) try { m.CEmail = reader.GetByte(i); }
                                    catch { }
                                else if (i == 8) try { m.EndDate = reader.GetDateTime(i); }
                                    catch { }
                                else if (i == 9) try { m.Due = reader.GetDateTime(i); }
                                    catch { }
                                else if (i == 10) try { m.IsPaid = reader.GetBoolean(i); }
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
    }


