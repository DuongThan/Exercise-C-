using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    public class Food
    {
        private string tenThucAn;
        private double giaThucAn;

        public double GiaThucAn
        {
            get
            {
                return giaThucAn;
            }

            set
            {
                giaThucAn = value;
            }
        }

        public string TenThucAn
        {
            get
            {
                return tenThucAn;
            }

            set
            {
                tenThucAn = value;
            }
        }
    }
}
