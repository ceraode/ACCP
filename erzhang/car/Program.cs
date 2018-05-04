using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            Turck tk = new Turck("大众","德国");
            tk.VehicleRun();
            tk.TruckRun();
            Console.ReadLine();
        }
    }
}
