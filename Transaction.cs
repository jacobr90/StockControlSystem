using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    class Transaction
    {

        List<TransactionInfo> info;
        string NumItems { get; set; }


        public Transaction()
        {
            info = new List<TransactionInfo>();
        }


        public void Scan()                  // not sure if this method needs a paramter passed in
        {
        }

        public void AddTo()
        {
        }

        public double Sum()
        {
            return 0.00;
        }

    }
}
