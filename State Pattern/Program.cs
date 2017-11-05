/**
 * 状态模式：当一个对象的内在状态改变时允许改变其行为，这个对象看起来像改变其类。
 * 主要解决的是当控制一个对象状态的条件表达式过于复杂时的情况。把状态的判断逻辑转移到表示不同状态的一系列类中，可以把复杂的判断逻辑简化。
 * 
 * 当一个对象的行为取决于它的状态，并且它必须在运行时刻根据状态改变行为时，就可以考虑使用状态模式。
 * 
 * 
 */

using StatePattern;
using System;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());
            context.Request();
            context.Request();
            context.Request();
            context.Request();

            Console.Read();
        }
    }
}
