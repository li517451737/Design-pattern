using System;
using System.Collections.Generic;
using System.Text;

namespace Facades
{
    /**
     * 子系统类集合，实现子系统功能，处理Facade对象指派任务，子类中没有任何Facade的引用
     * 
     */

    /// <summary>
    /// 子系统一
    /// </summary>
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("子系统方法一");
        }
    }
    /// <summary>
    /// 子系统二
    /// </summary>
    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("子系统方法二");
        }
    }

    /// <summary>
    /// 子系统三
    /// </summary>
    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("子系统方法三");
        }
    }
    /// <summary>
    /// 子系统四
    /// </summary>
    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("子系统方法四");
        }
    }
    /// <summary>
    /// 外观类
    /// </summary>
    class Facade
    {
        SubSystemOne one;

        SubSystemTwo two;

        SubSystemThree three;

        SubSystemFour four;

        /// <summary>
        /// 外观类，它需要了解所有子系统的方法或属性进行组合，以便外界调用
        /// </summary>
        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("方法组A:");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("方法组B:");
            one.MethodOne();
            three.MethodThree();
        }
    }
}
