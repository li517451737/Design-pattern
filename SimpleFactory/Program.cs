/***
 * 简单工厂模式与工厂方法模式的比较：
 *  简单工厂模式最大的优点在于工厂类中包含了必要的逻辑判断，根据客户端的选择条件动态的实例化相关类，对客户端来说去除了与具体产品的依赖。
 * 工厂方法模式：定义了一个用于创建对象的接口，让子类决定实例化哪一个类，工厂方法使一个类的实例化延迟到了其子类。
 * 
 * 工厂方法模式客户了简单工厂违背开-闭原则的缺点，有保持了封装对象创建过程的优点。
 * 
 */

using SimpleFactory.Operations;
using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字A：");
            string numberA = Console.ReadLine();
            Console.WriteLine("请输入运算符(+,-,*,/)：");
            string operater = Console.ReadLine();
            Console.WriteLine("请输入数字B：");
            string numberB = Console.ReadLine();
            Operation operation = null;
            operation = OperationFactory.CreateOperation(operater);
            operation.NumberA = Convert.ToDouble(numberA);
            operation.NumberB = Convert.ToDouble(numberB);
            Console.WriteLine("计算结果为：" + operation.GetResult());
            Console.ReadKey();
        }
    }
}
