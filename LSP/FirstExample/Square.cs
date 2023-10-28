using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.FirstExample
{
    internal class Square : IShape
    {
        public int SideLength;

        public void SetSideLength(int length) => SideLength = length;

        public int Area()
        {
            return SideLength * SideLength;
        }
    }
}
