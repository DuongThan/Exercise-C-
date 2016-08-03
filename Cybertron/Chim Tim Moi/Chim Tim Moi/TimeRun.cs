using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chim_Tim_Moi
{
    class TimeRun
    {
        private DateTime oldTime;

        public DateTime OldTime
        {
            get { return oldTime; }
            set { oldTime = value; }
        }
        private DateTime newTime;

        public DateTime NewTime
        {
            get { return newTime; }
            set { newTime = value; }
        }

        private TimeSpan currentTime;

        public TimeSpan CurrentTime
        {
            get { return currentTime; }
            set { currentTime = value; }
        }

        private int Time_end;

        public int Time_end1
        {
            get { return Time_end; }
            set { Time_end = value; }
        }

        public TimeRun()
        {
            oldTime = DateTime.Now;
            Time_end = 15;
        }

        public void ShowTime()
        {
            newTime = DateTime.Now;
            currentTime = newTime - oldTime;
            Console.SetCursorPosition(60, 5);
            int time =currentTime.Seconds;
            Console.Write("Time : " + (Time_end -time ));
            Console.Write(" ");

        }
        public bool GetTime()
        {
            newTime = DateTime.Now;
            currentTime = newTime - oldTime;
            if (currentTime.Seconds>= Time_end) 
            {
                return true;
            }

            return false;
        }
    }
}
