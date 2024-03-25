using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumType
{
    //定义枚举
    public enum Week
    {
        星期一,
        星期二,
        星期三,
        星期四,
        星期五,
        星期六,
        星期天
    }
    public enum Gender
    {
        boy,
        girl
    }
    class Program
    {
        static void Main(string[] args)
        {
            //枚举类型 变量名 = 枚举类型.值
            Week day = Week.星期一;
            Gender p1 = Gender.boy;

            Console.WriteLine(day);
            Console.WriteLine(p1);
            Console.ReadKey();
        }
    }
}
