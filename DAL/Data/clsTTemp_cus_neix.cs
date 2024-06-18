
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL
{
    public partial class clsTTemp
    {
        // Enter Your Code Here

        //public static DataTable GetDataTable_For_Dropdown(int Id, int SelectedAll)
        //{
        //    DataTable result = null;

        //    try
        //    {
        //        result = new DataTable();

        //        using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
        //        {
        //            Conn.Open();
        //            using (SqlCommand command = new SqlCommand("NSP_TTemp_Select_For_DropDown", Conn))
        //            {
        //                SqlParameter Param = new SqlParameter();
        //                command.CommandType = CommandType.StoredProcedure;

        //                Param = new SqlParameter();
        //                Param.ParameterName = "@Id";
        //                Param.SqlDbType = SqlDbType.Int;
        //                Param.Direction = ParameterDirection.Input;
        //                Param.Value = clsCommon.ToInt(Id);
        //                command.Parameters.Add(Param);

        //                Param = new SqlParameter();
        //                Param.ParameterName = "@SelectedAll";
        //                Param.SqlDbType = SqlDbType.Int;
        //                Param.Direction = ParameterDirection.Input;
        //                Param.Value = SelectedAll;
        //                command.Parameters.Add(Param);

        //                SqlDataReader SQLReader = command.ExecuteReader();
        //                result.Load(SQLReader);
        //                SQLReader.Close();
        //                SQLReader = null;
        //            }
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        clsLogger.ErrorLog(fstrPageName, ex);
        //    }
        //    return result;
        //}

        public static bool Delete_Custom_001(int Id)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_Delete_Custom_001", Conn))
                    {
                        SqlParameter Param = new SqlParameter();
                        command.CommandType = CommandType.StoredProcedure;

                        Param = new SqlParameter();
                        Param.ParameterName = "@Id";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(Id);
                        command.Parameters.Add(Param);

                        command.ExecuteNonQuery();
                        command.Dispose();
                    }
                    return true;
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
                return false;
            }
        }

        public static bool Insert_Custom_001(clsTTemp obj)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_Insert_Custom_001", Conn))
                    {
                        SqlParameter Param = new SqlParameter();
                        command.CommandType = CommandType.StoredProcedure;

                        Param = new SqlParameter();
                        Param.ParameterName = "@Title";
                        Param.SqlDbType = SqlDbType.NVarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Title);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Quantity";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(obj.Quantity);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Price";
                        Param.SqlDbType = SqlDbType.Decimal;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToDbl(obj.Price);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Category";
                        Param.SqlDbType = SqlDbType.VarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Category);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@MetaData";
                        Param.SqlDbType = SqlDbType.NVarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.MetaData);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Created_By";
                        Param.SqlDbType = SqlDbType.VarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Created_By);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Created_At";
                        Param.SqlDbType = SqlDbType.DateTime;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToDateTime(obj.Created_At).ToString(clsConst.constDate_SQLDateFmt);
                        command.Parameters.Add(Param);

                        command.ExecuteNonQuery();
                        command.Dispose();
                    }

                    return true;
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
                return false;
            }
        }

        public static bool Update_Custom_001(clsTTemp obj)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_Update_Custom_001", Conn))
                    {
                        SqlParameter Param = new SqlParameter();
                        command.CommandType = CommandType.StoredProcedure;

                        Param = new SqlParameter();
                        Param.ParameterName = "@Id";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(obj.Id);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Title";
                        Param.SqlDbType = SqlDbType.NVarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Title);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Quantity";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(obj.Quantity);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Price";
                        Param.SqlDbType = SqlDbType.Decimal;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToDbl(obj.Price);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Category";
                        Param.SqlDbType = SqlDbType.VarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Category);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@MetaData";
                        Param.SqlDbType = SqlDbType.NVarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.MetaData);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Created_By";
                        Param.SqlDbType = SqlDbType.VarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Created_By);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@Created_At";
                        Param.SqlDbType = SqlDbType.DateTime;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToDateTime(obj.Created_At).ToString(clsConst.constDate_SQLDateFmt);
                        command.Parameters.Add(Param);

                        command.ExecuteNonQuery();
                        command.Dispose();
                    }

                    return true;
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
                return false;
            }
        }
    }
}