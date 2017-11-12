using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    /// <summary>
    /// 声明命令执行接口
    /// </summary>
    abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Excute();
    }
    /// <summary>
    /// 声明一个实施和执行一个请求相关的操作，任何类都可能作为一个接收者
    /// </summary>
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("命令请求");
        }
    }

    /// <summary>
    /// 将一个接收者对象绑定于一个动作，调用接受者相应的操作，以实现Execute。
    /// </summary>
    class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {
            this.receiver = receiver;
        }


        public override void Excute()
        {
            receiver.Action();
        }
    }
    /// <summary>
    /// 要求该命令执行这个请求
    /// </summary>
    class Invoke
    {
        private Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        public void ExcuteCommand()
        {
            command.Excute();
        }
    }
}
