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
