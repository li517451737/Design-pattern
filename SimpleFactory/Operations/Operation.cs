/***
 * 
 *1.不能被实例化；
  2.抽象类可以包括抽象方法，这是其他普通类所不能的；
  3.抽象方法只能声明于抽象类中，且不包含任何实现，派生类必须覆盖他们；
  4.抽象类可以派生自一个抽象类，可以覆盖基类的抽象方法也可以不覆盖，如果不覆盖，则其派生类必须覆盖它们；
 * 
 */
namespace SimpleFactory.Operations
{
    /// <summary>
    /// 算法抽象类
    /// </summary>
    public abstract class Operation
    {
        private double _numberA;
        private double _numberB;
        public double NumberA { get => _numberA; set => _numberA = value; }
        public double NumberB { get => _numberB; set => _numberB = value; }

        /// <summary>
        /// 抽象方法，计算结果
        /// </summary>
        /// <returns></returns>
        public abstract double GetResult();
    }
}
