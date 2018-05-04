using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li4
{
    class PM : Employee
    {
        public PM(string id, int age, string name, int popularity)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Popularity = popularity;
        }
        public PM() { }

        public string SayHi()
        {
            string message = string.Format("我是{0},今年{1}，工号,{2},人气{3}", this.Name, this.Age, this.ID, this.Popularity);
            return message;
        }
    }
}