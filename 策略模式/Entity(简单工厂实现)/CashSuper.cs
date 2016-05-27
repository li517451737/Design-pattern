using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.Entity
{
    public abstract class CashSuper
    {
        /// <summary>
        /// 现金收取抽象方法
        /// </summary>
        /// <param name="money">当前金额</param>
        /// <returns>优惠金额</returns>
        public abstract decimal AcceptCash(decimal money);
    }
}
