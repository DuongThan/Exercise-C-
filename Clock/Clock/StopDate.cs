using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class StopDate
    {
        private DateTime oldTime;
        private DateTime newTime;
        private TimeSpan currentTime;
        private TimeSpan distanceTime;
        private bool isResume;

        public StopDate()
        {
            oldTime = DateTime.Now;
            newTime = DateTime.Now;
            isResume = true;
            distanceTime = newTime - oldTime;
        }

        public void Start()
        {
            oldTime = DateTime.Now;
            distanceTime = DateTime.Now - DateTime.Now;
            isResume = true;
        }

        public void Resume()
        {
            isResume = !isResume;
            /*
             Khi tạm dừng thời gian hiện hành vẫn tiếp tục chạy vì vậy khi Resume = true 
             thì currentTime tăng 1 khoảng từ timePause đến datatime.now.
             
             Để currentTime tăng như đồng hồ bấm giờ thì ta phải trừ đi 1 khoảng cách tăng tính từ Pause đến Now khi ấn Pause.
             */
            if(isResume)
            {
                newTime = DateTime.Now;
                distanceTime = newTime - oldTime - currentTime;
                return;
            }
            distanceTime = DateTime.Now - DateTime.Now;

        }

        public void Count()
        {
            if (!isResume)
                return;

            newTime = DateTime.Now;
            currentTime = newTime - oldTime - distanceTime;

        }

        public void Show(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(currentTime.Minutes + " phut " + currentTime.Seconds + " giay ");
        }

    }
}
