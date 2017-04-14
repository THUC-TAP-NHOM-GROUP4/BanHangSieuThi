using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTN_QLBH_Entity
{
   public  class EC_tblNhanVien
    {
        private string _ma;
        private string _ten;
        private bool _gioitinh;
        private DateTime _ngaysinh;
        private int _sdt;
        private float _luong;
        private string _phongban;
        private string _diachi;
        private string _matkhau;

        public string Ma
        {
            get
            {
                return _ma;
            }

            set
            {
                _ma = value;
            }
        }

        public string Ten
        {
            get
            {
                return _ten;
            }

            set
            {
                _ten = value;
            }
        }

        public bool Gioitinh
        {
            get
            {
                return _gioitinh;
            }

            set
            {
                _gioitinh = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return _ngaysinh;
            }

            set
            {
                _ngaysinh = value;
            }
        }

        public int Sdt
        {
            get
            {
                return _sdt;
            }

            set
            {
                _sdt = value;
            }
        }

        public float Luong
        {
            get
            {
                return _luong;
            }

            set
            {
                _luong = value;
            }
        }

        public string Phongban
        {
            get
            {
                return _phongban;
            }

            set
            {
                _phongban = value;
            }
        }

        public string Diachi
        {
            get
            {
                return _diachi;
            }

            set
            {
                _diachi = value;
            }
        }

        public string Matkhau
        {
            get
            {
                return _matkhau;
            }

            set
            {
                _matkhau = value;
            }
        }
    }
}
