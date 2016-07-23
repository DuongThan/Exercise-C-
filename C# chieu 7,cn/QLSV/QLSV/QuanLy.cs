using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public class QuanLy
    {
        List<SinhVien> list_SinhVien;

        public List<SinhVien> List_SinhVien
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
        }

        public void Add(SinhVien sv)
        {
            list_SinhVien.Add(sv);
        }

        public void Remove(int k)
        {
            if (list_SinhVien.Count == 0) return;
            list_SinhVien.Remove(list_SinhVien[k-1]);
        }

        public void MenuSua(int k)
        {
            Console.WriteLine("1. Ma sinh vien : " +list_SinhVien[k].MaSV);
            Console.WriteLine("2. Ho Ten       : " + list_SinhVien[k].HoTen);
            Console.WriteLine("3. Lop          : " + list_SinhVien[k].Lop);
            Console.WriteLine("4. Ngay sinh    : " + list_SinhVien[k].NgaySinh);
            Console.WriteLine("5. Dia chi      : " + list_SinhVien[k].DiaChi);
            Console.WriteLine("6. So DT        : " + list_SinhVien[k].SoDT);
        }

        public void SuaMSV(int k)
        {
            Console.WriteLine(" Ma sinh vien : ");
            string MaSV = Console.ReadLine();
            list_SinhVien[k].MaSV = MaSV;
        }

        public void SuaHoTen(int k)
        {
            Console.WriteLine(" Ho Ten       : ");
            string hoTen = Console.ReadLine();
            list_SinhVien[k].HoTen = hoTen;
        }

        public void SuaLop(int k)
        {
            Console.WriteLine(" Lop          : ");
            string lop = Console.ReadLine();
            list_SinhVien[k].Lop = lop;

        }
        public void SuaNgaySinh(int k)
        {
            Console.WriteLine(" Ngay sinh    : ");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine());
        }
        public void SuaDiaChi(int k)
        {
            Console.WriteLine(" Dia chi      : ");
            string diaChi = Console.ReadLine();
            list_SinhVien[k].DiaChi = diaChi;

        }

        public void SuaSDT(int k)
        {
            int soDT = 0;
            Console.WriteLine(" So DT        : ");
            bool t = false;
            while (t == false)
            {
                string s = Console.ReadLine();
                if (int.TryParse(s, out soDT))
                {
                    soDT = int.Parse(s);
                    t = true;
                }
            }

            list_SinhVien[k].SoDT = soDT;

        }

        public void Sua(int k)
        {
            Console.Clear();
            k -= 1;
            MenuSua(k);
            Console.WriteLine("Ban muon sua thong tin nao ");
            string choose =Console.ReadLine();
            switch(choose)
            {
                case "1":
                    SuaMSV(k);
                    break;

                case "2":
                    SuaHoTen(k);
                    break;

                case "3":
                    SuaLop(k);
                    break;

                case "4":
                    SuaNgaySinh(k);
                    break;

                case "5":
                    SuaDiaChi(k);
                    break;

                case "6":
                    SuaSDT(k);
                    break;
            }
        }

        public void Show()
        {
            int i = 1;
            foreach(SinhVien temp in list_SinhVien)
            {
                Console.WriteLine();
                Console.WriteLine(" Thong tinh sinh vien thu  :" + i);
                i++;
                Console.WriteLine();
                ShowSV(temp);
            }
        }

        public int SoLuongSV()
        {
            return list_SinhVien.Count();
        }
        public void Nhap(ref SinhVien sv)
        {
            Console.WriteLine(" Ma sinh vien : ");
            sv.MaSV = Console.ReadLine();
            Console.WriteLine(" Ho Ten       : ");
            sv.HoTen = Console.ReadLine();
            Console.WriteLine(" Lop          : ");
            sv.Lop = Console.ReadLine();
            Console.WriteLine(" Ngay sinh    : ");
            DateTime dt;
            while (!DateTime.TryParse(Console.ReadLine(), out dt))
            {
                Console.WriteLine("Nhap ngay sinh duoi dang dd/mm/yy !");
            }
            sv.NgaySinh = dt;
            Console.WriteLine(" Dia chi      : ");
            sv.DiaChi = Console.ReadLine();
            Console.WriteLine(" So DT        : ");
            int sdt;
            while (!int.TryParse(Console.ReadLine(), out sdt ) || sdt <= 0)
            {
            }
            sv.SoDT = sdt;
        }

        public void ShowSV(SinhVien sv)
        {
            Console.WriteLine(" Ma sinh vien : " + sv.MaSV);
            Console.WriteLine(" Ho Ten       : " + sv.HoTen);
            Console.WriteLine(" Lop          : " + sv.Lop);
            Console.WriteLine(" Ngay sinh    : " + sv.NgaySinh);
            Console.WriteLine(" Dia chi      : " + sv.DiaChi);
            Console.WriteLine(" So DT        : " + sv.SoDT);
        }
    }
}
