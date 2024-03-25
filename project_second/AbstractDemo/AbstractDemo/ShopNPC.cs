using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class ShopNPC:NPC
    {
        private string taskInfo;

        public ShopNPC(string taskInfo, string name, NPCType type)
            : base(name, type)
        {
            this.taskInfo = taskInfo;
        }

        public override void Speak()
        {
            Console.WriteLine("NPC{0},贩卖{1}商品", base.Name, taskInfo);
        }
    }
}
