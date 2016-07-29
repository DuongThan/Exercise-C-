using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point
    {
        private int tungDo;
        private int hoanhDo;

        public int HoanhDo
        {
            get
            {
                return hoanhDo;
            }

            set
            {
                hoanhDo = value;
            }
        }

        public int TungDo
        {
            get
            {
                return tungDo;
            }

            set
            {
                tungDo = value;
            }
        }

        public Point(int x,int y)
        {
            tungDo = x;
            hoanhDo = y;
        }

        public Point()
        {
            tungDo = 0;
            hoanhDo = 0;
        }
        public Point(Point point)
        {
            tungDo = point.tungDo;
            hoanhDo = point.hoanhDo;
        }

        public virtual void Show()
        {
            Console.Write("Day la lop Point");
        }

    }
}
