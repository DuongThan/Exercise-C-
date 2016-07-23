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
            FarmingController quanli = new FarmingController();
            while(true)
            {
                quanli.MainMenu();
            }
        }
    }
}
