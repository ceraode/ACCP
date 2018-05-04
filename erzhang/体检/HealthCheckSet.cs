using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 体检
{
    public class HealthCheckSet
    {
        public HealthCheckSet()
        { 
            items = new Dictionary<string,HealthCheckItem>();
        }

        public HealthCheckSet(string name, Dictionary<string, HealthCheckItem> items)
        {
            this.Name = name;
            this.items = items;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Dictionary<string, HealthCheckItem> items;

        public Dictionary<string, HealthCheckItem> Items
        {
            get { return items; }
            set { items = value; }
        }


        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

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
