using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.Entity
{
    public class CashRebate : CashSuper
    {
        /// <summary>
        /// 折扣
        /// </summary>
        private decimal moneyRebate = 0M;

        /// <summary>
        /// 构造方法，初始化折扣
        /// </summary>
        /// <param name="moneyRebate"></param>
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = decimal.Parse(moneyRebate);
        }
        /// <summary>
        /// 打折收费
        /// </summary>
        /// <param name="money">原价</param>
        /// <returns>打折后金额</returns>
        public override decimal AcceptCash(decimal money)
        {
            return money * this.moneyRebate;
        }
    }
}
