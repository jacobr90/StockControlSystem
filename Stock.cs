using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{

    class Stock
    {
        public int ItemKey { get; set; }
        public string ItemName { get; set; }
        public int BarCodeNum { get; set; }
        public double RetailPrice { get; set; }  
        public int ThresholdNum { get; set; }       
        public int StockLevel { get; set; }
        public int SuppliersKey { get; set; }     
        public Supplier prefSupplier {get; set; }                             

        public Stock(int ik, string name, int bc, double price, int th, int sl, int sk)
        {
            ItemKey = ik;
            ItemName = name;
            BarCodeNum = bc;
            RetailPrice = price;
            ThresholdNum = th;
            StockLevel = sl;
            prefSupplier = ;

            //StringBuilder sb = new StringBuilder();
            //sb.Append(
            //s = 
            //s = new Supplier();
        }

        public void AddStock()
        {
            StockLevel++;
        }

        public void DeleteStock()
        {
            StockLevel--;
        }

        public Boolean ScarceCheck()
        {
            if (StockLevel <= ThresholdNum) return true;
            else return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ItemKey.ToString()).Append(" ").Append(ItemName.ToString()).Append(" ").Append(BarCodeNum.ToString()).Append(" ").Append(RetailPrice.ToString()).Append(" ").Append(ThresholdNum.ToString()).Append(" ").Append(StockLevel.ToString()).Append(" ").Append(SuppliersKey.ToString());
            return sb.ToString();
        }

    }


}
