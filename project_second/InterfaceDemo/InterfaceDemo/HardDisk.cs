using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class HardDisk:Disk,IUSB
    {
        private string content;

        public string Content { get; set; }

        public HardDisk(string brand):base(brand)
        {
            
        }
        public void Read()
        {
            Console.WriteLine("{0}读取数据{1}",Brand,content);
        }

        public void Write(string content)
        {
            Console.WriteLine("{0}存入数据{1}", Brand, content);
        }
    }
}
