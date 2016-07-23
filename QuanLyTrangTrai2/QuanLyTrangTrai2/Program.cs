using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();
            while(true)
            {
                menu.Main_Menu();
            }
        }
    }
}
