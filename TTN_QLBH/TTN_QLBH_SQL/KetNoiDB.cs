using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TTN_QLBH_SQL
{
   public class KetNoiDB
    {
        public static SqlConnection connect;

        // Mở kết nối 
        public static void MoKetNoi()
        {
            if (KetNoiDB.connect == null)
                KetNoiDB.connect = new SqlConnection(@"Data Source=ADMINISTRATOR;Initial Catalog=ThucTapCSDL;Integrated Security=True");
            if (KetNoiDB.connect.State != ConnectionState.Open)
                KetNoiDB.connect.Open();
        }

        // Đóng kết nối
        public void DongKetNoi()//bỏ static
        {
            if (KetNoiDB.connect != null)
            {
                if (KetNoiDB.connect.State == ConnectionState.Open)
                {
                    KetNoiDB.connect.Close();
                }
            }
        }

        // Hàm để thực thi các câu lệnh sql : insert, update, delete 
        public void ThucThiCauLenhSQL(string strSQL)
        {
            try
            {
                MoKetNoi();
                SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
                sqlcmd.ExecuteNonQuery(); // không trả về gì hết
                DongKetNoi();
            }
            catch
            {

            }
            //   DongKetNoi();//bỏ--nga
        }

        // Hàm khi gọi tới câu lệnh select sẽ trả về 1 data table
        public DataTable GetDataTable(string strSQL)  // truyền vào câu lệnh select
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

        // 
        public string GetValue(string strSQL) //select
        {
            string temp = null;
            MoKetNoi();
            SqlCommand sqlcmd = new SqlCommand(strSQL, connect);
            // sqlcmd cho ta 1 table, hàm có tác dụng khi ta select 1 cái đơn trị
            // 0,1,2,3.. là chỉ số của các trường.
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            while (sqldr.Read())
                temp = sqldr[0].ToString(); // 0 là chỉ số, trường thứ 0
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
