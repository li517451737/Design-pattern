/**
 * 组合模式：将对象组合成树形结构，以表示“部分--整体”的结构层次。组合模式使得用户对单个对象和组合对象的使用具有一致性。
 * 
 * 透明方式：在Component中声明所有用来管理子对象的方法。这样实现Component接口的枝节点和叶节点对于外界没有区别，它们具有完全一致的行为接口。
 * 当需求是提现部分与整体层次的结构时，并且希望用户可以忽略组合对象和单个对象的不同，统一地使用组合结构中的所有对象时，就可以考虑组合模式。 
 * 例如：公司的组织结构等等。
 * 
 */ 

using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");//初始化根节点并添加两个叶节点
            root.Add(new Leaf("Leaf A"));  
            root.Add(new Leaf("Leaf B"));

            //声明两个枝节点，并在枝节点上，添加两个叶节点

            Composite comp1 = new Composite("Composite X");
            comp1.Add(new Leaf("LeafXA"));
            comp1.Add(new Leaf("LeafXB"));
            root.Add(comp1);

            Composite comp2 = new Composite("Composite Y");
            comp2.Add(new Leaf("LeafYA"));
            comp2.Add(new Leaf("LeafYB"));
            root.Add(comp2);
            
            root.Display(1); //遍历所有节点

            Console.Read();
        }
    }
}
