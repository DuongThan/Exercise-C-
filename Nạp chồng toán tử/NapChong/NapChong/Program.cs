using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NapChong
{
    class Program
    {
        static void Main(string[] args)
        {
            Phanso p = new Phanso();
            Phanso p1 = new Phanso(1,2);
            Phanso p2 = new Phanso(3,4);
            p1.Show();
            p2.Show();
            p = p1 + p2;
            p.Show();
            Console.ReadLine();
        }
    }
}
