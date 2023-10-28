using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class ShapePrinter
    {
        public void Print(IShape shape)
        {
            if (shape is null)
                throw new ArgumentNullException(nameof(shape));
            shape.Print();
        }



    }
}
