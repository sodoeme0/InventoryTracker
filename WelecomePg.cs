using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Tracker
{
    public partial class WelecomePg : Form
    {
        public WelecomePg()
        {
            InitializeComponent();
        }

        private void newData_Click(object sender, EventArgs e)
        {
             
           InitialInput initialInput = new InitialInput();
            initialInput.Show();
           this.Hide(); 
        }

        
    }
}
