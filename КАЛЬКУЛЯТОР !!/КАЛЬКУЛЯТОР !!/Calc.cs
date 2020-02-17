using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КАЛЬКУЛЯТОР___
{
    class Calc : ICalculate
    {
        public double number1
        {
           get; set;
        }

        public void Clear()
        {
            this.number1 = 0;
        }

        public double Devisionn(double number2)
        {
            return this.number1 / number2;
        }

        public double Minuss(double number2)
        {
            return this.number1 - number2;
        }

        public double Multiplyy(double number2)
        {
            return this.number1 * number2;
        }

        public double Pluss(double number2)
        {
            return this.number1 + number2;
        }

        public void Save(double num)
        {
            this.number1 = num;
        }
    }
}
