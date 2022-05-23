using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Tracker
{
    internal class Items
    {
        private String name;
        private double price;
        private int aoumnt;

      
        public Items() {
            name = "";
            price = 0;
            aoumnt = 0;
        
        }

        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Aoumnt { get => aoumnt; set => aoumnt = value; }
      
        public String values()
        {
            return name + "\n" + price + "\n" + aoumnt;
        }
    }
}
