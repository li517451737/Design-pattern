/***
 * 原型模式：用原型实例指定创建对象的种类，并且通过拷贝这些原型创建新的对象。
 *          原型模式其实就是从一个对象再创建另一个可定制的对象，且不需要知道任何创建过程。
 * 
 * 在.NET中使用System命名空间下的ICloneable接口即可实现原型模式。
 * 
 * 浅复制vs深复制
 * MemberwiseClone()方法是浅复制,原理：如果字段是值类型则，则对该字段执行逐位复制，如果是引用类型，则复制引用而不复制引用的对象。
 * 深复制：把引用对象的变量指向复制过来的新对象，而不是原有的被引用的对象。
 */


using System;

namespace Prototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume a = new Resume("小李");
            a.SetPersonalInfo("男", 26);
            a.SetWorkExperience("2015-2017", "IWIT");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("2013-2015", "哇哈哈");

            a.Display();
            b.Display();
            Console.Read();
        }
    }
}
