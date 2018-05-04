using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Vehicle
    {

        public Vehicle(string xh, string cd)
        {
            this.XingHao = xh;
            this.ChanDi = cd;
        }

        //型号
        public string XingHao { get; set; }

        //产地
        public string ChanDi { get; set; }

        public void VehicleRun()
        {
            Console.WriteLine("汽车正在行驶");
        }
    }
}
