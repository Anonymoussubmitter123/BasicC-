using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiCheng
{
    class Program
    {
        static void Main(string[] args)
        {
            AiLuoKe alk = new AiLuoKe("埃罗克", "我是埃罗克", 80, 65, 40, "ailuoke");
            alk.LieYanMaoGou();
            alk.Hello();
            TaiLa tl = new TaiLa("泰拉", "我是泰拉", 40, 65, 80, "taila");
            tl.FuChouShaLu();
            tl.Hello();
            LuKaSi lks = new LuKaSi("卢卡斯", "我是卢卡斯", 40, 65, 80, "lukasi");
            lks.JianSuXianJing();
            lks.Hello();
            LuoFei lf = new LuoFei("罗飞", "我是罗飞", 40, 65, 80, "luofei");

            Console.ReadKey();
        }
    }
}
