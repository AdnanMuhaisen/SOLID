using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DIP
{
    internal interface IDelivaryService
    {
        void DeliverProduct(IProduct product);
    }
}
