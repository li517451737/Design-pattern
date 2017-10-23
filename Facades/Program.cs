/***
 * 外观模式：为子系统的一组接口提供一个一致的界面，此模式定义了一个高层接口，这个接口使得子系统更加容易使用。
 * 
 * 外观模式应用场景：
 * 1. 在设计初期，应该有意识的将不同的两个层分离，在层与层之间建立外观Facade
 * 2. 在开发阶段，子系统往往因为不断的重购演化而变得越来越复杂，增加外观Facade可以提供一个简单的接口，减少它们的依赖。
 * 3. 在维护遗留的大型系统时，可以为新系统开发一个Facade类，来提供设计粗糙或高度复杂的遗留代码的比较清晰的接口，让新系统与Facade交互，Facade与遗留代码交互所有复杂的工作。
 * 
 */ 



using System;

namespace Facades
{
    class Program
    {
        static void Main(string[] args)
        {
            //外观类
            Facade facade = new Facade();
            facade.MethodA();
            facade.MethodB();
            Console.Read();
        }
    }
}
