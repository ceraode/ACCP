using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music
{
    public class Instrument
    {
        public virtual void Play()
        {
            MessageBox.Show("乐器演奏","信息",MessageBoxButtons.OK);
        }
    }
}
