using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    public class Cho:Animal
    {
        public Cho()
        {
            Name = Constant.NAME_CHO;
            ThucAn = new Xuong();
            LuongTieuThu = Constant.XUONG_LUONGTIEUTHU;
        }
    }
}
