﻿/**
 * 适配器模式：将一个类的接口转换成客户希望的另一个接口。Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
 * 
 * 系统的行为和数据都正确。但接口不符时，我们应该考虑用适配器，目的是使控制范围之外的一个原有对象与某个接口匹配。适配器模式主要适用于希望复用一些现存的类，但是接口又与复用环境要求不一致的情况。
 * 
 * 
 */ 

using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //客户端直接调用Target的Request方法
            Target target = new Adapter();
            target.Request();

            Console.Read();
        }
    }
}
