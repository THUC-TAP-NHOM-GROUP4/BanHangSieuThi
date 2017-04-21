using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QLBH_Entity
{
   public class EC_tblHangHoa
    {
        private string _ma;
        public string Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }
        private string _hoadonma;
        public string Hoadonma
        {
            get { return _hoadonma; }
            set { _hoadonma = value; }
        }
        private string _tenhang;
        public string Tenhang
        {
            get { return _tenhang; }
            set { _tenhang = value; }
        }
        private int _soluong;
        public int Soluong
        {
            get { return _soluong; }
            set { _soluong = value; }
        }
        private DateTime _ngaysx;
        public DateTime Ngaysx
        {
            get { return _ngaysx; }
            set { _ngaysx = value; }
        }
        private DateTime _hansd;
        public DateTime Hansd
        {
            get { return _hansd; }
            set { _hansd = value; }
        }
        private string _noisx;
        public string Noisx

        {
            get { return _noisx; }
            set { _noisx = value; }
        }
    }
}
