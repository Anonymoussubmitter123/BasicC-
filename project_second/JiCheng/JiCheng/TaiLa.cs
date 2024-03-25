using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiCheng
{
    class TaiLa:Hero
    {
        public TaiLa() { }
        public TaiLa(string wheroName, string wheroInfo, int wattack, int wdefense, int wspeed, string wnickName)
            : base(wheroName, wheroInfo, wattack, wdefense, wspeed, wnickName)
        {

        }
        public void JuLangChongJi()
        {
            Console.WriteLine("巨浪冲击");
        }
        public void YanSuTuJi()
        {
            Console.WriteLine("元素出击");
        }
        public void FuChouShaLu()
        {
            Console.WriteLine("复仇杀戮");
        }
    }
}
