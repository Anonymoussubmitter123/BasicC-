using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructTest
{
    public enum Gender
    {
        boy,
        girl
    }
    public struct Person
    {
        public string name;
        public int age;
        public Gender gender;
        public string adderss;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //保存人的基本信息
            Person p1 = new Person();
            p1.name = "wlq";
            p1.age = 18;
            p1.gender = Gender.boy;
            p1.adderss = "云南昆明";

            Console.WriteLine(p1);
            Console.ReadKey();
        }
    }
}
