/**
 * 访问者模式（Visitor）：表示作用于某对象结构中的各元素的操作。他使你可以在不改变各元素得类的前提下定义作用于这些元素的新操作。
 * 
 * 
 */ 

using System;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructrue obj = new ObjectStructrue();
            obj.Attch(new Woman());
            obj.Attch(new Man());
            //成功状态
            Success success = new Success();
            obj.Display(success);

            //失败状态
            Fail fail = new Fail();
            obj.Display(fail);

            Amativeness amativeness = new Amativeness();
            obj.Display(amativeness);

            Console.Read();
        }
    }
}
