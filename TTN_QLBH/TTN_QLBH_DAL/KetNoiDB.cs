using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TTN_QLBH_DAL
{
    public class KetNoiDB
    {
        public static SqlConnection connect;
        //mở kết nối
        public static void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection(@"Data Source=ADMINISTRATOR;Initial Catalog=ThucTapCSDL;Integrated Security=True");
            if (KetNoiDB.connect.State != ConnectionState.Open)
                KetNoiDB.connect.Open();
        }

        //đóng kết nối
        public void DongKetNoi()
        {
            if (KetNoiDB.connect != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                {
                    KetNoiDB.connect.Close();
                }
            }
        }

        //hàm để thưc thi các câu lệnh sql : insert , update , delete
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery();//ko trả về giá trị
                DongKetNoi();
            }
            catch
            { }
        }

        //hàm khi gọi tới câu lệnh select sẽ trả về 1 data table
        public DataTable GetDataTable(string strSQL)
        {
            try
            {
                MoKetNoi();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(strSQL, connect);
                sqlda.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }

        public string GetValue(string strSQL)
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString();
            DongKetNoi();
            return temp;
        }


        public DataTable StorePro(string sql)
        {
            try
            {
                MoKetNoi();
                SqlCommand cmd = new SqlCommand("timkiem", connect);
                SqlParameter p1 = new SqlParameter("", SqlDbType.NVarChar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ten", sql));
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                DongKetNoi();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public static string connectionString
        {
            get;
            set;
        }
    }
}