﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    /// <summary>
    /// 实体类
    /// </summary>
    class User
    {
        private string name;
        private int age;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public User(string name, int age,string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public override string ToString()
        {
            return string.Format("name:{0},age:{1},address:{2}", name, age, address);
        }
    }
}
