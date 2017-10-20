using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Operations
{
    public class Operation
    {
        private double _numberA;
        private double _numberB;

        public double NumberA { get => _numberA; set => _numberA = value; }
        public double NumberB { get => _numberB; set => _numberB = value; }


        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
