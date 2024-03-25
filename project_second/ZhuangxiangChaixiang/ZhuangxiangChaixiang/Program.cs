using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhuangxiangChaixiang
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("wlq", 18, "yvnan");
            p.Hello();
            Console.WriteLine(p.ToString()); 

            Console.ReadKey();
        }
    }
}
