using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.SecondExample
{
    internal class MotorCar : ICar
    {
#nullable disable
        private Engine engine;

        public void accelerate()
        {
            //TODO:
        }

        public virtual void TurnOnEngine()
        {
            //TODO:
        }
    }
}
