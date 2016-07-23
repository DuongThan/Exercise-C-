using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeThua
{
    class Program
    {
        static void Main(string[] args)
        {
            People s = new Student();
            People t = new Teacher();
            s.Info();
            t.Info();
            Console.ReadLine();
        }
    }
}
