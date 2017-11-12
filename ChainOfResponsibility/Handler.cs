using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    /// <summary>
    /// 定义一个处理请求的抽象类或接口
    /// </summary>
    public abstract class Handler
    {
        protected Handler successor;

        /// <summary>
        /// 设置下一个处理请求接收者
        /// </summary>
        /// <param name="handler"></param>
        public void SetSuccessor(Handler successor)
        {
            this.successor = successor;
        }

        /// <summary>
        /// 处理请求的抽象方法
        /// </summary>
        /// <param name="request"></param>
        public abstract void RequestHandler(int request);
    }
    /// <summary>
    /// 具体请求处理对象A
    /// </summary>
    class ConcreteHandlerA : Handler
    {
        public override void RequestHandler(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
            else
            {
                //转移到下一请求处理对象
                successor.RequestHandler(request);
            }
        }
    }
    /// <summary>
    /// 具体请求处理对象B
    /// </summary>
    class ConcreteHandlerB : Handler
    {

        public override void RequestHandler(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
            else
            {
                successor.RequestHandler(request);
            }
        }
    }
    /// <summary>
    /// 具体请求处理对象C
    /// </summary>
    class ConcreteHandlerC : Handler
    {

        public override void RequestHandler(int request)
        {
            if (request >= 20)
            {
                Console.WriteLine("{0}处理请求{1}", this.GetType().Name, request);
            }
        }
    }
}
