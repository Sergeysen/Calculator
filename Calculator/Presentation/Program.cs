using Calculator.Domain.Entities;
using Calculator.Domain.Services;
using Calculator.Infrastructure.Logging;
using Calculator.Application.Services;
using Calculator.Domain.Entities;
using Calculator.Domain.Services;
using Calculator.Infrastructure.Logging;
using System;

namespace Calculator.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculatorService calculatorService = new CalculatorService();
            ILogger logger = new ConsoleLogger();

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter first number:");
                    double operand1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter operator (+, -, *, /):");
                    string operatorSymbol = Console.ReadLine();

                    Console.WriteLine("Enter second number:");
                    double operand2 = double.Parse(Console.ReadLine());

                    // Создаем экземпляр Operation с тремя аргументами
                    var operation = new Operation(operand1, operand2, operatorSymbol);

                    double result = calculatorService.ExecuteOperation(operation);
                    logger.Log($"Result: {result}");
                }
                catch (Exception ex)
                {
                    logger.Log($"Error: {ex.Message}");
                }
            }
        }
    }
}

