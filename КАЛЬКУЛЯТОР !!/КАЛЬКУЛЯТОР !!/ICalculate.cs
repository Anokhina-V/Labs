using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КАЛЬКУЛЯТОР___
{
    interface ICalculate
    {
        double number1 { get; set; }
        void Save(double num);
        double Minuss(double number2);
        double Multiplyy(double number2);
        double Devisionn(double number2);
        double Pluss(double number2);
        void Clear();
    }
}
