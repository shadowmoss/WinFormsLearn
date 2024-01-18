using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace StudentManager
{
    [Serializable]  // 对象可序列化Attribute
    // 学生实体类
    public class Student
    {
        public string Name { get; set; }

        public string Gender { get; set; }

        public int Age {  get; set; }

        public DateTime BirthDay { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + " " + "Gender: " + Gender + " " + "Age: " + Age + " " + "BirthDay: " + BirthDay + " ";
        }
    }
}
