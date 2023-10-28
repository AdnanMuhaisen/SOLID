using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class InvoiceCalculator
    {
        private Invoice _invoice;

        public InvoiceCalculator(Invoice invoice)
        {
            _invoice = invoice;
        }

        public decimal Calculate()
        {
            decimal Price = (_invoice._book.Price * _invoice._quantity);
            Price = Price - (Price * (decimal)_invoice._discountRate);

            // total price with tax
            Price = Price + (decimal)_invoice._taxRate;
            return Price;
        }
    }
}
