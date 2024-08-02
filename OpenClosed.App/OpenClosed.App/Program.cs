// See https://aka.ms/new-console-template for more information
using OpenClosed.App;

var calculator = new Calculator();
var resultSum = calculator.Calculate(Sum.Create(Number.Create(5, 4)));
Console.WriteLine(resultSum);
var resultSubstract = calculator.Calculate(Substract.Create(Number.Create(5, 4)));
Console.WriteLine(resultSubstract);
Console.ReadLine();
