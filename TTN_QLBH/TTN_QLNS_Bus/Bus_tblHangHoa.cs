using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TTN_QLBH_Entity;
using TTN_QLBH_SQL;

namespace TTN_QLNS_Bus
{
  public class Bus_tblHangHoa
    {

        SQL_tblHangHoa sql = new SQL_tblHangHoa();

        //hàm thêm dữ liệu
        public void ThemDuLieu(EC_tblHangHoa et)

        {
            sql.ThemDuLieu(et);

        }
        //hàm sửa
        public void SuaDuLieu(EC_tblHangHoa et)

        {
            sql.SuaDuLieu(et);
        }

        //hàm xóa 
        public void XoaDuLieu(EC_tblHangHoa et)
        {
            sql.XoaDuLieu(et);
        }
        public DataTable TaoBang(string DieuKien)
        {
            return sql.TaoBang(DieuKien);
        }
    }
}
