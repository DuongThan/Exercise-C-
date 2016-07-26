using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    class DongVat
    {
        private string name;
        private Food thucAn;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public Food ThucAn
        {
            get
            {
                return thucAn;
            }

            set
            {
                thucAn = value;
            }
        }
    }
}
