using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chim_Tim_Moi
{
    class Point
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }
        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }

        public Point(int x1,int y1)
        {
            this.x = x1;
            this.y = y1;
        }
    }
}
