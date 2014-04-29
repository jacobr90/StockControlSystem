using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace StockControlSystem
{
    public partial class Computer : Form
    {
        Controller control;
    
        public Computer()
        {
            InitializeComponent();
        }

        public string StockItemKeyToOrder
        {
            get
            {
                return tbOrderItemKey.Text.Trim();
            }
        }

        public void ClearStockItemKeyToOrder()
        {
            tbOrderItemKey.Text = string.Empty;
        }

        public string NumStockTiemsToOrder
        {
            get
            {
                return tbNumItemsToOrder.Text.Trim();
            }
        }

        public void ClearNumStockItemsToOrder()
        {
            tbNumItemsToOrder.Text = string.Empty;
        }

        public string StockItemKeyToRestock
        {
            get
            {
                return tbRestockItemKey.Text.Trim();
            }
        }

        public void ClearStockItemKeyToRestock()
        {
            tbRestockItemKey.Text = string.Empty;
        }


        private void Computer_Load(object sender, EventArgs e)
        {   
            // This handler is for initialization
            control = new Controller();
        }


        private void bnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnListStockBelowTH_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            while (control.ScarceCheck() != null)
            {
                listDialog.AddDisplayItems(control.ScarceCheck().ToString());

            }
            listDialog.ShowDialog();
        }

        private void bnListAllStock_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            Stock[] temp = new Stock[control.Stock.Count];
            temp = control.Stock.ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                listDialog.AddDisplayItems(temp[i].ToString());
            }
            listDialog.ShowDialog();
        }

        private void bnListAllSuppliers_Click(object sender, EventArgs e)
        {
            ListDialog listDialog = new ListDialog();
            Supplier[] temp = new Supplier[control.Suppliers.Count];
            temp = control.Suppliers.ToArray();
            for (int i = 0; i < temp.Length; i++)
            {
                listDialog.AddDisplayItems(temp[i].ToString());
            }

            listDialog.ShowDialog();
        }

        private void bnOrder_Click(object sender, EventArgs e)
        {
            List<Order> orders = new List<Order>();
            Stock temp = control.Scan(Convert.ToInt32(tbOrderItemKey.Text));
            //temp = new Stock(temp.ItemKey, temp.ItemName, temp.BarCodeNum, temp.RetailPrice, temp.ThresholdNum, temp.StockLevel, temp.SuppliersKey);
            
            //tbNumItemsToOrder;
        }

        private void bnListOutstandingOrders_Click(object sender, EventArgs e)
        {
            // the following lines are to instruct you how to use ListDialog.
            // You should replace the following code with yours
            ListDialog listDialog = new ListDialog();
            listDialog.AddDisplayItems("This is a test", "You can write any number of arguments,",
                "to pass to AddDisplayItems");
            object[] displayObjects= {
                                         "You can also pass object[],",
                                         "which contains any number of objects"
                                     };
            listDialog.AddDisplayItems(displayObjects);
            listDialog.AddDisplayItems("You can call AddDisplayItems as many times as you want");                           
            listDialog.AddDisplayItems("Each invocation adds lines to be displayed");
            listDialog.AddDisplayItems("By the way, did you know that ToString() of string returns its string component");
            listDialog.ShowDialog();
        }

        private void bnRestock_Click(object sender, EventArgs e)
        {
        }

        private void bnLoadStock_Click(object sender, EventArgs e)
        {
           
            // load stock file
            {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "StockItems|*.spl";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    TextReader trs = new StreamReader(openFileDialog.FileName);
                    string s;
                    string[] info = new string[6];
                    char[] splitter = { '&' };
                    while ((s = trs.ReadLine()) != null)
                    {
                        info = s.Split(splitter);
                        control.AddStock(Convert.ToInt32(info[0]), info[1], Convert.ToInt32(info[2]), Convert.ToDouble(info[3]), Convert.ToInt32(info[4]), Convert.ToInt32(info[5]), Convert.ToInt32(info[6]));

                    }
                  
                }

             catch(Exception)
                {
                    MessageBox.Show("Error! Wrong Input File");
                }
             }
            }
            bnListStockBelowTH.Enabled = bnListAllStock.Enabled = bnListAllSuppliers.Enabled = true;
            bnListOutstandingOrders.Enabled = bnOrder.Enabled = bnRestock.Enabled = true;
            bnLoadSuppliers.Enabled = bnLoadStock.Enabled = false;
            
            // I display Till here (using Show() since Till is a modeless dialog box
        }
            
        private void bnLoadSuppliers_Click(object sender, EventArgs e)
        {
            // load supplier file here
                   //VISIBILITY_SPEC RETURN_TYPE LoadSuppliers()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Suppliers|*.spl";
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TextReader trs = new StreamReader(openFileDialog.FileName);
                    string s;
                    string[] properties = new string[4];
                    char[] spliter = { '&' };
                    while ((s = trs.ReadLine()) != null)
                    {
                        properties = s.Split(spliter);
                        control.AddSupplier(Convert.ToInt32(properties[0]), properties[1], properties[2], properties[3]);


                        //for (int i = 0; i < properties.Length; i++)
                        //{
                        //    s = properties[i].Trim();
                        //    // you have all 4 strings in properties[]
                        //    // to extract a string, you may want to do the following
                        //    // string s = properties[i].trim();   
                        //    // to be honest, I am not sure if trim() is necessary. But I call it anyways
                        //}



                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Exception is caught (LoadSuppliers)");
                    MessageBox.Show("Error! Invalid File.");
                }
            }
        }

            bnLoadStock.Enabled = true;
        }
    }
}

//object[] displayObjects = {
//                             "You can also pass object[],",
//                             "which contains any number of objects"
//                         };
//listDialog.AddDisplayItems(displayObjects);
//listDialog.AddDisplayItems("You can call AddDisplayItems as many times as you want");
//listDialog.AddDisplayItems("Each invocation adds lines to be displayed");
//listDialog.AddDisplayItems("By the way, did you know that ToString() of string returns its string component");