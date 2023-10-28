using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal class DelevaryCompany
    {
        private IDelivaryService _delivaryService;

        public DelevaryCompany(IDelivaryService delivaryService)
        {
            _delivaryService = delivaryService;
        }

        public void SendProduct(IProduct product)
        {
            this._delivaryService.DeliverProduct(product);
        }
    }
}
