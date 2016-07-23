using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlapyBird
{
    class Core
    {
        private int CORE;

        public int CORE1
        {
            get { return CORE; }
            set { CORE = value; }
        }

        public Core()
        {
            this.CORE = 0;
        }

        public int GhiDiem(List<OngNuoc> list_ongNuoc, Bird bird)
        {
            foreach (OngNuoc item in list_ongNuoc)
            {
                foreach (Point item2 in item.List_toadoOn)
                {
                    if ((bird.CurrentBird1.X != item2.X) || (bird.CurrentBird1.Y != item2.Y))
                    {
                    }
                    else return 0;
                }

            }
            return 1;
        }

        public void ShowCore()
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(CORE);
        }
    }
    
}
