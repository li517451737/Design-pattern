/**
 * 中介者模式：用一个中介对象来封装一系列对象的交互。中介者使各个对象不需要显示地相互引用，从而使其耦合松散，而且可以独立的改变它们间的交互。     
 * 
 * 中介者模式一般应用于一组对象以定义良好但复杂的方式进行通信的场合，以及想定制一个分布在多个类中的行为，而又不想生成太多子类的情况。
 * 中介者模式很容易在系统中应用，也和容易在系统中误用。当系统出现“多对多”交互复杂的对象群时，不要急于使用中介者模式，而要先反思你的系统在设计上是否合理。
 * 
 * 优点：
 *  Mediator的出现减少了各个Colleague的耦合，使得可以独立的改变和复用哥哥Colleague类和Mediator对象。
 *  
 *  缺点：
 *  由于ConcreteMediator控制了集中化，于是就把交互复杂性变为了中介者的复杂性，就使得中介者会变得比任何一个ConcreteCollegue都要复杂。
 */ 
using System;

namespace Mediators
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator m = new ConcreteMediator();
            ConcreteColleagueA c1 = new ConcreteColleagueA(m);
            ConcreteColleagueB c2 = new ConcreteColleagueB(m);

            m.ColleagueA = c1;
            m.ColleagueB = c2;

            c1.SendMessage("吃饭了吗？");
            c2.SendMessage("刚刚吃了，你呢？");


            Console.Read();
        }
    }
}
