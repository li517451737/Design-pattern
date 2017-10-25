/***
 * 观察者模式：定义一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。这个主题对象在状态发生
 * 变化时，会通知所有观察者对象，使它们能够自动更新自己。
 * 
 * 适用场景：
 *  1. 当一个对象的改变需要同时改变其他对象而且它不知道具体有多少个对象待改变时，应该就可以考虑适用观察者模式。
 *  2. 
 * 
 */ 

using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("传统观察者模式-----");

            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "李四"));
            s.Attach(new ConcreteObserver(s, "张三"));
            s.Attach(new ConcreteObserver(s, "王二"));

            s.SubjectState = "工作ing";
            s.Notify();


            Console.Read();
        }
    }
}
