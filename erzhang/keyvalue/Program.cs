using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyvalue
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable table = new Hashtable();
            table.Add("CBC","中国建设银行");
            table.Add("ABC","中国农业银行");

            //通过key获取value
            foreach (string key in table.Keys)
            {
                Console.WriteLine(key);
                Console.WriteLine(table[key]);
            }
            Console.WriteLine("========================");

            //直接获取value
            foreach (string value in table.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("========================");

            //同时迭代key+value
            foreach (DictionaryEntry item in table)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }
            Console.ReadLine();
        }
    }
}
