using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    class Person
    {
        public string name;
        public static string address = "山东";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public static string Address 
        {
            get { return address; }
            set { address = value; }
        }
        public void P1()
        {
            P2();
            Console.WriteLine("我是普通方法");
        }
        public static void P2()
        {
            Console.WriteLine("我是静态普通方法");
        }
        static Person()
        {
            address = "美国";
        }
    }
}
