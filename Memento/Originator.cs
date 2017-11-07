using System;
using System.Collections.Generic;
using System.Text;

namespace Memento
{
    /// <summary>
    /// 发起人
    /// </summary>
    class Originator
    {
        private string state;

        public string State { get => state; set => state = value; }

        /// <summary>
        /// 创建备忘录，将当前需要保存的数据信息导入并实例化一个Memento对象
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(state);
        }
        /// <summary>
        /// 恢复备忘录，将Memento导入并恢复相关数据
        /// </summary>
        /// <param name="memento"></param>
        public void SetMemento(Memento memento)
        {
            state = memento.State;
        }
        /// <summary>
        /// 显示数据
        /// </summary>
        public void Show()
        {
            Console.WriteLine("当前状态为：" + state);
        }

    }

    class Memento
    {
        private string state;
        public Memento(string state)
        {
            this.state = state;
        }
        /// <summary>
        /// 需要保存的数据属性，可以是多个对象
        /// </summary>
        public string State
        {
            get { return state; }
        }
    }
    /// <summary>
    /// 管理者
    /// </summary>
    class Caretaker
    {
        /// <summary>
        /// 备忘录属性，得到或设置备忘录
        /// </summary>
        public Memento Memento
        {
            get;
            set;
        }
    }
}
