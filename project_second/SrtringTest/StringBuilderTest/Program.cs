using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace StringBuilderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            //创建StringBuilder类的对象
            StringBuilder sb = new StringBuilder();
            //往sb中追加数据
            sb.Append("wlq");
            sb.Append(12345);
            sb.Append(true);
            sb.Clear();
            Console.WriteLine(sb.ToString());
            sw.Stop();
            Console.WriteLine(sw.Elapsed); //输出时间
            Console.ReadKey();
        }
    }
}
