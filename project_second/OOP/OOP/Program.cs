using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //【访问修饰符】 class 类名 {类的描述信息；}

    class Program
    {
        static void Main(string[] args)
        {
            /*Apple a1 = new Apple();
            //字段的赋值
            a1.color = Color.Red;
            a1.weight = 200;
            a1.shape = "圆形";
            //字段的取值
            Console.WriteLine("{0},{1},{2}", a1.shape, a1.weight, a1.color);*/

            Person p1 = new Person();
            //p1.name = "wlq";
            //p1.age = 18;
            p1.Age = 180;
            p1.Gender = Gender.nan;
            p1.Name = "wlq";
            p1.Eat();
            p1.Sleep();
            Console.WriteLine("{0},{1},{2}", p1.Gender, p1.Name,p1.Age);

            Person p2 = new Person("wlq", 18, Gender.nan, "云南");
            Console.WriteLine("{0},{1},{2},{3}", p2.Gender, p2.Name, p2.Age, p2.address);
            p2.Hello();

            Person p3 = new Person("banana", 19, Gender.nan, "山东");
            Person p4;
            p4 = p3;
            p3.Hello();
            p4.Hello();

            p3.Name = "apple";
            p3.Hello();
            p4.Hello();

            Console.ReadKey();
        }
    }
}
