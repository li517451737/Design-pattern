using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.Entity
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    public class CashNormal : CashSuper
    {
        /// <summary>
        /// 正常收费
        /// </summary>
        /// <param name="money"></param>
        /// <returns>原价</returns>
        public override decimal AcceptCash(decimal money)
        {
            return money;
        }
    }
}
