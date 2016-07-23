using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai
{
    public class Heo:Animal
    {
        public Heo()
        {
            Name = Constant.PIG_NAME;
            SoLuongTieuThu = Constant.PIG_LUONGTIEUTHU;
            ThucAn = new Cam();
        }
    }
}
