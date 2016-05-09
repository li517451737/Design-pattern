using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Designpattern
{
    /// <summary>
    /// 建造者接口，每个组装员工都需要实现该接口
    /// </summary>
    public interface IBuilder
    {
        //组装电脑方法
        void BuildParCPU();
        void BuildMainBoard();
        //……
        Computer GetComputer();
    }
}
