using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li13
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList()
            {
                new SE() {name = "挪威的森林"},
                new SE() {name = "心"}
            };
            foreach (SE item in list)
            {
                Console.WriteLine(item.name);
            }
            Console.ReadLine();
        }
    }
}
