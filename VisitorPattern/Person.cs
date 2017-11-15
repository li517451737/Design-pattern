using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorPattern
{
    /// <summary>
    /// 状态抽象类
    /// </summary>
    abstract class Action
    {
        public abstract void GetManConclusion(Man concreteElementA);
        public abstract void GetWomanConclusion(Woman concreteElementB);
    }
    /// <summary>
    /// 成功状态
    /// </summary>
    class Success : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时，背后多半有个伟大的女人",concreteElementA.GetType().Name,this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时，背后多半有个不成功的男人", concreteElementB.GetType().Name, this.GetType().Name);

        }
    }
    /// <summary>
    /// 失败状态
    /// </summary>
    class Fail : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时，闷头喝酒，谁也不用劝", concreteElementA.GetType().Name, this.GetType().Name);
        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时，眼泪汪汪，谁也劝不了", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }
    /// <summary>
    /// 恋爱状态
    /// </summary>
    class Amativeness : Action
    {
        public override void GetManConclusion(Man concreteElementA)
        {
            Console.WriteLine("{0}{1}时，凡是不懂也要装懂", concreteElementA.GetType().Name, this.GetType().Name);

        }

        public override void GetWomanConclusion(Woman concreteElementB)
        {
            Console.WriteLine("{0}{1}时，遇事懂也装作不懂", concreteElementB.GetType().Name, this.GetType().Name);
        }
    }

    /// <summary>
    /// 抽象人类
    /// </summary>
    abstract class Person
    {
        public abstract void Accept(Action visitor);
    }
    /// <summary>
    /// 男人类
    /// </summary>
    class Man : Person
    {
        /// <summary>
        /// 接受
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(Action visitor)
        {
            /**
             * 双分派技术,首先在客户程序中将具体的状态作为参数传递给“男人”类，完成一次分派，然后“男人”类调用作为参数的“具体状态”中的方法“男人的反应”，
             * 同时将自己(this)作为参数传递进去。这便完成了第二次分派。
             */
            visitor.GetManConclusion(this);
        }
    }
    /// <summary>
    /// 女人类
    /// </summary>
    class Woman : Person
    {
        /// <summary>
        /// 接受
        /// </summary>
        /// <param name="visitor"></param>
        public override void Accept(Action visitor)
        {
            visitor.GetWomanConclusion(this);
        }
    }
    /// <summary>
    /// 对象结构类
    /// 由于总是需要“男人”与“女人”在不同状态下的对比，所有我们需要一个“对象结构”类来针对不同的“状态”遍历“男人”与“女人”，得到不同反应。
    /// </summary>
    class ObjectStructrue
    {
        private IList<Person> elements = new List<Person>();

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="person"></param>
        public void Attch(Person person)
        {
            elements.Add(person);
        }
        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="person"></param>
        public void Detach(Person person)
        {
            elements.Remove(person);
        }
        /// <summary>
        /// 遍历对象
        /// </summary>
        /// <param name="visitor"></param>
        public void Display(Action visitor)
        {
            foreach (var item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
}
