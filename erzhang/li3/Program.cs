using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li3
{
    class Program
    {
        static void Main(string[] args)
        {
            PM pm = new PM("890","盖茨",50,300);
            Console.WriteLine(pm.SayHi());
            Console.ReadLine();
        }
    }
}
