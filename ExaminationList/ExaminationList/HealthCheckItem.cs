using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationList
{
    /// <summary>
    /// �����Ŀ��
    /// ����һ�������Ŀ������Ŀ��������������
    /// ���磺�ι��ܡ����ڼ��ι��ܡ�60
    /// </summary>
    public class HealthCheckItem
    {
        public HealthCheckItem(string name, int price, string description)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        public HealthCheckItem()
        {
        }
        
        /// <summary>
        /// ��Ŀ����
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// ��Ŀ����
        /// </summary>
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        /// <summary>
        /// ��Ŀ�۸�
        /// </summary>
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
