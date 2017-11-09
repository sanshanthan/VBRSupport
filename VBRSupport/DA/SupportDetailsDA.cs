using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

public static class SupportDetailsDA
{
    public static List<SupportDetailsModel> GetSupportDetail(string Connection, string CutomerNo)
    {
        List<SupportDetailsModel> lm = new List<SupportDetailsModel>();
        string sql = "";
        #region SQL
        sql += "SELECT [Id],[Customer_No],[Name],[ContactNo],[ShopName] ";
        sql += ",[SupportBy],[SupportDetail],[Suggestions],[Notes] ";
        sql += ",[SupportDate] FROM SupportDetails WHERE [Customer_No]=@CutomerNo ";
        sql += "order by SupportDate";
        #endregion SQL
        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CutomerNo";
                param.Value = CutomerNo;
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SupportDetailsModel m = new SupportDetailsModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            if (i == 0) try { m.Id = reader.GetInt32(i); }
                                catch { }
                            else if (i == 1) try { m.CutomerNo = reader.GetString(i); }
                                catch { }
                            else if (i == 2) try { m.Name = reader.GetString(i); }
                                catch { }
                            else if (i == 3) try { m.ContactNo = reader.GetString(i); }
                                catch { }
                            else if (i == 4) try { m.ShopName = reader.GetString(i); }
                                catch { }
                            else if (i == 5) try { m.SupportBy = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.SupportDetail = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.Suggestions = reader.GetString(i); }
                                catch { }
                            else if (i == 8) try { m.Notes = reader.GetString(i); }
                                catch { }
                            else if (i == 9) try { m.SupportDate = reader.GetDateTime(i); }
                                catch { }
                            else if (i == 10) try { m.Id = reader.GetInt32(i); }
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
    public static int UpdateSupportDetail(string Connection, SupportDetailsModel m)
    {
        int affectedRows = 0;
        string sql = "";
        #region SQL
        sql += "UPDATE SupportDetails ";
        sql += "SET [Customer_No] = @CutomerNo,[Name] = @Name ";
        sql += ",[ContactNo] = @ContactNo,[ShopName] = @ShopName,[SupportBy] = @SupportBy ";
        sql += ",[SupportDetail] = @SupportDetail,[Suggestions] = @Suggestions ";
        sql += ",[Notes] = @Notes,[SupportDate] = @SupportDate ";
        sql += " WHERE [Id]=@id";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                #region Params

                #region LINE1
                //[CutomerNo] = @CutomerNo,[Name] = @Name
                #region @CutomerNo
                SqlParameter param = new SqlParameter();
                param = new SqlParameter();
                param.ParameterName = "@CutomerNo";
                param.Value = m.CutomerNo;
                param.DbType = DbType.String;
                param.Size = 20;
                command.Parameters.Add(param);
                #endregion @CutomerNo
                #region @Name
                param = new SqlParameter();
                param.ParameterName = "@Name";
                param.Value = m.Name;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);
                #endregion @Name
                #endregion LINE1
                #region LINE2
                //[ContactNo] = @ContactNo,[ShopName] = @ShopName,[SupportBy] = @SupportBy
                #region @ContactNo
                param = new SqlParameter();
                param.ParameterName = "@ContactNo";
                param.Value = m.ContactNo;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);
                #endregion @ContactNo
                #region @ShopName
                param = new SqlParameter();
                param.ParameterName = "@ShopName";
                param.Value = m.ShopName;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);
                #endregion @ShopName
                #region @SupportBy
                param = new SqlParameter();
                param.ParameterName = "@SupportBy";
                param.Value = m.SupportBy;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);
                #endregion @SupportBy
                #endregion LINE2
                #region LINE3
                //[SupportDetail] = @SupportDetail,[Suggestions] = @Suggestions 
                #region @SupportDetail
                param = new SqlParameter();
                param.ParameterName = "@SupportDetail";
                param.Value = m.SupportDetail;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);
                #endregion @SupportDetail
                #region @Suggestions
                param = new SqlParameter();
                param.ParameterName = "@Suggestions";
                param.Value = m.Suggestions;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);
                #endregion @Suggestions
                #endregion LINE3
                #region LINE4
                //[Notes] = @Notes,[SupportDate] = @SupportDate,[Id]=@id
                #region @Notes
                param = new SqlParameter();
                param.ParameterName = "@Notes";
                param.Value = m.Notes;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);
                #endregion @Notes
                #region @SupportDate
                param = new SqlParameter();
                param.ParameterName = "@SupportDate";
                param.Value = m.SupportDate;
                param.DbType = DbType.DateTime;
                //param.Size = 200;
                command.Parameters.Add(param);
                #endregion @SupportDate
                #region @id
                param = new SqlParameter();
                param.ParameterName = "@id";
                param.Value = m.Id;
                param.DbType = DbType.Int32;
                //param.Size = 200;
                command.Parameters.Add(param);
                #endregion @id
                #endregion LINE4

                #endregion Params
                affectedRows = command.ExecuteNonQuery();
            }
        }
        return affectedRows;
    }
    public static int InsertSupportDetails(string Connection, SupportDetailsModel m)
    {
        int affectedRows = 0;
        string sql = "";
        #region SQL
        sql += "INSERT INTO [SupportDetails] ";
        sql += "([Customer_No],[Name],[ContactNo],[ShopName],[SupportBy], ";
        sql += "[SupportDetail],[Suggestions],[Notes],[SupportDate]) ";
        sql += "VALUES(@CutomerNo, @Name, @ContactNo,@ShopName, @SupportBy, ";
        sql += "@SupportDetail,@Suggestions, @Notes, @SupportDate) ";
        #endregion SQL

        using (SqlConnection conn = new SqlConnection(Connection))
        {
            conn.Open();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                #region Params

                #region Line 1
                //@CutomerNo, @Name, @ContactNo,@ShopName, @SupportBy
                #region @CutomerNo
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@CutomerNo";
                param.Value = m.CutomerNo;
                param.DbType = DbType.String;
                param.Size = 20;
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
                #region @ContactNo
                param = new SqlParameter();
                param.ParameterName = "@ContactNo";
                param.Value = m.ContactNo;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);
                #endregion @ContactNo
                #region @ShopName
                param = new SqlParameter();
                param.ParameterName = "@ShopName";
                param.Value = m.ShopName;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);
                #endregion @ShopName
                #region  @SupportBy
                param = new SqlParameter();
                param.ParameterName = "@SupportBy";
                param.Value = m.SupportBy;
                param.DbType = DbType.String;
                param.Size = 100;
                command.Parameters.Add(param);
                #endregion  @SupportBy

                #endregion Line 1
                #region Line 2
                //@SupportDetail,@Suggestions, @Notes, @SupportDate
                #region  @SupportDetail
                param = new SqlParameter();
                param.ParameterName = "@SupportDetail";
                param.Value = m.SupportDetail;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);
                #endregion  @SupportDetail
                #region  @Suggestions
                param = new SqlParameter();
                param.ParameterName = "@Suggestions";
                param.Value = m.Suggestions;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);
                #endregion  @Suggestions
                #region  @Notes
                param = new SqlParameter();
                param.ParameterName = "@Notes";
                param.Value = m.Notes;
                param.DbType = DbType.String;
                param.Size = 200;
                command.Parameters.Add(param);
                #endregion  @Notes
                #region  @SupportDate
                param = new SqlParameter();
                param.ParameterName = "@SupportDate";
                param.Value = m.SupportDate;
                param.DbType = DbType.DateTime;
                //param.Size = 200;
                command.Parameters.Add(param);
                #endregion  @SupportDate

                #endregion Line 2

                #endregion Params

                affectedRows = command.ExecuteNonQuery();

            }
        }
        return affectedRows;
    }
}
