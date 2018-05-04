using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li3
{
    public class PM:Employee
    {
        public PM(string id, string name, int age, int yearOfExperience)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.YearOfExperience = yearOfExperience;
        }
        public PM() { }
        public string SayHi()
        {
            string message;
            message = string.Format("工号{0},姓名{1},年龄{2},工作经验{3}年", this.ID, this.Name, this.Age, this.YearOfExperience);
            return message;
        }
    }
}
