/***
 * 模板方法模式：定义一个操作类中的算法的骨架，而将一些步骤延迟到子类中。模板方法使得子类可以不改变一个算法结构即可
 *  重新定义该算法的特定不走步骤。
 * 
 * 当我们要完成在某个细节层次一致的一个过程或一系列步骤，但其个别步骤在更详细的层次上的实现可能不同，
 * 就通常考虑使用模板方法模式处理。
 * 
 */

using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A的抄的试卷：");
            TestPager paperA = new TestPagerA();
            paperA.TestQuestion1();
            paperA.TestQuestion2();
            paperA.TestQuestion3();
            Console.WriteLine("B的抄的试卷：");
            TestPager paperB = new TestPagerB();
            paperB.TestQuestion1();
            paperB.TestQuestion2();
            paperB.TestQuestion3();

            Console.Read();
        }
    }
}
