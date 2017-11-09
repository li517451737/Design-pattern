/**
 * 迭代器模式：提供一种顺序访问一个聚合对象中的各个元素，而又不暴露该对象的内部表示。
 * 迭代器模式就是分离了集合对象的遍历行为，抽象出一个迭代器类来负责，这样既可以做到不暴露集合内部结构，又可以让外部代码透明地访问集合内部的数据。
 * .net中的IEumerator支持对非泛型集合的简单迭代
 * IEnumerator：是一个真正的集合访问器，提供在普通集合中遍历的接口，有Current，MoveNext()，Reset()，其中Current返回的是object类型。
 * IEnumerable： 暴露一个IEnumerator（只包含一个抽象的方法GetEnumerator(),该方法返回一个可用于循环访问集合的IEnumerator对象），支持在普通集合中的遍历。
 */

using System;
using System.Collections.Generic;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate a = new ConcreteAggregate();
            a[0] = "张三";
            a[1] = "李四";
            a[2] = "王二";
            a[3] = "哇哈哈";
            a[4] = "乐事";
            Iterator iterator = new ConcreteIterator(a);
            while (!iterator.IsDone())
            {
                Console.WriteLine("{0} 请买票", iterator.CurrentItem());
                iterator.Next();
            }

            Console.Read();
        }
    }
}
