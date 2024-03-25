using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    /// <summary>
    /// 视图层
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> num = new List<int>();
            num.Add(5);
            num.Add(10);

            List<Weapon> weapons = new List<Weapon>();
            Weapon item = new Weapon(1, "bawangqiang", 100);
            weapons.Add(item);

            weapons.Add(new Weapon(2, "feicuidao", 200));
            weapons.Add(new Weapon(3, "taijijuanzhou", 300));
            weapons.Add(new Weapon(4, "lvyvgun", 400));

            weapons.RemoveAt(1);

            for(int i = 0; i < weapons.Count; i++)
            {
                if (weapons[i].Name == "taijijuanzhou") weapons.Remove(weapons[i]);
                if (weapons[i].Name == "lvyvgun") weapons[i].Attack = 9999;
                Console.WriteLine(weapons[i]);
            }
            */

            UserController uc = new UserController();  // 定义在循环外面，否则失败

            while (true){
                Console.WriteLine("*-------------------------------*");
                Console.WriteLine("*---------用户管理系统----------*");
                Console.WriteLine("*-------------------------------*");

                //提示
                Console.WriteLine("请输入相关的指令数字：（1）增加（2）修改（3）删除（4）查看");
                //接受用户输入的信息
                string command = Console.ReadLine();
                //对用户输入的命令进行判断

                switch (command)
                {
                    case "1":
                        Console.WriteLine("请输入名字：");
                        string name = Console.ReadLine();
                        Console.WriteLine("请输入年龄：");
                        int age = int.Parse(Console.ReadLine());
                        Console.WriteLine("请输入地址：");
                        string address = Console.ReadLine();
                        //调用控制器对象方法，添加到数据库集合中
                        uc.AddItem(new User(name, age, address));
                        break;
                    case "2":
                        
                        break;
                    case "3":
                        Console.WriteLine("请输入删除方式：（1）姓名（2）地址");
                        string comm = Console.ReadLine();
                        switch (comm)
                        {
                            case "1":
                                Console.WriteLine("请输入要删除的名字");
                                string dname = Console.ReadLine();
                                uc.RemoveByName(dname);
                                break;
                            case "2":
                                Console.WriteLine("请输入要删除的名字");
                                string daddress = Console.ReadLine();
                                uc.RemoveByAddress(daddress);
                                break;
                            default:
                                Console.WriteLine("请输入正确的指令");
                                break;
                        }
                        break;
                    case "4":
                        uc.ShowAll();
                        break;
                    default:
                        Console.WriteLine("请输入正确的命令。");
                        break;
                }
            }
        }
    }
}
