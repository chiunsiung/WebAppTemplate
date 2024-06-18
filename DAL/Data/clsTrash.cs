using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class clsTrash
    {
        public static string fstrPageName = "clsTrash";

        public static DataTable TTemp_SelectAll() {
            DataTable result = null;
        
            try
            {
                result = new DataTable();
        
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TTemp_SelectAll", Conn))
                    {
                        SqlParameter Param = null;
                        command.CommandType = CommandType.StoredProcedure;

                        Param = new SqlParameter();
                        Param.ParameterName = "Id";
                        Param.SqlDbType = SqlDbType.Int;
                        Param.Direction = ParameterDirection.Input;
                        Param.Value = -1;
                        command.Parameters.Add(Param);
        
                        SqlDataReader SQLReader = command.ExecuteReader();
                        result.Load(SQLReader);
                        SQLReader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static DataTable TMachine_StatusData() {
            DataTable result = null;
        
            try
            {
                result = new DataTable();
        
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TMachine_StatusData", Conn))
                    {
                        SqlParameter Param = null;
                        command.CommandType = CommandType.StoredProcedure;
        
                        SqlDataReader SQLReader = command.ExecuteReader();
                        result.Load(SQLReader);
                        SQLReader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static DataTable TOrderTransaction_TdySales() {
            DataTable result = null;
        
            try
            {
                result = new DataTable();
        
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TOrderTransaction_TdySales", Conn))
                    {
                        SqlParameter Param = null;
                        command.CommandType = CommandType.StoredProcedure;
        
                        SqlDataReader SQLReader = command.ExecuteReader();
                        result.Load(SQLReader);
                        SQLReader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }
        
        public static DataTable TOrderTransaction_YtdSales() {
            DataTable result = null;
        
            try
            {
                result = new DataTable();
        
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("TOrderTransaction_YtdSales", Conn))
                    {
                        SqlParameter Param = null;
                        command.CommandType = CommandType.StoredProcedure;
        
                        SqlDataReader SQLReader = command.ExecuteReader();
                        result.Load(SQLReader);
                        SQLReader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }

        public static DataTable TOrderTransaction_MthSales() {
            DataTable result = null;
        
            try
            {
                result = new DataTable();
        
                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_TOrderTransaction_MthSales", Conn))
                    {
                        SqlParameter Param = null;
                        command.CommandType = CommandType.StoredProcedure;
        
                        SqlDataReader SQLReader = command.ExecuteReader();
                        result.Load(SQLReader);
                        SQLReader.Close();
                    }
                }
            }
            catch (SqlException ex)
            {
                clsLogger.ErrorLog(fstrPageName, ex);
            }
            return result;
        }
    }
}
