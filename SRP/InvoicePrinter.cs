using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class InvoicePrinter
    {
        private Invoice _invoice;

        public InvoicePrinter(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void Print()
        {
            Console.WriteLine($"Quantity {_invoice._quantity} X {_invoice._book.Name} {_invoice._book.Price:C}");
            Console.WriteLine($"Discount Rate : {_invoice._discountRate:C}");
            Console.WriteLine($"Tax Rate : {_invoice._taxRate}");
            Console.WriteLine($"Total : {_invoice._total:C}");
        }
    }
}
