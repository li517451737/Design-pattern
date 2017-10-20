using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyCashier.Cashier
{
    /// <summary>
    /// 正常收费子类
    /// </summary>
    class CashNomarl : CashSuper
    {
        /// <summary>
        /// 返回原价
        /// </summary>
        /// <param name="money"></param>
        /// <returns></returns>
        public override double AcceptCash(double money)
        {
            return money;
        }
    }
    /// <summary>
    /// 打折收费子类
    /// </summary>
    class CashDiscount : CashSuper
    {
        /// <summary>
        /// 折扣，默认为1
        /// </summary>
        private double _discount = 1d;
        public CashDiscount(double discount)
        {
            _discount = discount;

        }
        /// <summary>
        /// 计算打折后的金额
        /// </summary>
        /// <param name="money">商品原价</param>
        /// <returns>折后金额</returns>
        public override double AcceptCash(double money)
        {
            return money * _discount;
        }
    }
    /// <summary>
    /// 返利收费子类
    /// </summary>
    class CashReturn : CashSuper
    {
        /// <summary>
        /// 返利条件
        /// </summary>
        private double _moneyCondition = 0d;
        /// <summary>
        /// 返利金额
        /// </summary>
        private double _moneyReturn = 0d;

        /// <summary>
        /// 传入必要的返利条件和返利金额
        /// </summary>
        /// <param name="moneyCondition"></param>
        /// <param name="moneyReturn"></param>
        public CashReturn(double moneyCondition,double moneyReturn)
        {
            this._moneyCondition = moneyCondition;
            this._moneyReturn = moneyReturn;
        }
        public override double AcceptCash(double money)
        {
            var result = money;
            if (money >= _moneyCondition)
            {
                result = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            }
            return result;
        }
    }
}
