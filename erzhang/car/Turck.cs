using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car
{
    public class Turck:Vehicle
    {
        public Turck(string xh, string cd) : base(xh, cd) { }
        public void TruckRun()
        {
            Console.WriteLine(string.Format("型号{0},产地{1}",this.XingHao,this.ChanDi));
        }
    }
}
