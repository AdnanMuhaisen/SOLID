using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.FirstExample
{
    public class Rectangle : IShape
    {
        public int Width;

        public int Height;

        public Rectangle() { }

        // assume that theres no input validation !
        public void SetWidth(int width) => this.Width = width;
        public void SetHeight(int height) => this.Height = height;

        public int Area()
        {
            return Width * Height;
        }
    }
}
