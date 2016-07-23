using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    public class Cho:Animal
    {
        public Cho()
        {
            Name = Constant.DOG_NAME;
            SoLuongTieuThu = Constant.DOG_LUONGTIEUTHU;
            ThucAn = new Thit();
        }
    }
}
