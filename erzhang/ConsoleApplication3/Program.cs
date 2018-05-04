using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Chinese chinese = new Chinese();
            American american = new American();
            Korea korea = new Korea();

            List<Person> list = new List<Person>();
            list.Add(chinese);
            list.Add(american);
            list.Add(korea);

            foreach (Person item in list)
            {
                item.SayHello();
            }
            Console.ReadLine();
        }
    }
}
