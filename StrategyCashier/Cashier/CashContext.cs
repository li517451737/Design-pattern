using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyCashier.Cashier
{
    /// <summary>
    /// 收费上下文对象
    /// </summary>
    class CashContext
    {
        private CashSuper _cashSuper;

        /// <summary>
        /// 通过构造方法传入收费类型，获取不同的收费策略
        /// </summary>
        /// <param name="super"></param>
        public CashContext(CashTypes cashType)
        {
            switch (cashType)
            {
                case CashTypes.Nommarl:
                    _cashSuper = new CashNomarl();
                    break;
                case CashTypes.Discount:
                    _cashSuper = new CashDiscount(0.8);
                    break;
                case CashTypes.Return:
                    _cashSuper = new CashReturn(300, 10);
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 根据不同策略返回不同的应收金额
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public double GetRealMoney(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}
