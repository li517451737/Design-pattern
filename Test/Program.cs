using LI.Designpattern;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 简单工厂模式测试
            //Food food1 = FoodSimpleFactory.CreateFood("番茄炒蛋");
            //food1.Print();
            //Food food2 = FoodSimpleFactory.CreateFood("土豆肉丝");
            //food2.Print();
            #endregion

            #region 工厂方法模式
            //Creator PotatoesFactory = new ShreddedPorkWithPotatoesFactory();
            //Creator TomatoFactory = new TomatoScrambledEggsFactory();

            //Food Potatoes = PotatoesFactory.CreateFoodFactory();
            //Potatoes.Print();

            //Food Tomatoes = TomatoFactory.CreateFoodFactory();
            //Tomatoes.Print();
            #endregion

            #region Json序列化
            Person p1 = new Person() { Name = "+张三", Age = 25, Sex = "男" };
            //实体转换为json字符串
            string json = JsonConvert.SerializeObject(p1);
            Console.WriteLine(json);
            //json字符串转换为实体
            Person p2 = JsonConvert.DeserializeObject<Person>(json);
            if (p2 != null)
            {
                Console.WriteLine(p2.Name);
            } 
            #endregion

            Console.ReadKey();
        }
    }
}
