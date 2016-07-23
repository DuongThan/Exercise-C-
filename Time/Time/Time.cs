using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time
    {
        private DateTime oldtime;

        public DateTime Oldtime
        {
            get { return oldtime; }
            set { oldtime = value; }
        }
        private DateTime newtime;

        public DateTime Newtime
        {
            get { return newtime; }
            set { newtime = value; }
        }
        private TimeSpan curtime;

        public TimeSpan Curtime
        {
            get { return curtime; }
            set { curtime = value; }
        }
        public Time()
        {
            oldtime = DateTime.Now;
            newtime = DateTime.Now;
        }

        public void Tinhgio()
        {
            newtime = DateTime.Now;
            curtime = newtime - oldtime;
            Console.WriteLine("Khoang cach 2 thoi diem la : " + curtime);
        }
    }
}
