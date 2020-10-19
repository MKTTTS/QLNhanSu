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
    public class DataProvider
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

        public static string connectionString = @"Data Source=DESKTOP-DO7Q21E\SQLEXPRESS;Initial Catalog=QuanLyNhanSu;Integrated Security=True";
        public static SqlConnection conn;

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            return conn;
        }

        public void ExcuteNonQuery(string sql)
        {
            throw new NotImplementedException();
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
        public DataTable getTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = GetConnection();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connec = new SqlConnection(connectionString))
            {
                connec.Open();
                SqlCommand command = new SqlCommand(query, connec);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connec.Close();
            }
            return data;
        }

                                                  //Phong ban//
        public static DataTable getAllPhongBan()
        {
            string sql = "select *from PHONGBAN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable getPhongBan(string a)
        {

            string sql = "select " + a + " from PHONGBAN";
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            return dt;
        }
        public static DataTable getTenPhongBan(string tenpb)
        {


            string sql = "select n.MaNV as N'Mã nhân viên', HoTen as N'Họ tên', LuongCB as N'Lương', LuongThuong as N'Thưởng', GhiChu as N'Ghi chú', TenPB as N'Tên phòng ban' from PHONGBAN p, NHANVIEN n, LUONG l where l.MaNV=n.MaNV and p.MaPB=n.MaPB and TenPB=@tenpb ";

            DataTable dt = new DataTable();
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@tenpb", tenpb));

                SqlDataAdapter da = new SqlDataAdapter(command);
                da.Fill(dt);


            }
            return dt;
        }

        public static DataTable timKiemPhongBan(string pb)
        {
            string sql = "select * from PHONGBAN p where ((TenPB like '%' + @text + '%') or(DiaChi like '%' + @text + '%') or(MaPB like '%' + @text + '%') or(TenTP like '%' + @text + '%') or(MaTP like '%' + @text + '%'))";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("text", pb);
            cmd.ExecuteNonQuery();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable sttable = new DataTable();
            adapter.Fill(sttable);
            return sttable;
        }



        public static int checkPhongBan(string mapb)
        {

            string sql = "select * from PHONGBAN p where ((TenPB like '%' + @text + '%') or(DiaChi like '%' + @text + '%') or(MaPB like '%' + @text + '%') or(TenTP like '%' + @text + '%') or(MaTP like '%' + @text + '%'))";
            using (SqlCommand command = new SqlCommand(sql, conn))
            {
                command.Parameters.Add(new SqlParameter("@text", mapb));
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    if (dataReader.Read() == true)
                    {
                        return 1;
                    }



                }
            }
            return 0;
        }

    }
}
