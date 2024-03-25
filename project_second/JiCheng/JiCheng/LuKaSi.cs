using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiCheng
{
    class LuKaSi:Hero
    {
        public LuKaSi() { }
        public LuKaSi(string wheroName, string wheroInfo, int wattack, int wdefense, int wspeed, string wnickName)
            : base(wheroName, wheroInfo, wattack, wdefense, wspeed, wnickName)
        {

        }
        public void JianSuXianJing()
        {
            Console.WriteLine("减速陷阱");
        }
        public void NengLiangLangChao()
        {
            Console.WriteLine("能力浪潮");
        }
        public void XuanFengJianWu()
        {
            Console.WriteLine("旋风剑舞");
        }
    }
}
