using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            BMWCar b1 = new BMWCar("宝马3系");
            b1.Run();
            BMWCar b2 = new BMWCar("宝马2系");
            b2.Run();

            Batmobile bat1 = new Batmobile("蝙蝠侠战车1号");
            bat1.Run();
            bat1.Fly();
            
            UDisk u = new UDisk();
            u.Write();
            u.Read();
            */
            UDisk u1 = new UDisk("金十吨");
            HardDisk h1 = new HardDisk("三星500");

            Computer c1 = new Computer("联想");
            c1.Start();
            c1.USB_1 = u1;
            c1.USB_1.Write("写入一个数据");
            c1.USB_1.Write("写入第二个个数据");
            c1.USB_1.Read();
            c1.End();

            Console.WriteLine();

            Computer c2 = new Computer("戴尔");
            c2.Start();
            c2.USB_2 = h1;
            c2.USB_2.Write("硬盘写入一个数据");
            c2.USB_2.Write("硬盘写入第二个个数据");
            c2.USB_2.Read();
            c2.End();

            Console.ReadKey();
        }
    }
}
