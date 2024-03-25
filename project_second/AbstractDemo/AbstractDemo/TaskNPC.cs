﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class TaskNPC:NPC
    {
        private string taskInfo;

        public TaskNPC(string taskInfo, string name , NPCType type)
            :base(name, type)
        {
            this.taskInfo = taskInfo;
        }

        public override void Speak()
        {
            Console.WriteLine("NPC{0},任务{1}", base.Name, taskInfo);
        }
    }
}
