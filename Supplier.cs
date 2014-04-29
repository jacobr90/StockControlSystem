using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockControlSystem
{
    class Supplier
    {

        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhoneNum { get; set; }
        public int Key { get; set; }

        public Supplier(int k, string name, string address, string phonenum)
        {
            Key = k;
            SupplierName = name;
            SupplierAddress = address;
            SupplierPhoneNum = phonenum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Key.ToString()).Append(" ").Append(SupplierName.ToString()).Append(" ").Append(SupplierAddress.ToString()).Append(" ").Append(SupplierPhoneNum.ToString());
            return sb.ToString();
        }
    }
}
