using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterPattern
{
    /// <summary>
    /// 抽象的解释器操作，这个接口为抽象语法树中所有的节点所共享
    /// </summary>
    abstract class AbstractExpress
    {
        public abstract void Interpret(Context context);
    }

    /// <summary>
    /// 终结符表达式 ，实现与文法中的终结符相关联的解释器操作。实现抽象表达式中所要求的接口。
    /// 文法中每个终结符都有一个对应的终结符表达式与之相关。
    /// </summary>
    class TerminalExpression : AbstractExpress
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }

    class NonterminalExpression : AbstractExpress
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
    /// <summary>
    /// 包含解释器之外的一些全局信息
    /// </summary>
    class Context
    {
        private string input;
        private string output;

        public string Input { get => input; set => input = value; }
        public string Output { get => output; set => output = value; }
    }
}
