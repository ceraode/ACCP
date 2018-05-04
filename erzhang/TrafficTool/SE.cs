using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficTool
{
    class SE:Employee
    {
        public SE(string id, string name, int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }
        public SE() { }

        public string SayHi()
        {
            string message = string.Format("我是{0},今年{1}，工号,{2}}", this.Name, this.Age, this.ID);
            return message;
        }
    }
}
