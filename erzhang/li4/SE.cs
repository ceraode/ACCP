using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li4
{
    class SE:Employee
    {
        public SE(string id, int age, string name, int popularity)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Popularity = popularity;
        }
        public SE() { }

        public string SayHi()
        {
            string message = string.Format("我是{0},今年{1}，工号,{2},人气{3}", this.Name, this.Age, this.ID, this.Popularity);
            return message;
        }
    }
}
