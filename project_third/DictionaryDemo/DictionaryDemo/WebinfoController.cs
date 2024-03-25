using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    /// <summary>
    /// 实体类
    /// </summary>
    class WebinfoController
    {

        Dictionary<string, Web> webInfos = new Dictionary<string, Web>();

       
        public void AddItem(string name, Web web)
        {
            webInfos.Add(name, web);
        }
        public void ShowAll()
        {
            foreach (var item in webInfos.Keys)
            {
                Console.WriteLine("{0},{1}", item, webInfos[item]);
            }
        }
    }
}
