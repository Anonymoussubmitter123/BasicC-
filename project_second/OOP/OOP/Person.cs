using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public enum Gender
    {
        nan,
        nv
    }
    /// <summary>
    /// 用于修饰人
    /// </summary>
    class Person
    {
        private string name;
        private int age;
        private Gender gender;
        public string address;
        public Person()
        {

        }
        public Person(string name , int age, Gender gender, string address)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.address = address;
        }
        public void Eat (){
            Console.WriteLine(Name + "我会吃饭。");
        }
        public void Sleep()
        {
            Console.WriteLine(Name + "我会睡觉奥。");
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set {
                if (value > 100 || value < 0)
                {
                    age = 18;
                }
                else
                {
                    age = value;
                }
            }
        }
        public void Hello()
        {
            Console.WriteLine("大家好我是{0}，{1}", Name, Gender);
        }
    }
}
