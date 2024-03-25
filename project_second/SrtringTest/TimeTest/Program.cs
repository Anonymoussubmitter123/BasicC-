using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            string str = "";
            for (int i = 0; i <= 50000; i++) str += i;
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
            sw.Reset();
            sw.Start();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= 50000; i++) sb.Append(i);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

        }
    }
}
