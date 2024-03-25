using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Hello();
            Person.Web p2 = new Person.Web();
            p2.Show();
            var w = new { Name = "wlq", Age = 100, Address = "山东" };
            Console.WriteLine("{0},{1}", w.Name, w.Age);

            Console.ReadKey();
        }
    }
}
