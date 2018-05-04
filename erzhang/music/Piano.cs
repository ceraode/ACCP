using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace music
{
    public class Piano:Instrument
    {
        public override void Play()
        {
            MessageBox.Show("钢琴演奏", "信息", MessageBoxButtons.OK);
        }
    }
}
