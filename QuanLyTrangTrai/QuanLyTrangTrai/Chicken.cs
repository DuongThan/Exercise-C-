using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    public class Chicken:Animal
    {
        public Chicken()
        {
            Name = Constant.CHICKEN_NAME;
            SoLuongTieuThu = Constant.CHICKEN_LUONGTIEUTHU;
            ThucAn = new Bap();
        }
    }
}
