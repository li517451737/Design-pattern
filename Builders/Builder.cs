
using System;
using System.Collections.Generic;
using System.Text;

namespace Builders
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract Product GetResult();
    }

    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("组件A");
        }

        public override void BuildPartB()
        {
            _product.Add("组件B");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
    class ConcreteBuilder2 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {
            _product.Add("组件X");
        }

        public override void BuildPartB()
        {
            _product.Add("组件Y");
        }

        public override Product GetResult()
        {
            return _product;
        }
    }
    /// <summary>
    /// 建造指挥者
    /// </summary>
    class Director
    {
        /// <summary>
        /// 建造方法，用来指挥建造过程
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(Builder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
