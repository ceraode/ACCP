using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficTool
{
    class PM : Employee
    {
        public PM(string id, string name, int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }
        public PM() { }

        public string SayHi()
        {
            string message = string.Format("我是{0},今年{1}，工号,{2}}", this.Name, this.Age, this.ID);
            return message;
        }
    }
}