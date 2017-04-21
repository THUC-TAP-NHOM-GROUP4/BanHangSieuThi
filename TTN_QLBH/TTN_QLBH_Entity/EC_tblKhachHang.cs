using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QLBH_Entity
{
  public class EC_tblKhachHang
    {
        private string _ma;
        public string Ma
        {
            get { return _ma; }
            set { _ma = value; }
        }
        private string _ten;
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        private bool _gioitinh;
        public bool Gioitinh
        {
            get { return _gioitinh; }
            set { _gioitinh = value; }
        }
        private string _diachi;
        public string Diachi
        {
            get { return _diachi; }
            set { _diachi = value; }
        }
        private int _sdt;
        public int Sdt
        {
            get { return _sdt; }
            set { _sdt = value; }
        }
        private int _cmnd;
        public int Cmnd
        {
            get { return _cmnd; }
            set { _cmnd = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
