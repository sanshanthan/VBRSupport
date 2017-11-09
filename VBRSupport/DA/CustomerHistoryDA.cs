using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public static class CustomerHistoryDA
{
    public static List<HistoryModel> SeachCustomerHistoryByCustomerId(string Connection, string CustomerId)
    {
        List<HistoryModel> lm = new List<HistoryModel>();
        string sql = "";
        #region SQL
        sql += "select CustomerNo,ShopName,Address_Line_1,Address_Line_2,Telephone, ";
        sql += "Post_Code,ReceiptHeader_Line_1,ReceiptHeader_Line_2,ReceiptHeader_Line_3, ";
        sql += "ReceiptHeader_Line_4,ReceiptHeader_Line_5,Email_Address_1,Email_Address_2, ";
        sql += "IsActive,SupportEndDate,LastAcitive,No_Of_Hosts,Till_Id,FirstDate, ";
        sql += "TillVersion,BackofficeVersion,SchedulerVersion,Serial,Mac from History ";
        sql += "where CustomerNo Like @CutomerNo ";
        sql += "order by CustomerNo,ShopName,LastAcitive ";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CutomerNo";
                param.Value = CustomerId+"%";
                param.DbType = DbType.String;
                param.Size = 19;
                command.Parameters.Add(param);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistoryModel m = new HistoryModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.CustomerNo = reader.GetString(i); }
                                catch { }
                            else if (i == 1) try { m.ShopName = reader.GetString(i); }
                                catch { }
                            else if (i == 2) try { m.Address_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.Address_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 4) try { m.Telephone = reader.GetString(i); }
                                catch { }
                            else if (i == 5) try { m.Post_Code = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.ReceiptHeader_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.ReceiptHeader_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 8) try { m.ReceiptHeader_Line_3 = reader.GetString(i); }
                                catch { }
                            else if (i == 9) try { m.ReceiptHeader_Line_4 = reader.GetString(i); }
                                catch { }
                            else if (i == 10) try { m.ReceiptHeader_Line_5 = reader.GetString(i); }
                                catch { }
                            else if (i == 11) try { m.Email_Address_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 12) try { m.Email_Address_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 13) try { m.IsActive = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 14) try { m.SupportEndDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 15) try { m.LastAcitive = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 16) try { m.No_Of_Hosts = reader.GetInt32(i); }
                                catch { }
                            else if (i == 17) try { m.Till_Id = reader.GetString(i); }
                                catch { }
                            else if (i == 18) try { m.FirstDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 19) try { m.TillVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 20) try { m.BackofficeVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 21) try { m.SchedulerVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 22) try { m.Serial = reader.GetString(i); }
                                catch { }
                            else if (i == 23) try { m.Mac = reader.GetString(i); }
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
    public static List<HistoryModel> SearchCustomerHistoryByEmailId(string Connection, string EmailId)
    {
        List<HistoryModel> lm = new List<HistoryModel>();
        string sql = "";
        #region SQL
        sql += "select CustomerNo,ShopName,Address_Line_1,Address_Line_2,Telephone, ";
        sql += "Post_Code,ReceiptHeader_Line_1,ReceiptHeader_Line_2,ReceiptHeader_Line_3, ";
        sql += "ReceiptHeader_Line_4,ReceiptHeader_Line_5,Email_Address_1,Email_Address_2, ";
        sql += "IsActive,SupportEndDate,LastAcitive,No_Of_Hosts,Till_Id,FirstDate, ";
        sql += "TillVersion,BackofficeVersion,SchedulerVersion,Serial,Mac from History ";
        sql += "where Email_Address_1 Like @Email_Address ";
        sql += "OR Email_Address_2 Like @Email_Address2 "; 
        sql += "order by CustomerNo,ShopName,LastAcitive ";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                #region ParameterDecalre

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Email_Address"; 
                param.Value = EmailId + "%";
                param.DbType = DbType.String;
                param.Size = 49;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Email_Address2";
                param.Value = EmailId + "%";
                param.DbType = DbType.String;
                param.Size = 49;
                command.Parameters.Add(param);

                #endregion ParameterDecalre

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistoryModel m = new HistoryModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.CustomerNo = reader.GetString(i); }
                                catch { }
                            else if (i == 1) try { m.ShopName = reader.GetString(i); }
                                catch { }
                            else if (i == 2) try { m.Address_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.Address_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 4) try { m.Telephone = reader.GetString(i); }
                                catch { }
                            else if (i == 5) try { m.Post_Code = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.ReceiptHeader_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.ReceiptHeader_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 8) try { m.ReceiptHeader_Line_3 = reader.GetString(i); }
                                catch { }
                            else if (i == 9) try { m.ReceiptHeader_Line_4 = reader.GetString(i); }
                                catch { }
                            else if (i == 10) try { m.ReceiptHeader_Line_5 = reader.GetString(i); }
                                catch { }
                            else if (i == 11) try { m.Email_Address_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 12) try { m.Email_Address_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 13) try { m.IsActive = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 14) try { m.SupportEndDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 15) try { m.LastAcitive = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 16) try { m.No_Of_Hosts = reader.GetInt32(i); }
                                catch { }
                            else if (i == 17) try { m.Till_Id = reader.GetString(i); }
                                catch { }
                            else if (i == 18) try { m.FirstDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 19) try { m.TillVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 20) try { m.BackofficeVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 21) try { m.SchedulerVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 22) try { m.Serial = reader.GetString(i); }
                                catch { }
                            else if (i == 23) try { m.Mac = reader.GetString(i); }
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

    public static List<HistoryModel> SearchCustomerHistoryByPostCode(string Connection, string PostCode)
    {
        List<HistoryModel> lm = new List<HistoryModel>();
        string sql = "";
        #region SQL
        sql += "select CustomerNo,ShopName,Address_Line_1,Address_Line_2,Telephone, ";
        sql += "Post_Code,ReceiptHeader_Line_1,ReceiptHeader_Line_2,ReceiptHeader_Line_3, ";
        sql += "ReceiptHeader_Line_4,ReceiptHeader_Line_5,Email_Address_1,Email_Address_2, ";
        sql += "IsActive,SupportEndDate,LastAcitive,No_Of_Hosts,Till_Id,FirstDate, ";
        sql += "TillVersion,BackofficeVersion,SchedulerVersion,Serial,Mac from History ";
        sql += "where Post_Code like @Post_Code ";
        sql += "order by CustomerNo,ShopName,LastAcitive ";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Post_Code";
                param.Value = PostCode + "%";
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);


                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        HistoryModel m = new HistoryModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.CustomerNo = reader.GetString(i); }
                                catch { }
                            else if (i == 1) try { m.ShopName = reader.GetString(i); }
                                catch { }
                            else if (i == 2) try { m.Address_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.Address_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 4) try { m.Telephone = reader.GetString(i); }
                                catch { }
                            else if (i == 5) try { m.Post_Code = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.ReceiptHeader_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.ReceiptHeader_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 8) try { m.ReceiptHeader_Line_3 = reader.GetString(i); }
                                catch { }
                            else if (i == 9) try { m.ReceiptHeader_Line_4 = reader.GetString(i); }
                                catch { }
                            else if (i == 10) try { m.ReceiptHeader_Line_5 = reader.GetString(i); }
                                catch { }
                            else if (i == 11) try { m.Email_Address_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 12) try { m.Email_Address_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 13) try { m.IsActive = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 14) try { m.SupportEndDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 15) try { m.LastAcitive = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 16) try { m.No_Of_Hosts = reader.GetInt32(i); }
                                catch { }
                            else if (i == 17) try { m.Till_Id = reader.GetString(i); }
                                catch { }
                            else if (i == 18) try { m.FirstDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 19) try { m.TillVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 20) try { m.BackofficeVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 21) try { m.SchedulerVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 22) try { m.Serial = reader.GetString(i); }
                                catch { }
                            else if (i == 23) try { m.Mac = reader.GetString(i); }
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


    public static List<HistoryModel> SearchCustomerHistoryByEndDate(string Connection)
    {
        List<HistoryModel> lm = new List<HistoryModel>();
        string sql = "";
        #region SQL
        sql += "select CustomerNo,ShopName,Address_Line_1,Address_Line_2,Telephone, ";
        sql += "Post_Code,ReceiptHeader_Line_1,ReceiptHeader_Line_2,ReceiptHeader_Line_3, ";
        sql += "ReceiptHeader_Line_4,ReceiptHeader_Line_5,Email_Address_1,Email_Address_2, ";
        sql += "IsActive,SupportEndDate,LastAcitive,No_Of_Hosts,Till_Id,FirstDate, ";
        sql += "TillVersion,BackofficeVersion,SchedulerVersion,Serial,Mac from History ";
        sql += "where SupportEndDate BETWEEN GETDATE() AND GETDATE()+15  ";
        sql += "order by CustomerNo,ShopName,LastAcitive ";
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
                        HistoryModel m = new HistoryModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.CustomerNo = reader.GetString(i); }
                                catch { }
                            else if (i == 1) try { m.ShopName = reader.GetString(i); }
                                catch { }
                            else if (i == 2) try { m.Address_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.Address_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 4) try { m.Telephone = reader.GetString(i); }
                                catch { }
                            else if (i == 5) try { m.Post_Code = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.ReceiptHeader_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.ReceiptHeader_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 8) try { m.ReceiptHeader_Line_3 = reader.GetString(i); }
                                catch { }
                            else if (i == 9) try { m.ReceiptHeader_Line_4 = reader.GetString(i); }
                                catch { }
                            else if (i == 10) try { m.ReceiptHeader_Line_5 = reader.GetString(i); }
                                catch { }
                            else if (i == 11) try { m.Email_Address_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 12) try { m.Email_Address_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 13) try { m.IsActive = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 14) try { m.SupportEndDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 15) try { m.LastAcitive = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 16) try { m.No_Of_Hosts = reader.GetInt32(i); }
                                catch { }
                            else if (i == 17) try { m.Till_Id = reader.GetString(i); }
                                catch { }
                            else if (i == 18) try { m.FirstDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 19) try { m.TillVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 20) try { m.BackofficeVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 21) try { m.SchedulerVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 22) try { m.Serial = reader.GetString(i); }
                                catch { }
                            else if (i == 23) try { m.Mac = reader.GetString(i); }
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

    public static List<HistoryModel> GetCustomerHistory(String Connection)
    {
        List<HistoryModel> lm = new List<HistoryModel>();
        string sql = "";
        #region SQL
        sql += "select Top 30 CustomerNo,ShopName,Address_Line_1,Address_Line_2,Telephone, ";
        sql += "Post_Code,ReceiptHeader_Line_1,ReceiptHeader_Line_2,ReceiptHeader_Line_3, ";
        sql += "ReceiptHeader_Line_4,ReceiptHeader_Line_5,Email_Address_1,Email_Address_2, ";
        sql += "IsActive,SupportEndDate,LastAcitive,No_Of_Hosts,Till_Id,FirstDate, ";
        sql += "TillVersion,BackofficeVersion,SchedulerVersion,Serial,Mac from History ";
        sql += "order by CustomerNo,ShopName,LastAcitive ";
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
                        HistoryModel m = new HistoryModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.CustomerNo = reader.GetString(i); }
                                catch { }
                            else if (i == 1) try { m.ShopName = reader.GetString(i); }
                                catch { }
                            else if (i == 2) try { m.Address_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.Address_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 4) try { m.Telephone = reader.GetString(i); }
                                catch { }
                            else if (i == 5) try { m.Post_Code = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.ReceiptHeader_Line_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.ReceiptHeader_Line_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 8) try { m.ReceiptHeader_Line_3 = reader.GetString(i); }
                                catch { }
                            else if (i == 9) try { m.ReceiptHeader_Line_4 = reader.GetString(i); }
                                catch { }
                            else if (i == 10) try { m.ReceiptHeader_Line_5 = reader.GetString(i); }
                                catch { }
                            else if (i == 11) try { m.Email_Address_1 = reader.GetString(i); }
                                catch { }
                            else if (i == 12) try { m.Email_Address_2 = reader.GetString(i); }
                                catch { }
                            else if (i == 13) try { m.IsActive = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 14) try { m.SupportEndDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 15) try { m.LastAcitive = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 16) try { m.No_Of_Hosts = reader.GetInt32(i); }
                                catch { }
                            else if (i == 17) try { m.Till_Id = reader.GetString(i); }
                                catch { }
                            else if (i == 18) try { m.FirstDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 19) try { m.TillVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 20) try { m.BackofficeVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 21) try { m.SchedulerVersion = reader.GetString(i); }
                                catch { }
                            else if (i == 22) try { m.Serial = reader.GetString(i); }
                                catch { }
                            else if (i == 23) try { m.Mac = reader.GetString(i); }
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

