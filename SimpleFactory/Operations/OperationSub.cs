using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Operations
{
    /// <summary>
    /// 减法类
    /// </summary>
    public class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = NumberA - NumberB;
            return result;
        }
    }
}
