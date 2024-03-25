using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskNPC npc1 = new TaskNPC("去挖两个萝卜", "npc1", NPCType.Task);
            npc1.Speak();
            
            ShopNPC npc2 = new ShopNPC("西亚那样", "npc2", NPCType.Task);
            npc2.Speak();

            Console.ReadKey();
        }
    }
}
