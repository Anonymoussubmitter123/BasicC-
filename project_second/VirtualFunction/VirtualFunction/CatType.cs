using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualFunction
{
    class CatType
    {
        public virtual void Cry()
        {
            Console.WriteLine("我会叫");
        }
        public void FuLei()
        {
            Console.WriteLine("我是父类");
        }
    }
}
