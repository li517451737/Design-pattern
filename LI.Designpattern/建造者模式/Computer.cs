using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LI.Designpattern
{
    /// <summary>
    /// 组装电脑类
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 电脑配件集合
        /// </summary>
        IList<string> list = new List<string>();

        /// <summary>
        /// 将电脑配件添加到集合中
        /// </summary>
        /// <param name="part">配件名称</param>
        public void Add(string part)
        {
            list.Add(part);
        }
        public void Show()
        {
            Console.WriteLine("电脑开始组装……");
            foreach (var item in list)
            {
                Console.WriteLine("{0}已经组装成功！", item);
            }
            Console.WriteLine("电脑组装好了！");
        }
    }
}