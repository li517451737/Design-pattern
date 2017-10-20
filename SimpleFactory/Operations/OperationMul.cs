using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Operations
{
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
}
