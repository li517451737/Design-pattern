/****
 * 装饰模式：动态地给对象添加一些额外的职责，就增加功能而言，装饰模式比生产子类跟灵活。
 * 优点：
 *  把类中的装饰功能从类中搬移出去，这样可以简化原有的类。
 * 缺点：
 *  装饰模式会导致设计中出现许多小类，如果过度使用，会使程序变得很复杂
 * 
 * 
 */

using Decorator.Finerlies;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Person xc = new Person("小李");

            TShirts ts = new TShirts();
            BigTrouser bt = new BigTrouser();
            WearSneakers ws = new WearSneakers();

            ts.Decoteter(xc);
            bt.Decoteter(ts);
            ws.Decoteter(bt);
            ws.Show();
            Console.ReadKey();
        }
    }
}
