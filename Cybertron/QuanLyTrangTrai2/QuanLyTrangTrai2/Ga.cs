using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    public class Ga:Animal
    {
        public Ga()
        {
            Name = Constant.NAME_GA;
            ThucAn = new Thoc();
            LuongTieuThu = Constant.THOC_LUONGTIEUTHU;
        }
    }
}
