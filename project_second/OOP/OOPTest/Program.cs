using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AiLuoKe ailuoke = new AiLuoKe("吃米饭");
            ailuoke.LieYanMaoGou();
            ailuoke.SuiShiDaJi();
            ailuoke.ZhanHuoPaoXiao();
            ailuoke.Hello();

            TaiLa taila = new TaiLa("喝汤");
            taila.LieYanMaoGou();
            taila.SuiShiDaJi();
            taila.ZhanHuoPaoXiao();
            taila.Hello();

            Console.ReadKey();
        }
    }
}
