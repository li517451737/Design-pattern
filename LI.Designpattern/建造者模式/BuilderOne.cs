using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Designpattern
{
    /// <summary>
    /// 具体的组装者，实现IBuilder接口
    /// </summary>
    public class BuilderOne : IBuilder
    {
        Computer computer = new Computer();
        public void BuildMainBoard()
        {
            computer.Add("B75");

        }
        public void BuildParCPU()
        {
            computer.Add("I5");
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
    /// <summary>
    /// 组装者二
    /// </summary>
    public class BuilderTwo : IBuilder
    {
        Computer computer = new Computer();
        public void BuildMainBoard()
        {
            computer.Add("B85");
        }

        public void BuildParCPU()
        {
            computer.Add("I7");
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
