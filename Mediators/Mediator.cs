using System;
using System.Collections.Generic;
using System.Text;

namespace Mediators
{
    /// <summary>
    /// 抽象中介者类 定义同事对象到中介者对象的接口
    /// </summary>
    public abstract class Mediator
    {
        public abstract void SendMessage(string message, Colleague colleague);
    }

    /// <summary>
    /// 抽象同事类
    /// </summary>
    public abstract class Colleague
    {
        protected Mediator mediator;

        /// <summary>
        /// 构造方法，通过构造方法得到中介者对象
        /// </summary>
        /// <param name="mediator"></param>
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

    }
    /// <summary>
    /// 具体中介者类   包含所有具体同事对象
    /// </summary>
    public class ConcreteMediator : Mediator
    {
        private ConcreteColleagueA colleagueA;
        private ConcreteColleagueB colleagueB;

        public ConcreteColleagueA ColleagueA { set => colleagueA = value; }
        public ConcreteColleagueB ColleagueB { set => colleagueB = value; }

        /// <summary>
        /// 重写发送消息方法，根据发送者对象，做出选择判断，通知对象
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        public override void SendMessage(string message, Colleague colleague)
        {
            if (colleague == colleagueA)
            {
                colleagueB.Notify(message);
            }
            else
            {
                colleagueA.Notify(message);
            }
        }
    }
    /// <summary>
    /// 具体同事A
    /// </summary>
    public class ConcreteColleagueA : Colleague
    {
        public ConcreteColleagueA(Mediator mediator) : base(mediator)
        {
        }

        public void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }

        public void Notify(string messgae)
        {
            Console.WriteLine("同事A得到消息：" + messgae);
        }
    }
    /// <summary>
    /// 同事B
    /// </summary>
    public class ConcreteColleagueB : Colleague
    {
        public ConcreteColleagueB(Mediator mediator) : base(mediator)
        {

        }

        public void SendMessage(string message)
        {
            mediator.SendMessage(message, this);
        }

        public void Notify(string messgae)
        {
            Console.WriteLine("同事B得到消息：" + messgae);
        }
    }
}
