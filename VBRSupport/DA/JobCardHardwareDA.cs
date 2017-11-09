using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


public class JobCardHardwareDA
{
    public static List<JobCardHardwareModel> GetHardwareDetails(string Connection, string Customer_No)
    {
        List<JobCardHardwareModel> lm = new List<JobCardHardwareModel>();
        string sql = "";
        #region SQL
        sql += "SELECT ID, Customer_No, JobId, CashDrawer, ThermalPrinter, Scanner, CustomerDisplay, LaserPrinter, ";
        sql += "BackOffice_Computer, BackOffice_Scanner, DualDisplay, Scaler, CardReciver, CameraBoxLink, ";
        sql += "PiccolinkSet, KitchenPrinter, HardDisk, NetworkCable FROM VBRAsia_JobCard_HardwareDetails ";
        sql += "WHERE Customer_No = @Customer_No ";
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
                        JobCardHardwareModel m = new JobCardHardwareModel();
                        #region Fill Model
                        for (int i = 0; i < reader.FieldCount; i++)
                        {

                            if (i == 0) try { m.ID = reader.GetInt32(i); }
                                catch { }
                            else if (i == 1) try { m.Customer_No = reader.GetString(i); }
                                catch { }
                            else if (i == 2) try { m.JobId = reader.GetInt32(i); }
                                catch { }
                            else if (i == 3) try { m.Unit = reader.GetString(i); }
                                catch { }
                            else if (i == 4) try { m.CashDrawer = reader.GetString(i); }
                                catch { }
                            else if (i == 5) try { m.ThermalPrinter = reader.GetString(i); }
                                catch { }
                            else if (i == 6) try { m.Scanner = reader.GetString(i); }
                                catch { }
                            else if (i == 7) try { m.CustomerDisplay = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 8) try { m.LaserPrinter = reader.GetString(i); }
                                catch { }
                            else if (i == 9) try { m.BackOffice_Computer = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 10) try { m.BackOffice_Scanner = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 11) try { m.DualDisplay = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 12) try { m.Scaler = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 13) try { m.CardReciver = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 14) try { m.CameraBoxLink = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 15) try { m.PiccolinkSet = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 16) try { m.KitchenPrinter = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 17) try { m.HardDisk = reader.GetBoolean(i); }
                                catch { }
                            else if (i == 18) try { m.NetworkCable = reader.GetBoolean(i); }
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

    public static int InsertHardwareDetails(string Connection, JobCardHardwareModel m)
    {
        int affectedRows = 0;
        string sql = "";
        #region SQL
        sql += "INSERT INTO [VBRAsia_JobCard_HardwareDetails] ";
        sql += "(Customer_No, JobId, Unit, CashDrawer, ThermalPrinter, Scanner, CustomerDisplay, LaserPrinter, BackOffice_Computer, ";
        sql += "BackOffice_Scanner, DualDisplay, Scaler, CardReciver, CameraBoxLink, PiccolinkSet, KitchenPrinter, HardDisk, NetworkCable) ";
        sql += "VALUES (@Customer_No, @JobId, @Unit, @CashDrawer, @ThermalPrinter, @Scanner, @CustomerDisplay, @LaserPrinter, @BackOffice_Computer, ";
        sql += "@BackOffice_Scanner, @DualDisplay, @Scaler, @CardReciver, @CameraBoxLink, @PiccolinkSet, @KitchenPrinter, @HardDisk, @NetworkCable) ";
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
                param.ParameterName = "@JobId";
                param.Value = m.JobId;
                param.DbType = DbType.Int32;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Unit";
                param.Value = m.Unit;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CashDrawer";
                param.Value = m.CashDrawer;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@ThermalPrinter";
                param.Value = m.ThermalPrinter;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Scanner";
                param.Value = m.Scanner;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CustomerDisplay";
                param.Value = m.CustomerDisplay;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@LaserPrinter";
                param.Value = m.LaserPrinter;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@BackOffice_Computer";
                param.Value = m.BackOffice_Computer;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@BackOffice_Scanner";
                param.Value = m.BackOffice_Scanner;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@DualDisplay";
                param.Value = m.DualDisplay;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Scaler";
                param.Value = m.Scaler;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CardReciver";
                param.Value = m.CardReciver;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CameraBoxLink";
                param.Value = m.CameraBoxLink;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@PiccolinkSet";
                param.Value = m.PiccolinkSet;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@KitchenPrinter";
                param.Value = m.KitchenPrinter;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@HardDisk";
                param.Value = m.HardDisk;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@NetworkCable";
                param.Value = m.NetworkCable;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                #endregion Parameter Declare

                affectedRows = command.ExecuteNonQuery();

            }
        }
        return affectedRows;
    }

    public static int UpdateHardwareDetails(string Connection, JobCardHardwareModel m)
    {
        int affectedRows = 0;
        string sql = "";
        #region SQL
        sql += "UPDATE VBRAsia_JobCard_HardwareDetails ";
        sql += "SET Customer_No =@Customer_No , Unit =@Unit, CashDrawer =@CashDrawer, ThermalPrinter = @ThermalPrinter, ";
        sql += "Scanner =@Scanner, CustomerDisplay =@CustomerDisplay, LaserPrinter =@LaserPrinter, BackOffice_Computer =@BackOffice_Computer, ";
        sql += "BackOffice_Scanner =@BackOffice_Scanner, DualDisplay =@DualDisplay, Scaler =@Scaler, CardReciver =@CardReciver, ";
        sql += "CameraBoxLink =@CameraBoxLink,PiccolinkSet =@PiccolinkSet, KitchenPrinter =@KitchenPrinter, HardDisk =@HardDisk, NetworkCable = @NetworkCable ";
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
                param.ParameterName = "@Unit";
                param.Value = m.Unit;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CashDrawer";
                param.Value = m.CashDrawer;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@ThermalPrinter";
                param.Value = m.ThermalPrinter;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Scanner";
                param.Value = m.Scanner;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CustomerDisplay";
                param.Value = m.CustomerDisplay;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@LaserPrinter";
                param.Value = m.LaserPrinter;
                param.DbType = DbType.String;
                param.Size = 50;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@BackOffice_Computer";
                param.Value = m.BackOffice_Computer;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@BackOffice_Scanner";
                param.Value = m.BackOffice_Scanner;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@DualDisplay";
                param.Value = m.DualDisplay;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@Scaler";
                param.Value = m.Scaler;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CardReciver";
                param.Value = m.CardReciver;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@CameraBoxLink";
                param.Value = m.CameraBoxLink;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@PiccolinkSet";
                param.Value = m.PiccolinkSet;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@KitchenPrinter";
                param.Value = m.KitchenPrinter;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@HardDisk";
                param.Value = m.HardDisk;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                param = command.CreateParameter();
                param.ParameterName = "@NetworkCable";
                param.Value = m.NetworkCable;
                param.DbType = DbType.Boolean;
                command.Parameters.Add(param);

                #endregion Parameter Declare

                affectedRows = command.ExecuteNonQuery();

            }
        }
        return affectedRows;
    }

}

