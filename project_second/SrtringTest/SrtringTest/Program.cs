using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrtringTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "wlq";
            string name2 = "  wlq  ";
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name);
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Equals(name2));
            //Split用法
            string address = "云南|昆明|呈贡";
            char[] c = new char[] { '|' };
            string[] ad = address.Split(c);
            foreach(string i in ad) Console.WriteLine(i);
            //Substring用法
            Console.WriteLine(name.Substring(1));
            //Replace用法
            Console.WriteLine(name.Replace("l","w"));
            //Cintains用法
            Console.WriteLine(name.Contains("l"));
            //Trim用法
            Console.WriteLine(name2.Trim());
            //IsNullEmpty用法
            Console.WriteLine(string.IsNullOrEmpty(name2));
            Console.ReadKey();
        }
    }
}
