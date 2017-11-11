/**
 * 命令模式：将一个请求封装为一个对象，从而使你可以用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可撤销的操作。
 * 命令模式的作用：
 * 1. 它能较容易的设计一个命令队列；
 * 2. 在需要的情况下，可以较容易的将命令记录到日志；
 * 3. 允许接收请求的一方决定是否要否决请求，很容易地实现对请求的撤销和重做；
 * 4. 由于加进新的具体命令类不影响其他的类，因此增加新的具体命令类很容易；
 * 5. 命令模式把请求一个操作的对象与知道怎么执行一个操作的对象分割开。
 * 
 * 
 */ 
using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //基本结构
            
            Receiver r = new Receiver();
            Command command = new ConcreteCommand(r);
            Invoke i = new Invoke();
            i.SetCommand(command);
            i.ExcuteCommand();

            Console.Read();
        }
    }
}
