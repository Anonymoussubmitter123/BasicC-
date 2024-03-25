using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiCheng
{
    class AiLuoKe:Hero
    {
        public AiLuoKe() { }
        public AiLuoKe(string wheroName, string wheroInfo, int wattack, int wdefense, int wspeed, string wnickName)
            :base(wheroName, wheroInfo, wattack, wdefense, wspeed, wnickName)
        {

        }
        public void SuiShiDaJi()
        {
            Console.WriteLine("碎石打击");
        }
        public void LieYanMaoGou()
        {
            Console.WriteLine("烈焰锚勾");
        }
        public void ZhanHuoPaoXiao()
        {
            Console.WriteLine("战火咆哮");
        }
    }
}
