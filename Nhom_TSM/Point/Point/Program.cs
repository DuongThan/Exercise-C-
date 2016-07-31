using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Point p;
            //    p = new HinhVuong();
            //    p.Show();
            //    p = new HinhThoi();
            //    p.Show();

            //    Point p1 = new Point(1, 1);
            //    Point p2 = new Point(5, 5);
            //    HinhVuong hv = new HinhVuong(p1, p2);
            //    //p.Show();
            //   // hv.Paint();

            Point point = new HinhVuong();
            point.Show();
            point = new HinhThoi();
            point.Show();

            Point p1 = new Point(1, 1);
            Point p2 = new Point(5, 5);
            HinhVuong hv = new HinhVuong(p1, p2);
            HinhThoi ht = new HinhThoi();
            hv.Show();
            ht.Show();


            Console.ReadLine();
        }
    }
}
