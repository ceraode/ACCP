using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficTool
{
    class Program
    {
        static void Main(string[] args)
        {
            SE se = new SE("111","张三",20);
            SE s = new SE("112","王五",22);
            PM pm = new PM("113","李四",30);
            List<Employee> empls = new List<Employee>();
            empls.Add(se);
            empls.Add(s);
            empls.Add(pm);

            empls[0].GoHome(new Bicycle());
            empls[1].GoHome(new Tube());
            empls[2].GoHome(new Car());

            Console.ReadLine();
        }
    }
}
