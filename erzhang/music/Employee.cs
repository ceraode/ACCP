using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music
{
    public class Employee
    {
        public Employee() { }
        public Employee(string id,string name,string age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }
        public string ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
