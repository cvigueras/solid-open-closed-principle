// See https://aka.ms/new-console-template for more information
using OpenClosed.App;

Console.WriteLine("Hello, World!");
var number = new Operation();
number.Number1 = 1;
number.Number2 = 2;
var sum = new Calculator();
var result = sum.Calculate(number);
Console.WriteLine(result);
Console.ReadLine();
