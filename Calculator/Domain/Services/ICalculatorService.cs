using Calculator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Domain.Services
{
    public interface ICalculatorService
    {
        double ExecuteOperation(Operation operation);
    }
}
