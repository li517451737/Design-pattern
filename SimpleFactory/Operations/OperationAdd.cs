using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Operations
{
    /// <summary>
    /// 加法类,继承算法类并重写GetResult方法
    /// </summary>
    public class OperationAdd : Operation
    {

        public override double GetResult()
        {
            double result = NumberA + NumberB;
            return result;
        }
    }
}
