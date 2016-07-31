using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Diem
    {
        private int x;
        private int y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public Diem()
        {
            x = 0;
            y = 0;
        }

        public Diem(int _x,int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Diem(Diem d)
        {
            x = d.x;
            y = d.y;
        }

        public virtual void Show()
        {

        }
    }
}
