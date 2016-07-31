using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            Khung khung_ = new Khung();
            khung_.Show();
            while(true)
            {
                Thread.Sleep(10);
                app.ShowApp();
                Thread.Sleep(1000);
                app.Moi_.XoaMoi();
                app.Moi_ = new Moi();
            }
        }
    }
}
