using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*简单工厂模式的优点：
    1.解决了客户端直接依赖具体的对象，降低了对象间的耦合性
*   2.实现的代码复用的作用
 简单工厂模式的缺点：
    1. 工厂类中集中了所有的逻辑，一旦不能正常工作，整个系统都会受到影响；
    2. 系统扩展困难，一旦添加新的产品，就不得不修改工厂逻辑，会导致工厂逻辑过于复杂。

简单工厂模式的应用场景：
    1.当工厂类负责创建的对象比较少时，可以使用简单工厂模式；
    2.客户只知道传入工厂类的参数，不关心创建对象的逻辑时，可以使用简单工厂模式。
*/
namespace LI.Designpattern
{
    /// <summary>
    /// 炒菜工厂类
    /// 简单工厂类，即是：负责生产对象的一个类
    /// 该原则就是封装改变，既然要封装改变，自然也就要找到改变的代码，然后把改变的代码用类来封装
    /// </summary>
    public class FoodSimpleFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            switch (type)
            {
                case "番茄炒蛋":
                    food = new TomatoScrambledEggs();
                    break;
                case "土豆肉丝":
                    food = new ShreddedPorkWithPotatoes();
                    break;
                default:
                    food = null;
                    break;
            }
            return food;
        }
    }
}
