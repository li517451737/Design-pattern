using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    /// <summary>
    /// 客户所期待的接口。目标可以是具体的或抽象的类，也可以是接口
    /// </summary>
    class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }

    /// <summary>
    /// 需要适配的类
    /// </summary>
    class Adaptee
    {
        public void SpecificRequeset()
        {
            Console.WriteLine("特殊请求！");
        }

    }
    /// <summary>
    /// 适配器类，在内部包装一个Adaptee对象，将源接口转换为目标接口
    /// </summary>
    class Adapter : Target
    {
        private Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequeset();
        }
    }
}
