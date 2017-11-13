/**
 * 享元模式（Flyweight）：运用共享技术有效地支持大量细粒度的对象。
 * 
 * 享元模式可以避免大量非常相似类的开销。在程序设计中，有时候需要生成大量细粒度的类的实例来表示数据。如果能发现这些实例除了几个参数外基本都是相同的，
 * 有时候就能够大幅度减少需要实例化类的数量。如果把那些参数移到类的实例外面去，在方法调用时将它们传递进来，就可以通过共享，大幅度减少单个实例的数量。
 * 
 * 如果一个应用程序使用了大量的对象，而大量的对象造成了很大的储存开销时，就可以考虑使用享元模式。
 */ 

using System;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 12;
            FlyweightFactory factory = new FlyweightFactory();

            Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnshardConcreteFlyweight uf = new UnshardConcreteFlyweight();
            uf.Operation(--extrinsicstate);


            Console.Read();
        }
    }
}
