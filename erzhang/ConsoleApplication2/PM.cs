using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class PM:Employee
    {
        public PM(int id, string name, int age, int yearOfExperience)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
            this.YearOfExperience = yearOfExperience;
        }
        public PM() { }

        //资历
        private int _yearOfExperience;

        public int YearOfExperience
        {
            get { return _yearOfExperience; }
            set { _yearOfExperience = value; }
        }

        public string SayHi()
        {
            string message;
            message = string.Format("大家好，我是{0},今年{1}岁，项目管理经验{2}年",this.Name,this.Age,this.YearOfExperience);
            return message;
        }
    }
}
