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
    public partial class EngineerForm : Form
    {
        public EngineerForm()
        {
            InitializeComponent();
        }
        public void Init()
        {
            List<SE> engineers = new List<SE>();
            SE jack = new SE("1","三毛","10");
            SE joe = new SE("2","四毛","11");
            SE ema = new SE("3","五毛","10");

            engineers.Add(jack);
            engineers.Add(joe);
            engineers.Add(ema);


            this.dgvEngineers.DataSource = engineers;
        }

        private void 演奏ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayForm frm = new PlayForm();
            DataGridViewRow dr = new DataGridViewRow();
            if (dr == null)
            {
                return;
            }
            string seName = dr.Cells[1].Value.ToString();
            frm.Title = seName + "开始演奏";
            frm.ShowDialog();
        }
    }
}
