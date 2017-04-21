using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TTN_QLBH_Entity;

namespace TTN_QLBH_SQL
{
  public  class SQL_tblHangHoa
    {

        KetNoiDB cn = new KetNoiDB();
        // hàm thêm Dữ liệu
        public void ThemDuLieu(EC_tblHangHoa et)
        {
            cn.ThucThiCauLenhSQL(@"INSERT INTO HangHoa(ma, hoadonma, tenhang, soluong,ngaysx , hansd , noisx) value (N'" + et.Ma + "', N'" + et.Hoadonma + "', N'" + et.Tenhang + "', N'" + et.Soluong + "', N'" + et.Ngaysx + "', N'" + et.Hansd + "',N'" + et.Noisx + "')");
        }
        //hàm sửa

        public void SuaDuLieu(EC_tblHangHoa et)

        {
            cn.ThucThiCauLenhSQL(@"UPDATE HangHoa SET N'" + et.Ma + "', N'" + et.Hoadonma + "', N'" + et.Tenhang + "', N'" + et.Soluong + "', N'" + et.Ngaysx + "', N'" + et.Hansd + "',N'" + et.Noisx + "'   where Ma=N'" + et.Ma + "' ");
        }
        // hàm xóa
        public void XoaDuLieu(EC_tblHangHoa et)
        {
            cn.ThucThiCauLenhSQL(@"DELETE from bomon where Ma=N'" + et.Ma + "' ");
        }

        //hàm lấy dữ liệu
        //TaoBang("Where ma='1'")Select * from BoMon where 
        public DataTable TaoBang(string DieuKien)
        {
            return cn.GetDataTable("Select * from BoMon " + DieuKien);

        }
    }
}
