using System;
using System.Collections.Generic;
using System.Text;

namespace Proxies.GiveGift
{
    /// <summary>
    /// 代理类
    /// </summary>
    class Proxy : IGiveGift
    {
        Pursuit gg;

        public Proxy(Girl mm)
        {
            gg = new Pursuit(mm);//通过代理，实例化追求者，Girl并不知道
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
