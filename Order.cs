using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    class Order
    {
        Stock s;                // pointer to the stock object
        public int NumItemsToOrder { get; set; }
        DateTime dt;





        public Order(int numitems)
        {
            NumItemsToOrder = numitems;
            dt = new DateTime();
        }

        public void OrderItem()
        {

        }

        //public void Restock()
        //{
        //    s.AddStock();       //this needs to be called as many times as # of items ordered
        //}
    }
}
