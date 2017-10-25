using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    /// <summary>
    /// 主题或抽象通知类，一般使用抽象类或接口实现，它把所有观察者保存在一个集合里面，并提供一个接口，可以增加、删除观察者
    /// </summary>
    abstract class Subject
    {
        /// <summary>
        /// 所有观察者集合
        /// </summary>
        private IList<Observer> observers = new List<Observer>();

        /// <summary>
        /// 增加观察者
        /// </summary>
        /// <param name="observer"></param>
        public virtual void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        /// <summary>
        /// 移除观察者
        /// </summary>
        /// <param name="observer"></param>
        public virtual void Detach(Observer observer)
        {
            observers.Remove(observer);
        }
        /// <summary>
        /// 通知方法
        /// </summary>
        public virtual void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }

    }
    /// <summary>
    /// 观察者接口，得到主题通知时更新自己，更新接口通常包含一个Updatea()方法
    /// </summary>
    interface Observer
    {
        void Update();
    }
    /// <summary>
    /// 具体的主题或通知者，将有关状态存入具体的观察者对象，在内部状态改变时，给所注册过的观察者发出通知
    /// </summary>
    class ConcreteSubject : Subject
    {
        private string _subjectState;
        /// <summary>
        /// 具体观察者状态
        /// </summary>
        public string SubjectState { get => _subjectState; set => _subjectState = value; }

    }
    /// <summary>
    /// 具体观察者，实现抽象观察者所要求的更新接口，以便使本身状态与主题状态相协调。具体观察者可以保存一个指向具体主题(通知者)的引用
    /// </summary>
    class ConcreteObserver : Observer
    {
        private string _name;

        private string _observerState;

        private ConcreteSubject _subject;

        internal ConcreteSubject Subject { get => _subject; set => _subject = value; }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._name = name;
            this._subject = subject;
        }

        public void Update()
        {
            this._observerState = _subject.SubjectState; //设置观察者的状态为通知的状态
            Console.WriteLine("观察者{0}的状态是：{1}", _name, _observerState);
        }
    }
}
