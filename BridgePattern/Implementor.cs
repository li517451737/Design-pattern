using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    /// <summary>
    /// 抽象实现类
    /// </summary>
    abstract class Implementor
    {
        public abstract void Operation();
    }

    /// <summary>
    /// 具体实现类
    /// </summary>
    class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现类A");
        }
    }

    class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("具体实现类B");
        }
    }

    class Abstraction
    {
        protected Implementor implementor;

        public void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
    /// <summary>
    /// 被提炼的抽象对象
    /// </summary>
    class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            base.Operation();
        }
    }
}
