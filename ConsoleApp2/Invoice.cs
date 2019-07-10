using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreInvoice
{
    public class Invoice
    {
        public string PartNumber { get; set; }

        public string PartDescription { get; set; }

        public int Quantity;
        public decimal PricePerItem;

        public decimal GetInvoiceAmount()
        {
            return Quantity * PricePerItem;
        }  

        public Invoice( string part, string description, int count, decimal price )
        {
            PartNumber = part;
            PartDescription = description;
            Quantity = count;
            PricePerItem = price;

        }

    }
}
