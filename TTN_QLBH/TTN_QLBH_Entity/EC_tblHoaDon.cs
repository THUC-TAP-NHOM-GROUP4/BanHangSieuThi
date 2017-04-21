using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QLBH_Entity
{
   public class EC_tblHoaDon
    {
        private string _ma;
        public string Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }
        private string _khma;
        public string Khma
        {
            get { return _khma; }
            set { _khma = value; }
        }
        private float _tongtientt;
        public float Tongtientt
        {
            get { return _tongtientt; }
            set { _tongtientt = value; }
        }
        private string _nvma;
        public string Nvma
        {
            get { return _nvma; }
            set { _nvma = value; }
        }
        private DateTime _ngaytt;
        public DateTime Ngaytt
        {
            get { return _ngaytt; }
            set { _ngaytt = value; }
        }
    }
}
