using Calculator.Domain.Entities;
using Calculator.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Application.Services
{
    public class CalculatorService : ICalculatorService
    {
        public double ExecuteOperation(Operation operation)
        {
            return operation.Operator switch
            {
                "+" => operation.Operand1 + operation.Operand2,
                "-" => operation.Operand1 - operation.Operand2,
                "*" => operation.Operand1 * operation.Operand2,
                "/" => operation.Operand2 != 0 ? operation.Operand1 / operation.Operand2 : throw new DivideByZeroException(),
                _ => throw new InvalidOperationException("Invalid operator")
            };
        }
    }
}
