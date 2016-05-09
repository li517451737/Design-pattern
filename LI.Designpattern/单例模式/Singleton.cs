using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LI.Designpattern
{
    /// <summary>
    /// 单例模式，确保一个类只有一个实例，并提供一个全局访问点
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 定义私有变量保存类的实例
        /// </summary>
        private Singleton instence;
        /// <summary>
        /// 定义一个标识符，确保线程同步
        /// </summary>
        private readonly static object locker = new object();
        /// <summary>
        /// 私有的构造方法，外界不能创建该类的实例
        /// </summary>
        private Singleton() { }

        /// <summary>
        /// 唯一的全局访问点
        /// </summary>
        public Singleton Instence
        {
            get
            {
                //当第一个线程运行到此处时，会对locker加锁
                //当第二个线程运行到此处时，首先检查locker对象为“加锁”状态，该线程就会挂起等待第一个线程解锁
                //当第一个线程运行解锁，就会对locker解锁
                if (instence == null)   //双重锁定，降低对locker对象不必要的检测
                {
                    lock (locker)   
                    {
                        if (instence == null)
                        {
                            instence = new Singleton();
                        }
                    } 
                }
                return instence;
            }
        }
    }
}
