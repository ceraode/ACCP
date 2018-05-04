using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            SE engineer = new SE(112,"任正非",25,100);
            Console.WriteLine(engineer.SayHi());

            PM pm = new PM(890,"盖茨",50,30);
            Console.WriteLine(pm.SayHi());

            Console.ReadLine();
        }
    }
}
