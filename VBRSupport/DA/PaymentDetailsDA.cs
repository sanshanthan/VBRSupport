using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


public static class PaymentDetailsDA
{
    public static List<PaymentsModel> GetPaymentDetails(string Connection, string Customer_No)
    {
        List<PaymentsModel> lm = new List<PaymentsModel>();
        string sql = "";
        #region SQL
        sql += "SELECT Customer_No, JobID, JobDetails, Amount, Vat, ExtraCharge, ";
        sql += "ExtraChargeDetails, Discounts, GrandTotal, InitailAmount, OutStanding, IsPaid ";
        sql += "FROM VBRAsia_Customers_Payments WHERE [Customer_No]=@Customer_No ";
        sql += "order by JobID";
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
                            else if (i == 1) try { m.JobID = reader.GetInt32(i); }
                                catch { }
                            else if (i == 2) try { m.JobDetails = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.Amount = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 4) try { m.Vat = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 5) try { m.ExtraCharge = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 6) try { m.ExtraChargeDetails = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.Discounts = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 8) try { m.GrandTotal = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 9) try { m.InitailAmount = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 10) try { m.OutStanding = reader.GetDecimal(i); }
                                catch { }
                            else if (i == 11) try { m.IsPaid = reader.GetBoolean(i); }
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


    public static int InsertPaymentDetails(string Connection, PaymentsModel m)
    {
        int affectedRows = 0;
        string sql = "";
        #region SQL
        sql += "INSERT INTO VBRAsia_Customers_Payments ";
        sql += "(Customer_No, JobDetails, Amount, Vat, ExtraCharge, ExtraChargeDetails, ";
        sql += "Discounts, GrandTotal, InitailAmount, OutStanding, IsPaid) ";
        sql += "VALUES (@Customer_No, @JobDetails, @Amount, @Vat, @ExtraCharge, @ExtraChargeDetails, ";
        sql += "@Discounts, @GrandTotal, @InitailAmount, @OutStanding, @IsPaid) ";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                #region Parameter Declare

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Customer_No";
                param.Value = m.Customer_No;
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@JobDetails";
                param.Value = m.JobDetails;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Amount";
                param.Value = m.Amount;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Vat";
                param.Value = m.Vat;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@ExtraCharge";
                param.Value = m.ExtraCharge;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@ExtraChargeDetails";
                param.Value = m.ExtraChargeDetails;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Discounts";
                param.Value = m.Discounts;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@GrandTotal";
                param.Value = m.GrandTotal;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@InitailAmount";
                param.Value = m.InitailAmount;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@OutStanding";
                param.Value = m.OutStanding;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@IsPaid";
                param.Value = m.IsPaid;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                #endregion Parameter Declare

                affectedRows = command.ExecuteNonQuery();

            }
        }
        return affectedRows;
    }


    public static int UpdatePaymentDetails(string Connection, PaymentsModel m)
    {
        int affectedRows = 0;
        string sql = "";
        #region SQL
        sql += "UPDATE VBRAsia_Customers_Payments ";
        sql += "SET [Customer_No] =@Customer_No, [JobDetails] =@JobDetails, [Amount] =@Amount, [Vat] =@Vat, ";
        sql += "[ExtraCharge] =@ExtraCharge, [ExtraChargeDetails] =@ExtraChargeDetails, [Discounts] =@Discounts, ";
        sql += "[GrandTotal] =@GrandTotal, [InitailAmount] =@InitailAmount, [OutStanding] =@OutStanding, [IsPaid] =@IsPaid ";
        sql += "WHERE [JobID] =@JobID ";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                #region Parameter Declare

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Customer_No";
                param.Value = m.Customer_No;
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@JobDetails";
                param.Value = m.JobDetails;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Amount";
                param.Value = m.Amount;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Vat";
                param.Value = m.Vat;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@ExtraCharge";
                param.Value = m.ExtraCharge;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@ExtraChargeDetails";
                param.Value = m.ExtraChargeDetails;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Discounts";
                param.Value = m.Discounts;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@GrandTotal";
                param.Value = m.GrandTotal;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@InitailAmount";
                param.Value = m.InitailAmount;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@OutStanding";
                param.Value = m.OutStanding;
                param.DbType = DbType.Decimal;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@IsPaid";
                param.Value = m.IsPaid;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);


                param = command.CreateParameter();
                param.ParameterName = "@JobID";
                param.Value = m.JobID;
                param.DbType = DbType.Int32;
                command.Parameters.Add(param);

                #endregion Parameter Declare

                affectedRows = command.ExecuteNonQuery();

            }
        }
        return affectedRows;
    }
}




