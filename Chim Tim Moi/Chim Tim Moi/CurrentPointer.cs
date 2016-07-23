using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chim_Tim_Moi
{
    class CurrentPointer
    {
        private Point currentpointer;

        internal Point Currentpointer
        {
            get { return currentpointer; }
            set { currentpointer = value; }
        }
        public CurrentPointer(Point point)
        {
            currentpointer = new Point(point);
        }

        public void SetCursorPostionPointer()
        {
            Console.SetCursorPosition(currentpointer.X, currentpointer.Y);
        }

    }
}
