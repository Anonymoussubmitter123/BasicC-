using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tiger t = new Tiger();
            t.Cry();

            Cat c = new Cat();
            c.Cry();
            c.FuLei();

            Console.WriteLine();

            CatType ct = new Cat();
            Cat c2 = (Cat) ct;
            ct.Cry();

            bool w = ct is Cat;
            Console.WriteLine(w);

            if (ct as Cat == null)
            {
                Console.WriteLine("失败");
            }
            else
            { 
                Console.WriteLine("成功");
            }
            */

            ZiLei z = new ZiLei();
            z.Hello();

            FuLei f = new ZiLei();

            Console.ReadKey();
        }
    }
}
