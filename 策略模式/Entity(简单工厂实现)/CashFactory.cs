using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 简单工厂模式，实现简单收银流程
/// </summary>
namespace 策略模式.Entity
{
    public class CashFactory
    {
        //收费工厂
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper sa = null;
            switch (type)
            {
                case "正常收费":
                    sa = new CashNormal();
                    break;
                case "打九折":
                    sa = new CashRebate("0.9");
                    break;
                case "满300减20":
                    sa = new CashReturn("300","20");
                    break;
            }
            return sa;
        }

    }
}
