using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.Entity
{
    public class CashReturn : CashSuper
    {
        /// <summary>
        /// 返利条件
        /// </summary>
        private decimal moneyConditon = 0M;
        /// <summary>
        /// 返利金额
        /// </summary>
        private decimal moneyReturn = 0M;

        /// <summary>
        /// 构造方法，初始化返利条件与返利金额
        /// </summary>
        /// <param name="moneyCondition"></param>
        /// <param name="moneyReturn"></param>
        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this.moneyConditon = decimal.Parse(moneyCondition);
            this.moneyReturn = decimal.Parse(moneyReturn);
        }
        /// <summary>
        /// 满减收费
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override decimal AcceptCash(decimal money)
        {
            decimal result = money;
            if(money >= moneyConditon)//如果大于满减条件，则减去优惠金额
            {
                result = money - Math.Floor(money / moneyConditon) * moneyReturn;
            }
            return result;
        }
    }
}
