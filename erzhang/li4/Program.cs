using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li4
{
    class Program
    {
        static void Main(string[] args)
        {
            SE se = new SE("任正非", 10, "10", 3000);
            PM pm = new PM("王健林",1,"30",1000);
            List<Employee> empls = new List<Employee>();
            empls.Add(se);
            empls.Add(pm);
            foreach (Employee empl in empls)
            {
                if (empl is SE)
                {
                    Console.WriteLine(((SE)empl).SayHi);
                }
                if (empl is PM)
                {
                    Console.WriteLine(((PM)empl).SayHi);
                }
            }
        }
    }
}
