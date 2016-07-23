using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ChayChu
{
    class Program
    {
        static int huong = 0;
        static void Main(string[] args)
        {
            while(true)
            {
                Run("=======MENU=======");
            }
        }

       


        static void Run(string s)
        {
            for (int i = 0; i < 50;)
            {
                Thread.Sleep(100);
                Console.SetCursorPosition(i, 0);
                Console.Write(s);
                if (i == 49) huong = 1;
                if (i == 0) huong = 0;
                if (huong == 0)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write(" ");
                    i++;
                }
                else
                {
                    Console.Write(" ");
                    i--;
                }
            }
        }
            
    }
}
