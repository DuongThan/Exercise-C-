using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien_Form
{
    public class QuanLy
    {
        private List<SinhVien> list_SinhVien;

        public List<SinhVien> List_SinhVien
        {
            get
            {
                return list_SinhVien;
            }

            set
            {
                list_SinhVien = value;
            }
        }

        public QuanLy()
        {
            list_SinhVien = new List<SinhVien>();
        }

        public void ThemMoi(SinhVien sv)
        {
        }
    }
}
