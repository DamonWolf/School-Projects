using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareStoreInvoice
{
    public class InvoiceTest
    {
        public static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("1234", "Hammer", 2, 14.95M );
            Invoice invoice2 = new Invoice("5678", "PaintBrush", 0, 0.00M );


            Console.WriteLine("Original invoice information");
            Console.WriteLine("Part number: {0}", invoice1.PartNumber);
            Console.WriteLine("Description: {0}", invoice1.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice1.Quantity);
            Console.WriteLine("Price: {0:C}", invoice1.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}", invoice1.GetInvoiceAmount() );
            Console.WriteLine();


            invoice1.PartNumber = "001234";
            invoice1.PartDescription = "Yellow Hammer";
            invoice1.Quantity = 3;
            invoice1.PricePerItem = 19.49M;

            Console.WriteLine("Updated invoice information");
            Console.WriteLine("Part number: {0}", invoice1.PartNumber);
            Console.WriteLine("Description: {0}", invoice1.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice1.Quantity);
            Console.WriteLine("Price: {0:C}", invoice1.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}", invoice1.GetInvoiceAmount());
            Console.WriteLine();


            Console.WriteLine("Original invoice information");
            Console.WriteLine("Part number: {0}", invoice2.PartNumber);
            Console.WriteLine("Description: {0}", invoice2.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice2.Quantity);
            Console.WriteLine("Price: {0:C}", invoice2.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}", invoice2.GetInvoiceAmount());
            Console.WriteLine();


            invoice2.PartNumber = "5678";
            invoice2.PartDescription = "PaintBrush";
            invoice2.Quantity = 3;
            invoice2.PricePerItem = 9.49M;

            
            Console.WriteLine("Updated invoice information");
            Console.WriteLine("Part number: {0}", invoice2.PartNumber);
            Console.WriteLine("Description: {0}", invoice2.PartDescription);
            Console.WriteLine("Quantity: {0}", invoice2.Quantity);
            Console.WriteLine("Price: {0:C}", invoice2.PricePerItem);
            Console.WriteLine("Invoice amount: {0:C}", invoice2.GetInvoiceAmount());
            Console.WriteLine("Press any key to continue...");


            Console.Read();
        





        }

    }
}
