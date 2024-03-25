using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    static class Monkey
    {
        private static string name;

        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        public static void Hello()
        {
            Console.WriteLine("hello!");
        }
        static Monkey()
        {
            name = "www";
        }
    }
}
