using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyinfo = Console.ReadKey();
                    if (keyinfo.Key == ConsoleKey.Enter) 
                    Console.WriteLine();
                }
            }
            //DateTime dt;
            //dt = DateTime.Now;
            //Console.Write(dt.TimeOfDay);
            //Console.ReadLine();
        }
    }
}
