using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyCashier.Cashier
{
    /// <summary>
    /// 现金收费抽象类
    /// </summary>
    abstract class CashSuper
    {
        /// <summary>
        /// 现金收费
        /// </summary>
        /// <param name="money">商品金额</param>
        /// <returns>应收金额</returns>
        public abstract double AcceptCash(double money);
    }
}
