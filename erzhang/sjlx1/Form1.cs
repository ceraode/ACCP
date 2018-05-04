using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sjlx1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, Book> dic = new Dictionary<string, Book>();

            Book b1 = new Book();
            b1.name = "挪威的森林";
            b1.book = 10;

            dic.Add(b1.name,b1);

            BindingSource bs = new BindingSource();

            bs.DataSource = dic.Values;

            dataGridView1.DataSource = bs;
        }
    }
}
