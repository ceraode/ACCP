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
    public partial class FrmShow : Form
    {
        public FrmShow()
        {
            InitializeComponent();
        }
        //容纳5人的容器
        public Employee[] emps = new Employee[5];
        private void FrmShow_Load(object sender, EventArgs e)
        {
            listView1.MultiSelect = false;
            listView1.FullRowSelect = true;//选中整行
            LoadData();



            foreach (var item in emps)
            {

                ListViewItem lvItem = new ListViewItem(item.EmpID);
                lvItem.SubItems.Add(item.EmpName);
                lvItem.SubItems.Add(item.EmpAge.ToString());
                lvItem.SubItems.Add(item.EemAssert);
                lvItem.SubItems.Add(item.EmpScore.ToString());

                //将内存中游离的一行，bind到lvList上
                listView1.Items.Add(lvItem);
            }
           
        }

        private void LoadData()
        {
            emps[0] = new Employee();
            emps[0].EmpID = "1";
            emps[0].EmpName = "夏目漱石";
            emps[0].EmpAge = 33;
            emps[0].EemAssert = string.Empty;
            emps[0].EmpScore = 0;

            emps[1] = new Employee();
            emps[1].EmpID = "2";
            emps[1].EmpName = "芥川龙之介";
            emps[1].EmpAge = 33;
            emps[1].EemAssert = string.Empty;
            emps[1].EmpScore = 0;

            emps[2] = new Employee();
            emps[2].EmpID = "3";
            emps[2].EmpName = "村上春树";
            emps[2].EmpAge = 33;
            emps[2].EemAssert = string.Empty;
            emps[2].EmpScore = 0;

            emps[3] = new Employee();
            emps[3].EmpID = "4";
            emps[3].EmpName = "新海诚";
            emps[3].EmpAge = 22;
            emps[3].EemAssert = string.Empty;
            emps[3].EmpScore = 0;

            emps[4] = new Employee();
            emps[4].EmpID = "005";
            emps[4].EmpName = "啤酒瓶子";
            emps[4].EmpAge = 34;
            emps[4].EemAssert = string.Empty;
            emps[4].EmpScore = 0;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectItem = listView1.SelectedItems[0];

            FrmJudge fj = new FrmJudge();
            fj.selectItem = selectItem;
            fj.Show();
        }
    }
}
