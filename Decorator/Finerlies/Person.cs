using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Finerlies
{
    /// <summary>
    /// 装扮人类
    /// </summary>
    class Person
    {
        /// <summary>
        /// 姓名
        /// </summary>
        private string _name;

        public Person() { }

        public Person(string name)
        {
            _name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}", _name);
        }
    }
}
