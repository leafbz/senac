using System.Runtime.Serialization;

Console.WriteLine("Digite um número: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"A soma é {a+b} \nA subtração é {a-b} \nA multiplicação é {a*b} \nA divisão é {(double)a/b}");

