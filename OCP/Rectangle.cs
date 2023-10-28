using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Rectangle : IShape
    {
        public double Width { get; set; } = 0;
        public double Height { get; set; } = 0;

        public void Print()
        {
            Console.WriteLine($"Rectangle Here : Width : {Width} , Height : {Height}");
        }
    }
}
