using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public static class CustomerDA
{

    public static List<CustomerModel> GetCustomerById(string Connection, string No_)
    {
        List<CustomerModel> lm = new List<CustomerModel>();
        string sql = "";
        #region SQL
        sql += "select [No_],[Name],[CActive],[CNewsMag],[CNisaProd] ";
        sql += ",[CBooker],[CAuto],[CEmail],[EndDate],[Due],[IsPaid]  ";
        sql += "from Customer where [No_]=@No_";
        #endregion SQL
        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            { 
                   SqlParameter param = new SqlParameter();
                param.ParameterName = "@No_";
                param.Value = No_; 
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);
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
   /*
    * public static List<CustomerModel> GetCustomerByPostCode(string Connection, string No_)
    {
       
    }
    * */

    public static List<CustomerModel> GetCustomerByName(string Connection, string Name )
    {
        List<CustomerModel> lm = new List<CustomerModel>();
        string sql = "";
        #region SQL
        sql += "select [No_],[Name],[CActive],[CNewsMag],[CNisaProd] ";
        sql += ",[CBooker],[CAuto],[CEmail],[EndDate],[Due],[IsPaid]  ";
        sql += "from Customer where [Name] like @Name";
        #endregion SQL
        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Name";
                param.Value = Name + "%";
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);
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
    public static List<CustomerModel> GetCustomer(string Connection, string No_)
    {
        List<CustomerModel> lm = new List<CustomerModel>();
        string sql = "";
        #region SQL
        sql += "select [No_],[Name],[CActive],[CNewsMag],[CNisaProd] ";
        sql += ",[CBooker],[CAuto],[CEmail],[EndDate],[Due],[IsPaid]  ";
        sql += "from Customer where [No_] like @No_";
        #endregion SQL
        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@No_";
                param.Value = No_ + "%"; 
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);
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

    //GET_ALL_CUSTOMER:::
    public static List<CustomerModel> GetAllCustomer(string Connection)
    {
        List<CustomerModel> lm = new List<CustomerModel>();
        string sql = "";
        #region SQL
        sql += "select [No_],[Name],[CActive],[CNewsMag],[CNisaProd] ";
        sql += ",[CBooker],[CAuto],[CEmail],[EndDate],[Due],[IsPaid]  ";
        sql += "from Customer ";
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