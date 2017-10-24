/***
 * 建造者模式：将一个复杂对象的构建和它的表示分离，使得同样的构建过程可以创建不同的表示。
 * 好处：
 *      使得建造代码和表示代码分离，由于建造者隐藏了该产品是如何组装的，所以若需改变一个产品的内部表示，只需要再定义个
 *      建造者即可。
 * 
 * 应用场景：
 *      1. 主要是用于创建一些复杂的对象，这些对象内部构建间的建造顺序通常是稳定的，但内部对象的构建通常面临复杂的变化。
 *      2. 建造者模式是在当创建复制对象的算法应该独立于该对象组成部分以及他们的装配方法时适用的模式。
 * 
 */

using System;

namespace Builders
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            //指挥者同感ConcreteBuilder1创建产品
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            //指挥者同感ConcreteBuilder2创建产品
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Show();

            Console.Read();
        }
    }
}
