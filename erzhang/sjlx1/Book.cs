using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sjlx1
{
    public class Book
    {
        public string  name { get; set; }
        public int book { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}
