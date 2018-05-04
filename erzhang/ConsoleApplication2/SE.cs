using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class SE:Employee
    {
        public SE(int id, string name, int age, int popularity)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.Popularity = popularity;
        }
        public SE() { }
        private int _popularity;

        public int Popularity
        {
            get { return _popularity; }
            set { _popularity = value; }
        }

        public string SayHi()
        {
            string message = string.Format("我是{0},今年{1}岁,工号{2},人气{3}",this.Name,this.Age,this.ID,this.Popularity);
            return message;
        }
    }
}
