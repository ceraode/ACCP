using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 体检
{
    public partial class Form1 : Form
    {
        

        HealthCheckItem height, weight, sight, hearing, liverFun, ekg, bWaves, bloodPressure, bloodTest;

        //体检项目A
        HealthCheckSet setA;

        Dictionary<string, HealthCheckItem> AllItems = new Dictionary<string, HealthCheckItem>();

        Dictionary<string, HealthCheckItem> items = new Dictionary<string, HealthCheckItem>();

        public Dictionary<string, HealthCheckSet> HealthSet = new Dictionary<string, HealthCheckSet>();

        public Form1()
        {
            InitializeComponent();
        }

        public void InitItems()
        {
            height = new HealthCheckItem("身高",5,"用于检测身高");
            weight = new HealthCheckItem("体重", 5, "用于检查体重.");
            sight = new HealthCheckItem("视力", 10, "用于检查视力.");
            hearing = new HealthCheckItem("听力", 10, "用于检查听力.");
            liverFun = new HealthCheckItem("肝功能", 50, "用于检查肝功能.");
            bWaves = new HealthCheckItem("B超", 30, "用于检查B超.");
            ekg = new HealthCheckItem("心电图", 50, "用于检查心电图.");
            bloodPressure = new HealthCheckItem("血压", 20, "用于检查血压.");
            bloodTest = new HealthCheckItem("血常规", 20, "用于检查血常规.");

            AllItems.Add(height.Name,height);
            AllItems.Add(weight.Name,weight);
            AllItems.Add(sight.Name, sight);
            AllItems.Add(hearing.Name, hearing);
            AllItems.Add(liverFun.Name, liverFun);
            AllItems.Add(bWaves.Name, bWaves);
            AllItems.Add(ekg.Name, ekg);
            AllItems.Add(bloodPressure.Name, bloodPressure);
            AllItems.Add(bloodTest.Name, bloodTest);
        }

        private void InitSets()
        {
            items = new Dictionary<string, HealthCheckItem>();
            items.Add(height.Name,height);
            items.Add(weight.Name,weight);
            items.Add(liverFun.Name,liverFun);

            setA = new HealthCheckSet("入学体检",items);

            setA.CalcPrice();
            this.HealthSet.Add("入学体检",setA);
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
