using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    /// <summary>
    /// NPC类型枚举
    /// </summary>
    enum NPCType
    {
        /// <summary>
        /// 任务NPC
        /// </summary>
        Task,
        /// <summary>
        /// 商贩NPC
        /// </summary>
        Shop
    }
    /// <summary>
    /// NPC父类
    /// </summary>
    abstract class NPC
    {
        private string name;
        private NPCType type;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public NPCType Type
        {
            get { return type; }
            set { type = value; }
        }
        //构造方法
        public NPC(string name , NPCType type)
        {
            this.name = name;
            this.type = type;
        }

        public abstract void Speak();
    }
}
