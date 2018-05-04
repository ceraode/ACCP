using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficTool
{
    public class Employee
    {
        public Employee(){}

        public Employee(string id, string name, int age)
        {
            Console.WriteLine("有参");
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }

        protected string ID { get; set; }
        protected string Name { get; set; }
        protected int Age { get; set; }

        public virtual string SayHi()
        {
            return "员工类";
        }
        public void GoHome(Ttl tool)
        {
            tool.Run();
        }
    }
}
