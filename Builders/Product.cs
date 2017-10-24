using System;
using System.Collections.Generic;
using System.Text;

namespace Builders
{
    class Product
    {
        /// <summary>
        /// 保存产品部件
        /// </summary>
        private IList<string> _parts;

        public Product()
        {
            _parts = new List<string>();
        }
        /// <summary>
        /// 添加产品部件
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            _parts.Add(part);
        }
        /// <summary>
        /// 列举所有产品部件
        /// </summary>
        public void Show()
        {
            Console.WriteLine("\n产品 创建------");
            foreach (var item in _parts)
            {
                Console.WriteLine(item);
            }
        }
    }
}
