using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Entities
{
    public class Operation
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public string Operator { get; set; }

        public Operation(double operand1, double operand2, string operatorSymbol)
        {
            Operand1 = operand1;
            Operand2 = operand2;
            Operator = operatorSymbol;
        }
    }
}
