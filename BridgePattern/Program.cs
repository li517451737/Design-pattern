/**
 * 桥接模式：将抽象部分和它的实现部分分离，使它们都可以独立变化。
 * 说明：抽象和它的实现分离，并不是说，让其抽象类与其派生类分离。实现指的是抽象类和它的派生类用来实现自己的对象。
 * 
 * 
 */ 

using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();
            ab.SetImplementor(new ConcreteImplementorA());
            ab.Operation();

            ab.SetImplementor(new ConcreteImplementorB());
            ab.Operation();
            Console.Read();
        }
    }
}
