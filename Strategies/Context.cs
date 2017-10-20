/*****
 *策略模式：定义了算法家族，分别封装起来，让他们之间而已互相转换，此模式让算法的变化不会影响到使用它的客户
 * 
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Strategies
{
    /// <summary>
    /// 上下文，ConcreteSrategy来配置，维护对一个Strategy的引用
    /// </summary>
    class Context
    {
        Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            this.strategy.AlgorithmInterface();
        }
    }

    /// <summary>
    /// 客户端调用示例
    /// </summary>
    class Client
    {
        public void Test()
        {
            Context contextA = new Context(new ConcreteSrategyA());
            contextA.ContextInterface();

            Context contextB = new Context(new ConcreteSrategyB());
            contextB.ContextInterface();
        }
    }
}
