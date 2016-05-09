using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Designpattern
{
    /// <summary>
    /// 西红柿炒蛋工厂类
    /// </summary>
    public class TomatoScrambledEggsFactory : Creator
    {
        /// <summary>
        /// 返回西红柿炒蛋类
        /// </summary>
        /// <returns></returns>
        public override Food CreateFoodFactory()
        {
            return new TomatoScrambledEggs();
        }
    }
}
