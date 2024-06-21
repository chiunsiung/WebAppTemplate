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

        public static DataTable TTemp_SelectAll()
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


        public static DataTable SalesToday()
        {
            DataTable result = null;

            try
            {
                result = new DataTable();

                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_SalesToday", Conn))
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

        public static DataTable SalesLastWeek()
        {
            DataTable result = null;

            try
            {
                result = new DataTable();

                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_SalesLastWeek", Conn))
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

        public static DataTable SalesLastMonth()
        {
            DataTable result = null;

            try
            {
                result = new DataTable();

                using (SqlConnection Conn = new SqlConnection(clsConst.SysDBConnString()))
                {
                    Conn.Open();
                    using (SqlCommand command = new SqlCommand("NSP_SalesLastMonth", Conn))
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
