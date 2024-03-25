using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiCheng
{
    /// <summary>
    /// Hero类，所以英雄的父类
    /// </summary>
    class Hero
    {
        private string heroName;
        private string heroInfo;
        private int attack;
        private int defense;
        private int speed;
        private string nickName;

        public Hero() { }
        public Hero(string wheroName,string wheroInfo,int wattack,int wdefense, int wspeed,string wnickName)
        {
            this.heroName = wheroName;
            this.heroInfo = wheroInfo;
            this.attack = wattack;
            this.defense = wdefense;
            this.speed = wspeed;
            this.nickName = wnickName;
        }
        public void Hello()
        {
            Console.WriteLine("我是{0}，我的信息{1}，攻击力{2}，防御力{3}，速度{4}，昵称{5}",
                this.heroName, this.heroInfo, this.attack, this.defense, this.speed, this.nickName); 
        }
        
        public string HeroName
        {
            get { return heroName; }
            set { heroName = value; }
        }
        public string HeroInfo
        {
            get { return heroInfo; }
            set { heroInfo = value; }
        }
        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }
        public int Defense
        {
            get { return defense; }
            set { defense = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public string NickName
        {
            get { return nickName; }
            set { nickName = value; }
        }
    }
}
