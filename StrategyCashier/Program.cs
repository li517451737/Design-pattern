/****
 * 策略模式：定义了算法家族，分别封装起来，让他们之间而已互相转换，此模式让算法的变化不会影响到使用它的客户；
 * 
 * 策略模式的优点：
 * 1. 策略模式是一种定义一系列算法的方法，从概念上来看，这些算法完成的都是相同的工作，只是实现不同，它们可以以相同的方式调用所有的算法，减少
 * 各种算法类和使用算法类之间的耦合；
 * 2. 策略模式为Context定义了一系列可重用的算法或行为，继承有助于析取出这些算法中的公共方法。
 * 
 * 在实践中，只要在分析过程中听到需要在不同时间应用不同的业务规则，就可以考虑使用策略模式处理这种变化的可能性
 * 
 */

using StrategyCashier.Cashier;
using System;
/// <summary>
/// 使用策略模式，实现简单商城收银系统
/// </summary>
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
