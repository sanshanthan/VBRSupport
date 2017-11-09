using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

   public static class VBRStaffDA
    {
       public static List<VBRStaffModel> LoginVBRStaffModel(string Connection,int ID)
       {
           List<VBRStaffModel> lm = new List<VBRStaffModel>();
           string sql = "";
           #region SQL
           sql += "SELECT [ID],[Name],[Password] ";
           sql += "FROM [VBRStaff] ";
           sql += "WHERE [ID]= @ID";
           #endregion SQL
           using (SqlConnection conn = new SqlConnection(Connection))
           {
               conn.Open();
               using (SqlCommand command = new SqlCommand(sql, conn))
               {
                   SqlParameter param = new SqlParameter();
                   param.ParameterName = "@ID";
                   param.Value = ID;
                   param.DbType = DbType.Int32;
                   command.Parameters.Add(param);
                   using (SqlDataReader reader = command.ExecuteReader())
                   {
                       while (reader.Read())
                       {
                           VBRStaffModel m = new VBRStaffModel();
                           #region Fill Model
                           for (int i = 0; i < reader.FieldCount; i++)
                           {
                               if (i == 0) try { m.Id = reader.GetInt32(i); }
                                   catch { }
                               else if (i == 1) try { m.Name = reader.GetString(i); }
                                   catch { }
                               else if (i == 2) try { m.Password = reader.GetString(i); }
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
