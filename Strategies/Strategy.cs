using System;
using System.Collections.Generic;
using System.Text;

namespace Strategies
{
    /// <summary>
    /// 定义所支持的算法接口
    /// </summary>
    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }
    /// <summary>
    /// 封装具体的算法或行为，继承Strategy
    /// </summary>
    class ConcreteSrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            //实现算法A
        }
    }

    class ConcreteSrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            //实现算法B
        }
    }
}
