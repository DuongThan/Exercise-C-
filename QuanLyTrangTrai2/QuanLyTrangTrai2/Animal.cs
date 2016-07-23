using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    public class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private Food thucAn;

        public Food ThucAn
        {
            get { return thucAn; }
            set { thucAn = value; }
        }
        private int luongTieuThu;

        public int LuongTieuThu
        {
            get { return luongTieuThu; }
            set { luongTieuThu = value; }
        }
    }
}
