/**
 * 单例模式：保证一个类仅有一个实例，并提供一个访问它的全局访问点。
 * 
 * lock是确保当一个线程位于代码临界区时，另一个线程不进入临界区。如果有其他线程试图进入锁定的代码，则它将一直等待，直到该对象被释放。
 * 
 */ 

using System;
using System.Collections.Generic;
using System.Text;

namespace Singletons
{
    /// <summary>
    /// 懒汉式单例模式  在第一次调用时才会实例化
    /// </summary>
    public class Singleton
    {
        private static Singleton _singleton;

        private static readonly object syncLock = new object();//程序运行时，创建一个静态只读的进程辅助对象。

        /// <summary>
        /// 私有构造方法，防止外界实例化
        /// </summary>
        private Singleton() { }

        /// <summary>
        /// 全局访问点，获取唯一实例
        /// </summary>
        /// <returns></returns>
        public Singleton GetInstance()
        {
            //先判断对象实例是否存在，不存在再加锁处理，避免每次获取实例时，都会加锁，提高性能。
            if (_singleton == null)
            {
                //在同一时刻，加锁的程序是能有一个线程进入。
                lock (syncLock)
                {
                    if (_singleton == null)
                    {
                        _singleton = new Singleton();
                    }
                }
            }
            return _singleton;
        }

    }
    /// <summary>
    /// sealed  防止类被继承  俗称饿汉式单例模式，在类被加载时就会实例化
    /// </summary>
    public sealed class Singletion1
    {
        private static readonly Singletion1 _instance = new Singletion1();

        private Singletion1() { }

        public Singletion1 GetInstance()
        {
            return _instance;
        }
    }
}
