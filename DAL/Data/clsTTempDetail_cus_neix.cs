
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL
{
    public partial class clsTTempDetail
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
        //            using (SqlCommand command = new SqlCommand("NSP_TTempDetail_Select_For_DropDown", Conn))
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
                    using (SqlCommand command = new SqlCommand("NSP_TTempDetail_Delete_Custom_001", Conn))
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

        public static bool Insert_Custom_001(clsTTempDetail obj)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTempDetail_Insert_Custom_001", Conn))
                    {
                        SqlParameter Param = new SqlParameter();
                        command.CommandType = CommandType.StoredProcedure;

                        Param = new SqlParameter();
                        Param.ParameterName = "@Title";
                        Param.SqlDbType = SqlDbType.VarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Title);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@TempId";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(obj.TempId);
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

        public static bool Update_Custom_001(clsTTempDetail obj)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTempDetail_Update_Custom_001", Conn))
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
                        Param.SqlDbType = SqlDbType.VarChar;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToStr(obj.Title);
                        command.Parameters.Add(Param);

                        Param = new SqlParameter();
                        Param.ParameterName = "@TempId";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(obj.TempId);
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