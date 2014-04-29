using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockControlSystem
{
    public partial class Till : Form
    {
        public Till()
        {
            InitializeComponent();
        }

        public string BarCode
        {
            get
            {
                return tbBarCode.Text.Trim();
            }
        }

        public void ClearBarCode()
        {
            tbBarCode.Text = string.Empty;
        }

        public string ItemName
        {
            get
            {
                return tbName.Text.Trim();
            }
        }

        public void DisplayItemName(string name)
        {
            tbName.Text = name;
        }

        public void ClearItemName()
        {
            tbName.Text = String.Empty;
        }

        public string ItemPrice
        {
            get
            {
                return tbPrice.Text.Trim();
            }
        }

        public void DisplayItemPrice(string price)
        {
            tbPrice.Text = price;
        }

        public void ClearItemPrice()
        {
            tbPrice.Text = string.Empty;
        }


        private void bnScan_Click(object sender, EventArgs e)
        {
        }

        private void bnTotal_Click(object sender, EventArgs e)
        {
        }

        private void bnBalance_Click(object sender, EventArgs e)
        {
        }

        private void bnClear_Click(object sender, EventArgs e)
        {
        }

        private void Till_Load(object sender, EventArgs e)
        {

        }
    }
}
