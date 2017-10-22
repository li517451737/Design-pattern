using System;
using System.Collections.Generic;
using System.Text;

namespace Proxies.GiveGift
{
    /// <summary>
    /// 女孩类
    /// </summary>
    class Girl
    {
        public Girl(string name)
        {
            _name = name;
        }

        private string _name;

        public string Name { get => _name; set => _name = value; }
    }
}
