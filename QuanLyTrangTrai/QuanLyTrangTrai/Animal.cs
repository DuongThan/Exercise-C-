using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
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

        internal Food ThucAn
        {
            get { return thucAn; }
            set { thucAn = value; }
        }
        private double soLuongTieuThu;

        public double SoLuongTieuThu
        {
            get { return soLuongTieuThu; }
            set { soLuongTieuThu = value; }
        }
    }
}
