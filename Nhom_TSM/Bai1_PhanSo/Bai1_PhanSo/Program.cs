using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_PhanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            ThucHien ql = new ThucHien();
            PhanSo ps1 = new PhanSo();
            ql.Nhap(ps1);
            PhanSo ps2 = new PhanSo();
            ql.Nhap(ps2);
            Console.WriteLine("Phan so 1 : ");
            ql.HienThi(ps1);
            Console.WriteLine("Phan so 2 : ");
            ql.HienThi(ps2);
            PhanSo ps3 = new PhanSo();
            ps3 = ql.Tong(ps1, ps2);
            Console.WriteLine("Tong 2 phan so : ");
            ql.HienThi(ps3);
            PhanSo ps4 = new PhanSo();
            Console.WriteLine("Tich 2 phan so : ");
            ps4 = ql.Tich(ps1, ps2);
            ql.HienThi(ps4);
            Console.ReadLine();

        }
    }
}
