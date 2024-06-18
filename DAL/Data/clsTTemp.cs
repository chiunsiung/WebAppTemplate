
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DAL
{

    public partial class clsTTemp
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public string MetaData { get; set; }
        public string Created_By { get; set; }
        public string Created_At { get; set; }
    }

    public partial class clsTTemp
    {
        public static string fstrPageName = "clsTTemp";

        public static clsTTemp DtToObj(DataRow dr)
        {
            clsTTemp obj = new clsTTemp();
            try
            {
                obj.Id = clsCommon.ToInt(dr["Id"]);
                obj.Title = clsCommon.ToStr(dr["Title"]);
                obj.Quantity = clsCommon.ToInt(dr["Quantity"]);
                obj.Price = clsCommon.ToDbl(dr["Price"]);
                obj.Category = clsCommon.ToStr(dr["Category"]);
                obj.MetaData = clsCommon.ToStr(dr["MetaData"]);
                obj.Created_By = clsCommon.ToStr(dr["Created_By"]);
                obj.Created_At = clsCommon.ToDateTime(dr["Created_At"]).ToString(clsConst.constDate_SQLDateFmt);
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return obj;
        }

        public static DataTable GetAllDataTable(int Id)
        {
            DataTable result = null;

            try
            {
                result = new DataTable();

                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_SelectAll", Conn))
                    {
                        SqlParameter Param = new SqlParameter();
                        command.CommandType = CommandType.StoredProcedure;

                        Param = new SqlParameter();
                        Param.ParameterName = "@Id";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(Id);
                        command.Parameters.Add(Param);

                        SqlDataReader SQLReader = command.ExecuteReader();
                        result.Load(SQLReader);
                        SQLReader.Close();
                        SQLReader = null;
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static List<clsTTemp> GetAllList(int Id)
        {
            List<clsTTemp> result = new List<clsTTemp>();
            try
            {
                DataTable dt = new DataTable();
                dt = GetAllDataTable(Id);
                if (dt.Rows.Count == 0)
                {
                    result = null;
                }
                else
                {
                    for (int ind = 0; ind <= dt.Rows.Count - 1; ind++)
                    {
                        clsTTemp obj = DtToObj(dt.Rows[ind]);
                        result.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                result = null;
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static List<clsTTemp> GetListByPK(int Id)
        {
            List<clsTTemp> result = new List<clsTTemp>();
            try
            {
                DataTable dt = new DataTable();
                dt = GetDataTableByPK(Id);
                if (dt.Rows.Count == 0)
                {
                    result = null;
                }
                else
                {
                    for (int ind = 0; ind <= dt.Rows.Count - 1; ind++)
                    {
                        clsTTemp obj = DtToObj(dt.Rows[ind]);
                        result.Add(obj);
                    }
                }
            }
            catch (Exception ex)
            {
                result = null;
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static clsTTemp GetDataObjByPK(int Id)
        {
            List<clsTTemp> list = new List<clsTTemp>();
            try
            {
                list = GetListByPK(Id);
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
                return null;
            }
            if (list != null)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetDataTableByPK(int Id)
        {
            DataTable result = null;

            try
            {
                result = new DataTable();

                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_SelectByPK", Conn))
                    {
                        SqlParameter Param = new SqlParameter();
                        command.CommandType = CommandType.StoredProcedure;

                        Param = new SqlParameter();
                        Param.ParameterName = "@Id";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = clsCommon.ToInt(Id);
                        command.Parameters.Add(Param);

                        SqlDataReader SQLReader = command.ExecuteReader();
                        result.Load(SQLReader);
                        SQLReader.Close();
                        SQLReader = null;
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static bool Delete(int Id)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_Delete", Conn))
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

        public static bool Insert(clsTTemp obj)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_Insert", Conn))
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

        public static bool Update(clsTTemp obj)
        {
            try
            {
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_Update", Conn))
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

        public static int GetColumn_Id_ByPK(int Id)
        {
            int result = 0;
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.Id;
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static string GetColumn_Title_ByPK(int Id)
        {
            string result = "";
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.Title.Trim();
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static int GetColumn_Quantity_ByPK(int Id)
        {
            int result = 0;
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.Quantity;
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static double GetColumn_Price_ByPK(int Id)
        {
            double result = 0;
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.Price;
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static string GetColumn_Category_ByPK(int Id)
        {
            string result = "";
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.Category.Trim();
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static string GetColumn_MetaData_ByPK(int Id)
        {
            string result = "";
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.MetaData.Trim();
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static string GetColumn_Created_By_ByPK(int Id)
        {
            string result = "";
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.Created_By.Trim();
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static string GetColumn_Created_At_ByPK(int Id)
        {
            string result = "";
            try
            {
                clsTTemp obj = new clsTTemp();
                obj = GetDataObjByPK(Id);
                if (obj != null)
                {
                    result = obj.Created_At.Trim();
                }
                obj = null;
            }
            catch (Exception ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}