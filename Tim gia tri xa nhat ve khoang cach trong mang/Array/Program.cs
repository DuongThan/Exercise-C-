using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                Search_Array sa = new Search_Array();
                Console.Clear();
                sa.ShowList(sa.ListArray1);
                Console.Write(" Nhap gia tri can xac dinh : ");
                string temp = Console.ReadLine();
                int gt;
                if (!int.TryParse(temp, out gt))
                {
                    Console.Clear();
                    Console.WriteLine(" Nhap sai gia tri ");
                }
                sa.KetLuan(gt);
                Console.ReadLine();
            }
        }
    }
}
