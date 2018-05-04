using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TC
    {
        public TC() { }

        public TC(string name, Dictionary<string, JG> jg)
        {
            this.JGName = name;
            this.jg = jg;
        }
    }
}
