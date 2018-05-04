using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music
{
    public class Sachs:Instrument
    {
        public override void Play()
        {
            MessageBox.Show("萨克斯演奏", "信息", MessageBoxButtons.OK);
        }
    }
}
