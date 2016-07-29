using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class HinhThoi:Point
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

        public HinhThoi()
        {
            minPoint = new Point();
            maxPoint = new Point();
        }

        public HinhThoi(Point min,Point max)
        {
            minPoint = min;
            maxPoint = max;
        }

        public override void Show()
        {
            Console.WriteLine("Day la lop hinh thoi");
        }
    }
}
