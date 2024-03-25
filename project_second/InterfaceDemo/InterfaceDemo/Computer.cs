using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Computer
    {
        private string brand;

        public IUSB USB_1;
        public IUSB USB_2;

        public string Brand { get; set; }
        
        public Computer(string brand)
        {
            this.brand = brand;
        }

        public void Start()
        {
            Console.WriteLine("{0}电脑开机",brand);
        }
        public void End()
        {
            Console.WriteLine("{0}电脑关机",brand);
        }
    }
}
