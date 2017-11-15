/**
 * 解释器模式：给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语言中的句子。
 * 
 * 通常情况下，当有一个语言需要解释执行，并且你可将该语言中的句子表示为一个抽象语法树时，可以使用解释器模式。
 * 
 * 优点：
 * 很容易地改变和扩展文法，因为该模式使用类来表示文法规则你可以使用继承来改变或扩展该文法。也比较容易实现文法，因为定义抽象语法书树
 * 中各个节点的类的实现大体是相似的，这些类都易于直接编写。
 * 
 * 缺点：
 * 解释器模式为文法中的每一条规则至少定义了一个类，因此包含许多规则的文法可能难以管理和维护。建议当文法非常复杂的时候，使用其他技术如语法
 * 分析程序和编译器生成器来处理。
 * 
 */ 

using System;
using System.Collections.Generic;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            IList<AbstractExpress> list = new List<AbstractExpress>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            foreach (var item in list)
            {
                item.Interpret(context);
            }


            Console.Read();
        }
    }
}
