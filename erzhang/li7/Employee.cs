using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li7
{
    public class Employee
    {
        public Employee(int id,string name,int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }
        //工号
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
