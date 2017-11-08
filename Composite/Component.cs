using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    /// <summary>
    /// 为组合中的对象声明接口，在适当情况下，实现所有类共有接口的默认行为。
    /// 声明一个接口用于访问和管理的Component的子部件
    /// </summary>
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract void Display(int depth);

    }

    /// <summary>
    /// 在组合表示叶节点对象，叶节点没有子节点
    /// </summary>
    class Leaf : Component
    {

        public Leaf(string name) : base(name) { }

        //由于叶子节点没有再增加子节点，所有Add和Remove方法实现它没有意义，但着这样可以消除叶节点和枝节点对象在抽象层次的却别，他们具有完全一致的接口。

        public override void Add(Component component)
        {
            Console.WriteLine("不能给叶节点添加子节点");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("不能从叶节点删除子节点");

        }
    }
    /// <summary>
    /// 定义有枝节点的行为
    /// </summary>
    class Composite : Component
    {
        /// <summary>
        /// 子对象集合，用来储存下属枝节点和叶节点
        /// </summary>
        private List<Component> children = new List<Component>();

        public Composite(string name) : base(name) { }

        public override void Add(Component component)
        {
            children.Add(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach (var item in children)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Component component)
        {
            children.Remove(component);
        }
    }

}
