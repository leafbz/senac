Console.WriteLine("Digite um número");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0) {
    Console.WriteLine("Esse número é PAR!");
} else if (n == 0) {
    Console.WriteLine("Você digitou ZERO!");
} else {
    Console.WriteLine("Esse número é ÍMPAR!");
}

