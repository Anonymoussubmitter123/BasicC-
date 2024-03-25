using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("baidu", "百度网站");
            dic.Add("qq", "腾讯网站");
            dic.Add("淘宝", "淘宝网站");
            //不能添加同键名的数据
            //dic.Add("taobao", "马云");
            Console.WriteLine(dic["qq"]);
            foreach(var ite in dic.Keys)
            {

            }*/
            WebinfoController wc = new WebinfoController();
            wc.AddItem("wlq", new Web("taobao", "wangzhi", "boss"));
            wc.ShowAll();

            Console.ReadKey();
        }
    }
}
