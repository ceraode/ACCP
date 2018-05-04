using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        //姓名
        public string Name { get; set; }

        //编号
        public string ID { get; set; }

        //年龄
        public int Age { get; set; }
        
        //PM类构造函数
        public Program(string id,string name,int age)
        {
            this.ID = id;
            this.Name = name;
            this.Age = age;
        }

        static void Main(string[] args)
        {
            Program engineer = new Program("112", "隔壁老王", 10);
            foreach (string er in engineer)
            {
                Console.WriteLine(er);
            }

            Console.ReadLine();
        }
    }
}
