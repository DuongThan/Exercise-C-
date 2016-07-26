using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    class Program
    {
        static void Main(string[] args)
        {
            QuanLyTrangTrai quanLy = new QuanLyTrangTrai();
            while(true)
            {
                quanLy.MenuMain();
                Console.ReadLine();
            }
        }
    }
}
