/****
 * 使用策略模式，实现简单商城收银系统
 * 
 */

using StrategyCashier.Cashier;
using System;

namespace StrategyCashier
{
    class Program
    {
        static void Main(string[] args)
        {
            CashContext context1 = new CashContext(CashTypes.Nommarl);
            Console.WriteLine("应收金额：" + context1.GetRealMoney(100));

            CashContext context2 = new CashContext(CashTypes.Discount);
            Console.WriteLine("应收金额：" + context2.GetRealMoney(100));

            CashContext context3 = new CashContext(CashTypes.Return);
            Console.WriteLine("应收金额：" + context3.GetRealMoney(300));
            Console.ReadKey();
        }
    }
}
