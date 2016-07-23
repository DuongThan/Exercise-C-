using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    class Program
    {
        static QuanLy ql = new QuanLy();
        static SinhVien sv;
        static void menuMain()
        {
            Console.WriteLine(" Chuong trinh quan li sinh vien ");
            Console.WriteLine(" 1. Them moi sinh vien");
            Console.WriteLine(" 2. Sua sinh vien");
            Console.WriteLine(" 3. Xoa sinh vien ");
            Console.WriteLine(" 4. Thong tin tat ca sinh vien");
        }

        static void ThemMoi()
        {
            Console.Clear();
            sv = new SinhVien();
            Console.WriteLine("Nhap thong tin sinh vien can them : ");
            ql.Nhap(ref sv);
            ql.Add(sv);
        }

        static void Sua()
        {
            if (ql.SoLuongSV() == 0)
            {
                Console.WriteLine("Danh sach sinh vien trong !");
                return;
            }
            Console.Clear();
            ThongTinSV();
            Console.WriteLine("Ban muon sua thong tin sinh vien thu may : ");
            int n=0;
            while (!int.TryParse(Console.ReadLine(), out n) || n<=0)
            {
            }
            if (n > ql.SoLuongSV()) return;
            ql.Sua(n);
        }

        static void ThongTinSV()
        {
            if (ql.SoLuongSV() == 0)
            {
                Console.WriteLine("Danh sach sinh vien trong !");
                return;
            }
            Console.Clear();
            ql.Show();
        }

        static void Xoa()
        {
            if (ql.SoLuongSV() == 0)
            {
                Console.WriteLine("Danh sach sinh vien trong !");
                return;
            }
            Console.Clear();
            ThongTinSV();
            Console.WriteLine("Ban muon Xoa thong tin sinh vien thu may : ");
            int n = 0;
            while (!int.TryParse(Console.ReadLine(), out n) || n<=0)
            {
            }
            if (n > ql.SoLuongSV()) return;
            ql.Remove(n);
        }
        static void Main(string[] args)
        {
            string s;
            while(true)
            {
                Console.Clear();
                menuMain();
                Console.WriteLine(" Choose : ");
                s = Console.ReadLine(); 
                switch(s)
                {
                    case "1":
                        ThemMoi();
                        break;

                    case "2":
                        Sua();
                        break;

                    case "3":
                        Xoa();
                        break;

                    case "4":
                        ThongTinSV();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
