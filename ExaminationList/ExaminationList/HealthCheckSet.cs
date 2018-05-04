using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationList
{
    /// <summary>
    /// ����ײ���
    /// ÿ���ײͰ���Ҫ������Ŀ���ײ����ơ��ܼ�
    /// </summary>
    public class HealthCheckSet
    {
        public HealthCheckSet()
        {
            items = new Dictionary<string, HealthCheckItem>();
        }
        public HealthCheckSet(string name, Dictionary<string, HealthCheckItem> items)
        {
            this.Name = name;
            this.items = items;
        }

        /// <summary>
        /// �ײ�����
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// �����Ŀ
        /// </summary>
        private Dictionary<string, HealthCheckItem> items;
        public Dictionary<string, HealthCheckItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        /// <summary>
        /// �ײͼ۸�
        /// </summary>
        private int price;
        public int Price
        {
            get { return price; }
        }
        /// <summary>
        /// �ײͼ��㷽��
        /// </summary>
        public void CalcPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in items.Values)
            {
                totalPrice += item.Price;
            }
            this.price = totalPrice;
        }
    }
}
