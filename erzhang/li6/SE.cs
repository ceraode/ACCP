using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace li6
{
    public class SE
    {
        public int BasePay { get; set; }
        public int MeritPay { get; set; }

        public string name { get; set; }
        public SE(string name)
        {
            this.name = name;
        }
    }
}
