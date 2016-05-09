using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
工厂方法模式通过面向对象编程中的多态性来将对象的创建延迟到具体工厂中，从而解决了简单工厂模式中存在的问题，
也很好地符合了开放封闭原则（即对扩展开发，对修改封闭）。
*/
namespace LI.Designpattern
{
    /// <summary>
    /// 工厂抽象类，任何具体工厂都必须继承该抽象类
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// 创建食物
        /// </summary>
        /// <returns></returns>
        public abstract Food CreateFoodFactory();
    }
}
