using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    class Controller
    {
        public List<Supplier> Suppliers { get; set; }
        public List<Order> Orders { get; set; }
        public List<Stock> Stock { get; set; }


        public Controller()
        {
            Suppliers = new List<Supplier>();
            Orders = new List<Order>();
            Stock = new List<Stock>();
        }

        public void AddSupplier(int key, string name, string address, string phonenum)
        {
            Suppliers.Add(new Supplier(key, name, address, phonenum));
        }

        public void AddStock(int ik, string name, int bc, double price, int th, int sl, int sk)
        {
            Stock.Add(new Stock(ik, name, bc, price, th, sl, sk));
        }

        public void SetPreferred(int key)
        {
            Supplier tempSupp = Suppliers.Find(temp => (temp.Key == Stock.FindIndex(Stock));
            Stock.prefSupplier = Suppliers.Find(key);
        }

        public Stock ScarceCheck()
        {
            Stock tempStock = Stock.Find(temp => (temp.StockLevel <= temp.ThresholdNum));
            if (tempStock == null)
            {
                return null;
            }
            else return tempStock;
        }

        public Stock Scan(int key)
        {
            Stock tempStock = Stock.Find(temp => (temp.ItemKey == key));
            return tempStock;
        }
    }
}
