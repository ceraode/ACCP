using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检
{
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

        //名称
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //描述
        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //价格
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
