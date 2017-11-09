using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public static class PaymentInstallmentDA
{
    public static List<PaymentInstallmentModel> GetPaymentInstallmentDetails(string Connection, String Customer_No)
    {
        List<PaymentInstallmentModel> lm = new List<PaymentInstallmentModel>();
        string sql = "";
        #region SQL
        sql += "SELECT ID, JobId, Customer_No, PayAmount, PayDate, PayType, CollectedBy ";
        sql += "FROM VBRAsia_Customers_PayInstallment WHERE [Customer_No]=@Customer_No ";
        sql += "ORDER BY ID ";
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

                            if (i == 0) try { m.ID = reader.GetInt32(i); }
                                catch { }
                            else if (i == 1) try { m.JobId = reader.GetInt32(i); }
                                catch { }
                            else if (i == 2) try { m.Customer_No = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.PayAmount = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 4) try { m.PayDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 5) try { m.PayType = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.CollectedBy = reader.GetString(i); }
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

    public static int InsertPaymentInstallment(string Connection, PaymentInstallmentModel m)
    {
        int affectedRows = 0;
        string sql = "";
        #region SQL
        sql += "INSERT INTO VBRAsia_Customers_PayInstallment ";
        sql += "(JobId, Customer_No, PayAmount, PayDate, PayType, CollectedBy) ";
        sql += "VALUES (@JobId,@Customer_No, @PayAmount, @PayDate, @PayType, @CollectedBy) ";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                #region Parameter Declare

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@JobId";
                param.Value = m.JobId;
                param.DbType = DbType.Int32;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Customer_No";
                param.Value = m.Customer_No;
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@PayAmount";
                param.Value = m.PayAmount;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@PayDate";
                param.Value = m.PayDate;
                param.DbType = DbType.DateTime;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@PayType";
                param.Value = m.PayType;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CollectedBy";
                param.Value = m.CollectedBy;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);

                #endregion Parameter Declare

                affectedRows = command.ExecuteNonQuery();

            }
        }
        return affectedRows;
    }
}
