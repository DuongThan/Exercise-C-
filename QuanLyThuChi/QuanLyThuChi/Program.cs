using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuChi
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
                AppQLThuChi();
            
        }
        static void AppQLThuChi()
        {
            QLThuChi app = new QLThuChi(100000);
            while(true)
            {
                Console.Clear();
                app.ShowMenu();
                app.UserCommand();
                Console.ReadLine();
            }

        }
    }
}
