using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 状态类，定义一个接口或抽象类，与Context的一个特定状态相关的行为。
    /// </summary>
    abstract class State
    {
        public abstract void Handle(Context context);
    }

    /// <summary>
    /// 具体状态类，每个子类实现一个与Context状态相关的行为
    /// </summary>
    class ConcreteStateA : State
    {
        public override void Handle(Context context)
        {
            //设置ConcreteStateA的下一个状态是ConcreteStateB
            context.State = new ConcreteStateB();
        }
    }

    class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            //设置ConcreteStateB的下一个状态是ConcreteStateA
            context.State = new ConcreteStateA();
        }
    }

    /// <summary>
    /// Context类，维护State子类的实例，定义当前状态的对象
    /// </summary>
    class Context
    {
        private State _state;

        internal State State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine("当前状态为：" + _state.GetType().Name);
            }
        }

        public Context(State state)
        {
            State = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

    }
}
