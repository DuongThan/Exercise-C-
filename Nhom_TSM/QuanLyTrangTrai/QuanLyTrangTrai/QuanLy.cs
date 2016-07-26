using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    class QuanLy
    {
        private List<DongVat> list_DongVat;

        internal List<DongVat> List_DongVat
        {
            get
            {
                return list_DongVat;
            }

            set
            {
                list_DongVat = value;
            }
        }

        public QuanLy()
        {
            list_DongVat = new List<DongVat>();
        }

    }
}
