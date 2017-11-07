/**
 * 备忘录模式：在不破坏封装性的前提下，捕获一个对象的内部状态，并在该对象之外保存这个状态。这样以后就可以将该对象恢复到原先保存的状态。
 * 
 * 备忘录模式比较适用于功能比较复杂的，但需要维护或记录属性历史的类，或需要保存的属性只是众多属性中的一小部分时，Originator可以根据保存的Memento信息还原到前一状态。
 * 例如：当角色状态改变时，有可能这个状态无效，这时候就可以使用暂时储存起来的备忘录将角色状态还原。
 */ 
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On"; //Originator初始状态为 “On”
            o.Show();

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            o.State = "Off"; //改变状态属性
            o.Show();

            o.SetMemento(c.Memento); // 通过备忘录恢复初始状态
            o.Show();

            Console.Read();
        }
    }
}
