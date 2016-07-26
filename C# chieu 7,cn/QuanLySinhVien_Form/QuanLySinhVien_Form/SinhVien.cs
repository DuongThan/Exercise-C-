using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_Form
{
    public class SinhVien
    {
        private string maSinhVien;
        private string hoTen;
        private string lop;
        private bool gioiTinh;
        private DateTime ngaySinh;
        private string diaChi;
        private int soDienThoai;

        public int SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        public string Lop
        {
            get
            {
                return lop;
            }

            set
            {
                lop = value;
            }
        }

        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        public string MaSinhVien
        {
            get
            {
                return maSinhVien;
            }

            set
            {
                maSinhVien = value;
            }
        }

        public SinhVien()
        {

        }

    }
}
