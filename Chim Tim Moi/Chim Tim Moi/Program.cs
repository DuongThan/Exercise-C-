using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Chim_Tim_Moi
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            app.RunGame();
            Console.SetCursorPosition(32, 14);
            Console.Write("                        ");
            Console.SetCursorPosition(32, 14);
            Console.Write("Yours Point : "+app.Point_Game1);
            Console.ReadLine();
        }
    }
}
