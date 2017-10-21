using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Finerlies
{
    class Finerly : Person
    {
        protected Person _person;

        public virtual void Decoteter(Person person)
        {
            _person = person;
        }

        public override void Show()
        {
            if (_person != null)
            {
                _person.Show();
            }
        }
    }

    class TShirts : Finerly
    {
        public override void Show()
        {
            Console.WriteLine("大T恤"); //扩展
            base.Show();
        }
    }

    class BigTrouser : Finerly
    {
        public override void Show()
        {
            Console.WriteLine("垮裤"); //扩展
            base.Show();
        }
    }

    class WearSneakers : Finerly
    {
        public override void Show()
        {
            Console.WriteLine("破球鞋"); //扩展
            base.Show();
        }
    }
}
