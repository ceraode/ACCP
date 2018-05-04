using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }

        public string Title
        {
            set
            {
                this.gbPlay.Text = value;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SE engineer = new SE();
            Instrument instrument = null;
            if (this.rbtnSachs.Checked)
            {
                instrument = new Sachs();
            }
            else if (this.rbtnPiano.Checked)
            {
                instrument = new Piano();
            }
            else if (this.rbtnViolin.Checked)
            {
                instrument = new Violin();
            }
            engineer.Play(instrument);
        }

        public string Title { get; set; }

        private void rbtnViolin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
