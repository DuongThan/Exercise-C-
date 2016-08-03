using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_WF
{
    class QuanLy
    {
        private List<SinhVien> list_SinhVien;
        private ConnectData con;

        internal List<SinhVien> List_SinhVien
        {
            get
            {
                return list_SinhVien;
            }

            set
            {
                list_SinhVien = value;
            }
        }

        public QuanLy()
        {
            list_SinhVien = new List<SinhVien>();
            con = new ConnectData();
        }

        public void Add(SinhVien sv)
        {
            list_SinhVien.Add(sv);
        }

        public void Remove(SinhVien sv)
        {
            List_SinhVien.Remove(sv);
        }

        public int Search(string maSV)
        {
            for (int i = 0; i < list_SinhVien.Count(); i++)
            {
                if (maSV == list_SinhVien[i].MaSV)
                    return i;
            }
            return -1;
        }
        public void ThemMoi(SinhVien sv)
        {
            string s = "insert into SinhVien(MaSV,HoTen,Khoa,Lop,GioiTinh,Email,DiaChi,GhiCHu,ThanhTich,NgaySinh,SoDT,DiemTB) values('" + sv.MaSV + "','" + sv.HoTen + "','" + sv.Khoa + "','" + sv.Lop + "','" + sv.GioiTinh + "','" + sv.Email + "','" + sv.DiaChi + "','" + sv.GhiChu + "','" + sv.ThanhTich + "','" + sv.NgaySinh + "','" + sv.SoDT + "','" + sv.DiemTB + "')";
            con.ExecuteSql(s);
        }

        public void Sua(SinhVien sv)
        {
            string s = "update SinhVien set HoTen='" + sv.HoTen + "',Khoa='" + sv.Khoa + "',Lop='" + sv.Lop + "',GioiTinh='" + sv.GioiTinh + "',Email='" + sv.Email + "',DiaChi='" + sv.DiaChi + "',GhiChu='" + sv.GhiChu + "',ThanhTich='" + sv.ThanhTich + "',SoDT='" + sv.SoDT + "',NgaySinh='" + sv.NgaySinh + "',DiemTB='" + sv.DiemTB + "' where MaSV='" + sv.MaSV + "' ";
            con.ExecuteSql(s);
        }

        public void Delete(string MaSV)
        {
            string s = "delete from SinhVien where MaSV = '" + MaSV+ "'";
            con.ExecuteSql(s);
        }
    }
}
