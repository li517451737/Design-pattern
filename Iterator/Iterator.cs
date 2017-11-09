using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    /// <summary>
    /// Iterator迭代器抽象类
    /// </summary>
    abstract class Iterator
    {
        /// <summary>
        /// 第一个对象
        /// </summary>
        /// <returns></returns>
        public abstract object First();
        /// <summary>
        /// 下一个对象
        /// </summary>
        /// <returns></returns>
        public abstract object Next();
        /// <summary>
        /// 是否到结尾
        /// </summary>
        /// <returns></returns>
        public abstract bool IsDone();
        /// <summary>
        /// 当前对象
        /// </summary>
        /// <returns></returns>
        public abstract object CurrentItem();

    }
    /// <summary>
    /// 聚集抽象类
    /// </summary>
    abstract class Aggregate
    {
        /// <summary>
        /// 创建迭代器
        /// </summary>
        /// <returns></returns>
        public abstract Iterator CreateIterator();
    }
    /// <summary>
    /// 具体聚集类，继承Aggregate
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        /// <summary>
        /// 返回聚集总数
        /// </summary>
        public int Count
        {
            get { return items.Count; }
        }
        /// <summary>
        /// 声明一个索引
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }

    /// <summary>
    /// 具体迭代类
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }

        public override object Next()
        {
            object ret = null;
            current++;
            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
    }

}
