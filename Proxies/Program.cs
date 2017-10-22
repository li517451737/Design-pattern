/****
 * 代理模式：为其他对象提供一种代理以控制对这个对象的访问。
 * 应用：
 * 1. 远程代理，也就是为一个对象在不同的地址空间提供局部代表。这样可以隐藏一个对象存在与不同的地址空间的事实；
 * 2. 虚拟代理，是根据需要创建开销很大的对象。通过它来存放实例化需要很长时间的真是对象；
 * 3. 安全代理，用来控制真实对象访问时的权限。
 * 4. 智能引用，是指当调用真实对象时，代理处理另外的一些事。
 * 
 * 
 */


using Proxies.GiveGift;
using System;

/// <summary>
/// 代理模式实例，追求者通过代理给女孩送礼物
/// </summary>
namespace Proxies
{
    class Program
    {
        static void Main(string[] args)
        {

            Proxy proxy = new Proxy(new Girl("小红"));

            proxy.GiveChocolate();
            proxy.GiveDolls();
            proxy.GiveFlowers();

            Console.ReadKey();
        }
    }
}
