using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class HinhVuong:Point
    {
        private Point minPoint;
        private Point maxPoint;

        internal Point MaxPoint
        {
            get
            {
                return maxPoint;
            }

            set
            {
                maxPoint = value;
            }
        }

        internal Point MinPoint
        {
            get
            {
                return minPoint;
            }

            set
            {
                minPoint = value;
            }
        }

        public HinhVuong()
        {
            minPoint = new Point();
            maxPoint = new Point();
        }
        public HinhVuong(Point min,Point max)
        {
            minPoint = new Point();
            maxPoint = new Point();
            minPoint = min;
            maxPoint = max;
        }

        public override void Show()
        {
            Console.Write("Day la lop hinh vuong");
        }

        public void Paint()
        {
            int i, j;
            for (i = minPoint.TungDo; i < maxPoint.TungDo; i++) 
            {
                for (j = minPoint.HoanhDo; j < maxPoint.HoanhDo; j++)
                {
                    Console.SetCursorPosition(j+10, i);
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
