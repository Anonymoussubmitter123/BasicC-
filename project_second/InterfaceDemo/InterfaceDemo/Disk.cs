using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Disk
    {
        private string brand;

        public string Brand { get; set; }

        public Disk(string brand)
        {
            this.brand = brand;
        }
    }
}
