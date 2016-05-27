using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.Entity
{
    /**************************************************
    策略模式的优点：
    1.减少各种算法类与使用算法类之间的耦合；    
    2.策略模式中的Strategy类为Context定义了一系列的可供重用的算法或行为，继承有助于析取出这些算法中的公共功能；
    3.简化了单元测试，每个算法都是自己的类，可以通过自己的接口单据测试。
    **************************************************/
    public class StrategyContext
    {
        private CashSuper cashSuper;
        public StrategyContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cashSuper = new CashNormal();
                    break;
                case "打九折":
                    cashSuper = new CashRebate("0.9");
                    break;
                case "满300减20":
                    cashSuper = new CashReturn("300", "20");
                    break;
            }
        }

        public decimal ContextInterface(decimal money)
        {
            return cashSuper.AcceptCash(money);
        }
    }
}
