/**
 * 职责链模式：使多个对象都有机会处理请求，从而避免请求的发送者和接收者的耦合关系。将这些对象连成一条链，并沿着这条链传递该请求，直到请求被处理。
 * 职责链的好处：
 * 1. 请求接收者和发送者都没有对方的明确信息，且链中的对象自己都不知道链的结构。
 * 结果是职责链可简化对象的相互连接，它们仅需要保持一个指向其后继者的引用，二不需要保持他所有候选者的引用，大大降低了耦合。
 * 2. 由于是在客户端定义链结构， 可以随时地增加或修改一个请求的结构。增强了给对象指派职责的灵活性。
 * 
 */
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化请求处理对象
            Handler h1 = new ConcreteHandlerA();
            Handler h2 = new ConcreteHandlerB();
            Handler h3 = new ConcreteHandlerC();
            //设置职责链的上下级关系
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);
            int[] request = new int[] { 1, 3, 10, 16, 20, 22, 29, 31 };
            //传递不同请求值给请求处理者
            foreach (var req in request)
            {
                h1.RequestHandler(req);
            }

            Console.Read();
        }
    }
}
