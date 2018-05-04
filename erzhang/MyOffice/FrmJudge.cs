using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOffice
{
    public partial class FrmJudge : Form
    {
        public ListViewItem selectItem = null;
        public FrmJudge()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selectItem.SubItems[3].Text = textBox2.Text;
            selectItem.SubItems[4].Text = textBox3.Text;
            this.Close();
        }

        private void FrmJudge_Load(object sender, EventArgs e)
        {
            textBox1.Text = selectItem.SubItems[1].Text;
            textBox1.ReadOnly = true;
        }
    }
}
