using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Bird:Diem
    {
        private Diem dau_Bird;
        private int dai;
        private int rong;

        internal Diem Dau_Bird
        {
            get
            {
                return dau_Bird;
            }

            set
            {
                dau_Bird = value;
            }
        }

        public int Rong
        {
            get
            {
                return rong;
            }

            set
            {
                rong = value;
            }
        }

        public int Dai
        {
            get
            {
                return dai;
            }

            set
            {
                dai = value;
            }
        }


        public Bird()
        {
            dau_Bird = new Diem();
            dai = 3;
            rong = 3;
        }

        public Bird(Diem dau)
        {
            dau_Bird = new Diem(dau);
            dai = 3;
            rong = 3;
        }

        public override void Show()
        {
            int i, j;
            for (i = 0; i < rong; i++)
            {
                for (j = 0; j < dai; j++)
                {
                    Console.SetCursorPosition(i+dau_Bird.X, j+dau_Bird.Y);
                    Console.Write("=");
                }
            }
        }

        public void Delete()
        {
            int i, j;
            for (i = 0; i < rong; i++)
            {
                for (j = 0; j < dai; j++)
                {
                    Console.SetCursorPosition(i + dau_Bird.X, j + dau_Bird.Y);
                    Console.Write(" ");
                }
            }
        }


    }
}
