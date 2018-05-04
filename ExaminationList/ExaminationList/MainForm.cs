using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace ExaminationList
{
    public partial class MainForm : Form
    {
        //���弸�������Ŀ
        HealthCheckItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;
        //����1��ϵͳĬ�ϼ���ײ͡���ѧ��족
        HealthCheckSet setA;

        //����ԭʼ��Item����
        Dictionary<string, HealthCheckItem> AllItems = new Dictionary<string, HealthCheckItem>();
        //�����ײ��е�Item����
        Dictionary<string, HealthCheckItem> items = new Dictionary<string, HealthCheckItem>();
        //ʹ���ֵ䱣���ײͼ���
        public Dictionary<string, HealthCheckSet> HealthSet = new Dictionary<string, HealthCheckSet>();
          
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �������м����Ŀ����������AllItems������
        /// </summary>
        public void InitItems()
        {
            //����Item���󲢱��浽������ --ע�����ʹ��List<T> �����������б��е�����һ��
            height = new HealthCheckItem("���", 5, "���ڼ�����.");
            weight = new HealthCheckItem("����", 5, "���ڼ������.");
            sight = new HealthCheckItem("����", 10, "���ڼ������.");
            hearing = new HealthCheckItem("����", 10, "���ڼ������.");
            liverFun = new HealthCheckItem("�ι���", 50, "���ڼ��ι���.");
            bWaves = new HealthCheckItem("B��", 30, "���ڼ��B��.");
            ekg = new HealthCheckItem("�ĵ�ͼ", 50, "���ڼ���ĵ�ͼ.");
            bloodPressure = new HealthCheckItem("Ѫѹ", 20, "���ڼ��Ѫѹ.");
            bloodTest = new HealthCheckItem("Ѫ����", 20, "���ڼ��Ѫ����.");
            AllItems.Add(height.Name, height);
            AllItems.Add(weight.Name, weight);
            AllItems.Add(sight.Name, sight);
            AllItems.Add(hearing.Name, hearing);
            AllItems.Add(liverFun.Name, liverFun);
            AllItems.Add(bWaves.Name, bWaves);
            AllItems.Add(ekg.Name, ekg);
            AllItems.Add(bloodPressure.Name, bloodPressure);
            AllItems.Add(bloodTest.Name, bloodTest);
        }

        /// <summary>
        /// ����Ĭ���ײ�����
        /// </summary>
        private void InitSets()
        {
            //����1��Ĭ���ײͶ���
            items = new Dictionary<string, HealthCheckItem>();
            items.Add(height.Name,height);
            items.Add(weight.Name,weight);
            items.Add(liverFun.Name,liverFun);

            setA = new HealthCheckSet("��ѧ���", items);
            //�����ײͼ۸�
            setA.CalcPrice();
            this.HealthSet.Add("��ѧ���", setA);
        }

        /// <summary>
        /// ��������ײ�
        /// </summary>
        public void InitHealthSetList()
        {
            this.cboSets.Items.Clear();
            this.cboSets.Items.Add("��ѡ��");

            foreach (string key in this.HealthSet.Keys)
            {
                this.cboSets.Items.Add(key);
            }
            this.cboSets.SelectedIndex = 0;
        }

        //�������
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.lblSetName.Text = "";
            this.lblSetPrice.Text = "";
            this.btnAdd.Enabled = false;
            this.btnDel.Enabled = false;

            //��ʼ�����м����Ŀ
            InitItems();
            //��ʼ��Ĭ���ײ�
            InitSets();
            //�����ײ��б�
            InitHealthSetList();
        }

        /// <summary>
        /// ����ײ͵�DataGridView
        /// </summary>
        /// <param name="set"></param>
        private void UpdateSet(HealthCheckSet set)
        {
            //ע�⣺Dictionary��Valuesת��ΪList������ʹ��ToList() .�÷����������������ռ�System.Linq;(.NET FrameWork 4)
            this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>(set.Items.Values.ToList());
        }

        //ѡ���ײ͡������б��¼�
        private void cboSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string setName = this.cboSets.Text;
            if (setName == "��ѡ��")
            {
                this.dgvHealthList.DataSource = new BindingList<HealthCheckItem>();
                lblSetName.Text = "";
                lblSetPrice.Text = "";
                return;
            }
            //�����ײ�����
            lblSetName.Text = this.HealthSet[setName].Name;
            //�����ײ��ܼ�
            lblSetPrice.Text = this.HealthSet[setName].Price.ToString();
            //�����ײͼ����Ŀ
            UpdateSet(HealthSet[setName]);
            //����ɾ����ťΪ������״̬��
            this.btnDel.Enabled = true;
        }

        //ɾ�������Ŀ
        private void btnDel_Click(object sender, EventArgs e)
        {
            string setName = this.cboSets.Text;

            if (this.dgvHealthList.SelectedRows.Count== 0)
            {
                MessageBox.Show("û��ѡ��ɾ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //��ȡѡ�м����Ŀ������
            int index = this.dgvHealthList.SelectedRows[0].Index;
            string key = this.dgvHealthList.SelectedRows[0].Cells[0].Value.ToString();
           
            //ɾ�������
            this.HealthSet[setName].Items.Remove(key);

            //���¼���۸�
            this.HealthSet[setName].CalcPrice();
            //����DataGridView��ʾ
            UpdateSet(HealthSet[setName]);
            //�����ǩ��ʾ
            this.lblSetName.Text = setA.Name;  
            this.lblSetPrice.Text = setA.Price.ToString();    
            MessageBox.Show("ɾ���ɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        //�����Ƿ�ѡ�������Ŀ�����á���ӡ���ʾ״̬
        private void cboItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboItems.Text != "��ѡ��")
            {
                this.btnAdd.Enabled = true;
            }
            else
            {
                this.btnAdd.Enabled = false;
            }   
        }

        //����ӡ������Ŀ
        private void btnAdd_Click(object sender, EventArgs e)
        {
            #region �����ж�
            if (this.cboItems.SelectedIndex == 0)
            {
                MessageBox.Show("��ѡ��һ����Ŀ��");
                return;
            }

            string cboSetText = this.cboSets.Text;
            if (cboSetText == "��ѡ��")
            {
                MessageBox.Show("��ѡ���ײͣ�");
                return;
            }
            #endregion
            #region ��Ӳ���
            int index = this.cboItems.SelectedIndex - 1;
            string wantAdd=this.cboItems.Text;
            if (!this.HealthSet[cboSetText].Items.Keys.ToList().Contains(wantAdd))
            {
                //��Ӽ����
                this.HealthSet[cboSetText].Items.Add(wantAdd, AllItems[wantAdd]);
                //���¼����ܼ۸�
                this.HealthSet[cboSetText].CalcPrice();
                //����
                UpdateSet(this.HealthSet[cboSetText]);
                this.lblSetName.Text = this.HealthSet[cboSetText].Name;  //ˢ�´��弯��A����
                this.lblSetPrice.Text = this.HealthSet[cboSetText].Price.ToString();    //ˢ�¼���A�۸�
                MessageBox.Show("��ӳɹ���", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("����Ŀ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

        }

        //�½��ײ�
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtHealthName.Text.Trim()))
            {
                MessageBox.Show("�������ײ�����!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            HealthCheckSet Hch = new HealthCheckSet();
            this.HealthSet.Add(this.txtHealthName.Text.Trim(), Hch);

            this.InitHealthSetList();
            this.cboSets.SelectedIndex = this.HealthSet.Count;
            MessageBox.Show("��ӳɹ�!", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 

    }
}