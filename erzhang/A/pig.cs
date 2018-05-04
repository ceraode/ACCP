using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
     public class pig:Sleep,Ieat,Irun
    {
         public void eat()
         {
             Console.WriteLine("小猪吃");
         }
         public void run()
         {
             Console.WriteLine("小猪跑");
         }
         public override void Sleep()
         {
             Console.WriteLine("pig sleep");
         }
    }
}
