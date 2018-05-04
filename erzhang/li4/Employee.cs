using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li4
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("父类无参对象构造执行!");
        }
        public Employee(string id, int age, string name,int popularity)
        {
            this.ID = id;
            this.Age = age;
            this.Name = name;
            this.Popularity = popularity;
        }
        //工号
        protected string ID { get; set; }

        //年龄
        protected int Age { get; set; }

        //姓名
        protected string Name { get; set; }

        protected int Popularity { get; set; }
    }
}
