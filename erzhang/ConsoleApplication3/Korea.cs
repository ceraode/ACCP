﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Korea:Person
    {
        public virtual void SayHello()
        {
            Console.WriteLine("韩国");
        }
    }
}
