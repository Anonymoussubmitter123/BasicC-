using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    /// <summary>
    /// C(Controller)控制器层--用于处理逻辑。
    /// </summary>
    class UserController
    {
        List<User> userList = new List<User>();
        //增删改查
        public void AddItem(User user)
        {
            userList.Add(user);
        }

        public void RemoveByName(string name)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name == name) userList.Remove(userList[i]);
            }
        }
        public void RemoveByAddress(string address)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Address == address) userList.Remove(userList[i]);
            }
        }

        public void ShowAll()
        {
            if (userList.Count == 0) Console.WriteLine("注册表为空");
            else
            {
                for (int i = 0; i < userList.Count(); i++)
                {
                    Console.WriteLine(userList[i]);
                }
            }
        }
    }
}
