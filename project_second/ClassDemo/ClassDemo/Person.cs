using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void Hello()
        {
            Console.WriteLine("hello");
        }
        public class Web
        {
            public string webName;
            public string webUrl;

            public void Show()
            {
                Console.WriteLine("{0},{1}",webName, webUrl);
            }
        }
    }
}
