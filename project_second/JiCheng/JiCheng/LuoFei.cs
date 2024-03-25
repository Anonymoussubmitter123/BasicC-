using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiCheng
{
    class LuoFei:Hero
    {
        public LuoFei() { }
        public LuoFei(string wheroName, string wheroInfo, int wattack, int wdefense, int wspeed, string wnickName)
            : base(wheroName, wheroInfo, wattack, wdefense, wspeed, wnickName)
        {

        }
        public void NengLiangJingLing()
        {
            Console.WriteLine("能量精灵");
        }
        public void AnYingChuanSong()
        {
            Console.WriteLine("暗影传送");
        }
        public void ShiKongBengLie()
        {
            Console.WriteLine("时空崩裂");
        }
    }
}
