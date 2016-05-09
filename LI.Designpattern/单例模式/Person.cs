using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace LI.Designpattern
{
    [Serializable]
    [DataContract]
    public class Person
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [DataMember]
        public int Age { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [DataMember]
        public string Sex { get; set; }
    }
}
