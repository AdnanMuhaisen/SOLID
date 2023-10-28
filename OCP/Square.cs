using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class Square : IShape
    {
        public int Side { get; set; } = 0;

        public void Print()
        {
            Console.WriteLine($"Square Here : Side Length = {Side}");
        }
    }
}
