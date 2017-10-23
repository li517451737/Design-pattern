using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class TestPager
    {
        public void TestQuestion1()
        {
            Console.WriteLine("问题1");
            Console.WriteLine("答案:" + Answer1());
        }
        public void TestQuestion2()
        {
            Console.WriteLine("问题2");
            Console.WriteLine("答案:" + Answer2());
        }
        public void TestQuestion3()
        {
            Console.WriteLine("问题3");
            Console.WriteLine("答案:" + Answer3());
        }

        //此处虚方法的目的是给子类重写，因为每个人得答案不一样。

        public virtual string Answer1()
        {
            return "";
        }
        public virtual string Answer2()
        {
            return "";

        }
        public virtual string Answer3()
        {
            return "";
        }
    }

    class TestPagerA : TestPager
    {
        public override string Answer1()
        {
            return "a";
        }
        public override string Answer2()
        {
            return "b";
        }
        public override string Answer3()
        {
            return "c";
        }
    }
    class TestPagerB : TestPager
    {
        public override string Answer1()
        {
            return "a1";
        }
        public override string Answer2()
        {
            return "b1";
        }
        public override string Answer3()
        {
            return "c1";
        }
    }
}
