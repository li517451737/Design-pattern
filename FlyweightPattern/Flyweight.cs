using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FlyweightPattern
{
    /// <summary>
    /// 所有具体享元类的超类或接口，通过这个接口，Flyweight可以接受并作用于外部状态
    /// </summary>
    abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
    /// <summary>
    /// 继承Flyweight，并为内部状态增加储存空间。
    /// </summary>
    class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("具体共享对象：" + extrinsicstate);
        }
    }
    /// <summary>
    /// 实现不需要共享的子类。因为Flyweight接口使共享成为可能，但它并不强制共享
    /// </summary>
    class UnshardConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("不共享的具体对象：" + extrinsicstate);

        }
    }
    /// <summary>
    /// 享元工厂，用来创建和管理Flyweight对象
    /// </summary>
    class FlyweightFactory
    {
        private Hashtable flyweights = new Hashtable();

        /// <summary>
        /// 根据客户端请求，获取享元实例
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public Flyweight GetFlyweight(string key)
        {
            if (!flyweights.ContainsKey(key))
            {
                flyweights.Add(key, new ConcreteFlyweight());
            }
            return (Flyweight)flyweights[key];
        }
    }
}
