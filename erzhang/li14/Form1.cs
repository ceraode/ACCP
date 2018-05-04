using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace li14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class ComboBoxItem<T>
        {
            private string _itemText;
            public string ItemText
            {
                get { return _itemText; }
                set{_itemText = value;}
            }

            private T _itemValue;
            public T ItemValue
            {
                get { return _itemValue; }
                set { _itemValue = value;}
            }
        }

        ComboBoxItem<SE> itemJack = new ComboBoxItem<SE>();
        itemJack.ItemText = jack.Name;
        itemJack.ItemValue = jack;

        ComboBoxItem<SE> itemJoe = new ComboBoxItem<SE>();
        itemJoe.ItemText = joe.Name;
        itemJoe.ItemValue = joe;

        List<ComboBoxItem<SE>> items = new List<ComboBoxItem<SE>>();
        items.Add(itemJack);
        items.Add(itemJoe);

        this.cmbEngineers.DataSource = items;
        this.cmbEngineers.DisplayMember = "ItemText";
        this.cmbEngineers.ValueMember = "ItemValue";

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEngineers.SelectedIndex>0)
	{
		 SE se = (SE)cmbEngineers.SelectedValue;
         MessageBox.Show(string.Format("工号:{0}",se.ID.ToString()));
	}
        }
    }
}
