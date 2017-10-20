using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Operations
{
    /// <summary>
    /// 简单算法工厂类型,根据传入的运算符类型，发货计算类实体
    /// </summary>
    public class OperationFactory
    {
        /// <summary>
        /// 根据传入的运算符字符串，返回运算实体
        /// </summary>
        /// <param name="operate"></param>
        /// <returns></returns>
        public static Operation CreateOperation(string operate)
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "x":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
            }
            return operation;
        }
    }
}
