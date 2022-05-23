using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;

namespace Inventory_Tracker
{
    public partial class InitialInput : Form
    {
       private List<Items> inventory = new List<Items>();
        private Dictionary<int, Items> inven = new Dictionary<int, Items>();
        private int counter = 0;

        public InitialInput()
        {
            InitializeComponent();



            
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            inventory.Add(new Items());
            //inven.Add(counter, new Items());

            inventory[counter].Name= nameTxt.Text;
            //inven[counter].Name = nameTxt.Text;

           inventory[counter].Aoumnt = Int32.Parse(amountTxt.Text);
            //inven[counter].Aoumnt = Int32.Parse(amountTxt.Text);

           inventory[counter].Price = Double.Parse(priceTxt.Text);
            //inven[counter].Price= Double.Parse(priceTxt.Text);  

           //nameTxt.Clear();
            //amountTxt.Clear();
            //priceTxt.Clear();
            itemGrid.Rows.Add(inventory[counter].Name, inventory[counter].Aoumnt, "$" + inventory[counter].Price);
            //Debug.WriteLine(inventory[counter].values());

            

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            
            var num = Int32.Parse(removeTxt.Text)-1;
            Debug.WriteLine(inventory[num].Name);
            inventory.RemoveAt(num);
            itemGrid.Rows.RemoveAt(num);
            Debug.WriteLine(inventory.Count);

        }
    }
}
