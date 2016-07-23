using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrangTrai2
{
    public class Lon:Animal
    {
        public Lon()
        {
            Name = Constant.NAME_PIG;
            ThucAn = new Cam();
            LuongTieuThu = Constant.CAM_LUONGTIEUTHU;
        }
    }
}
