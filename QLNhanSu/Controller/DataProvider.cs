using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    class DataProvider
    {
        private static DataProvider _instance;
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DataProvider();
                return _instance;
            }
        }

        public static string connectionString = @"Data Source=KIEN_HIP;Initial Catalog=QuanLyLichTiemChung;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }
        public static void open()
        {
            try
            {
                if (GetConnection().State == ConnectionState.Closed)
                {
                    GetConnection().Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        public static void close()
        {
            try
            {
                if (GetConnection().State == ConnectionState.Open)
                {
                    GetConnection().Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        public static string ExecuteScalar(string strQuery, CommandType cmdType)
        {
            SqlConnection conn = new SqlConnection();
            conn = GetConnection();
            conn.Open();
            string result = "";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = strQuery;
            try
            {

                result = cmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return result;
        }
        public static string ExecuteScalar(string strQuery, CommandType cmdType, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = GetConnection();
            conn.Open();
            string result = "";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = strQuery;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.Value = values[i];
                cmd.Parameters.Add(sqlpara);
            }
            try
            {

                result = cmd.ExecuteScalar().ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return result;
        }
        public static DataTable GetDataTable(string strQuery, CommandType cmdType, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = GetConnection();
            conn.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = strQuery;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.Value = values[i];
                cmd.Parameters.Add(sqlpara);
            }
            try
            {
                SqlDataAdapter sqlada = new SqlDataAdapter(cmd);
                sqlada.Fill(ds);
                sqlada.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return ds.Tables[0];
        }
        public static DataSet GetDataTable(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, GetConnection());
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            return ds;
        }
        public static DataTable GetDataTable(string strQuery, CommandType cmdtype)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection();
                con = GetConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdtype;
                cmd.Connection = con;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds.Tables[0];
        }
        public static bool ExecuteNonQuery(string strQuery, CommandType cmdType, string[] para, object[] values)
        {
            SqlConnection conn = new SqlConnection();
            conn = GetConnection();
            conn.Open();
            int count = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = cmdType;
            cmd.CommandText = strQuery;

            SqlParameter sqlpara;
            for (int i = 0; i < para.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = para[i];
                sqlpara.Value = values[i];
                cmd.Parameters.Add(sqlpara);
            }
            try
            {
                count = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return count > 0;
        }
    }
}
