using System;
using System.Collections.Generic;
using System.Text;

namespace Prototypes
{
    /// <summary>
    /// 简历类，实现ICloneable接口
    /// </summary>
    class Resume : ICloneable
    {
        private string _name;
        private string _sex;
        private int _age;
        WorkExperience WorkArea { get; set; }
        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public int Age { get => _age; set => _age = value; }

        public Resume(string name)
        {
            Name = name;
            WorkArea = new WorkExperience();
        }
        /// <summary>
        /// 私有构造方法，复制工作区域
        /// </summary>
        /// <param name="workArea"></param>
        private Resume(WorkExperience workArea)
        {
            WorkArea = (WorkExperience)workArea.Clone();
        }
        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex"></param>
        /// <param name="age"></param>
        public void SetPersonalInfo(string sex, int age)
        {
            Sex = sex;
            Age = age;
        }

        /// <summary>
        /// 设置工作经历
        /// </summary>
        /// <param name="timeArea"></param>
        /// <param name="company"></param>
        public void SetWorkExperience(string timeArea, string company)
        {
            WorkArea.TimeArea = timeArea;
            WorkArea.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}{1}{2}", Name, Sex, Age);
            Console.WriteLine("工作经历：{0} {1}", WorkArea.TimeArea, WorkArea.Company);

        }

        public object Clone()
        {
            //添加深复制,调用私有构造方法，克隆“工作区域”,然后给简历对象赋值，最后返回一个深复制的简历对象
            Resume obj = new Resume(WorkArea);
            obj.Name = this._name;
            obj.Sex = _sex;
            obj.Age = _age;

            //MemberwiseClone() 方法是浅复制，只会复制引用类型的引用
            //return (object)this.MemberwiseClone();
            return obj;
        }
    }
    /// <summary>
    /// 工作区域类
    /// </summary>
    class WorkExperience : ICloneable
    {
        private string _timeArea;
        private string _company;

        public string TimeArea { get => _timeArea; set => _timeArea = value; }
        public string Company { get => _company; set => _company = value; }

        public object Clone()
        {
            return (WorkExperience)this.MemberwiseClone();
        }
    }
}
