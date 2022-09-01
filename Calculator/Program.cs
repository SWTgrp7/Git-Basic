// See https://aka.ms/new-console-template for more information
using Calculator;

Console.WriteLine("Manual test of calculator class:\n");

var calc = new Calculator.Calculator();
Console.WriteLine(calc.Add(4,18));
Console.WriteLine(calc.Subtract(9, 5));
Console.WriteLine(calc.Multiply(10, 5));
Console.WriteLine(calc.Power(3,3));