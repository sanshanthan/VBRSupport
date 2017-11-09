using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


public static class CustPayCalDA
{
    public static List<PaymentInstallmentModel> GetTotalPaid(string Connection, String Customer_No)
    {
        List<PaymentInstallmentModel> lm = new List<PaymentInstallmentModel>();
        string sql = "";
        #region SQL
        sql += "select Customer_No, sum(PayAmount) Paid from VBRAsia_Customers_PayInstallment ";
        sql += "where Customer_No= @Customer_No ";
        sql += "group by Customer_No ";
        #endregion SQL
        using (SqlConnection conn = new SqlConnection(Connection))
        {
             conn.Open();
             using (SqlCommand command = new SqlCommand(sql, conn))
             {
                 SqlParameter param = new SqlParameter();
                param.ParameterName = "@Customer_No";
                param.Value = Customer_No;
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PaymentInstallmentModel m = new PaymentInstallmentModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.Customer_No = reader.GetString(i); }
                                catch { }
                            else if (i == 1) try { m.PayAmount = reader.GetDecimal(i); }
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
    public static List<PaymentsModel> GetInvoiceTotal(string Connection, string Customer_No)
    {
        List<PaymentsModel> lm = new List<PaymentsModel>();
        string sql = "";
        #region SQL
        sql += "select Customer_No,sum(GrandTotal) GrandTotal from VBRAsia_Customers_Payments ";
        sql += "where Customer_No= @Customer_No ";
        sql += "group by Customer_No ";
        #endregion SQL
        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Customer_No";
                param.Value = Customer_No;
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        PaymentsModel m = new PaymentsModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.Customer_No = reader.GetString(i); }
                                catch { }
                            if (i == 1) try { m.GrandTotal = reader.GetDecimal(i); }
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
