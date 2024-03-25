﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZhuangxiangChaixiang
{
    class Person
    {
        private string name;
        private int age;
        private string address;

        public Person(string name, int age , string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void Hello()
        {
            Console.WriteLine("大家好");
        }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", name ,age,address);
        }
    }
}
