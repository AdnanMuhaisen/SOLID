using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    public class InvoiceFileManager
    {
        private Invoice _invoice;

        public InvoiceFileManager(Invoice invoice)
        {
            _invoice = invoice;
        }

        public void Save()
        {
            //TODO:
        }
    }
}
