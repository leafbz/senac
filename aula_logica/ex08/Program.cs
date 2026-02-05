Console.WriteLine("Digite um número");
int n = int.Parse(Console.ReadLine());
while (n != 0)
{
    Console.WriteLine(n);
    n--;
}

Console.WriteLine("Digite um número");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{n}x{i}={i * n}");
}

Console.WriteLine("Seguidores ganhos na semana");
int s = 0;
for (int i = 0; i < 7; i++) {
    Console.WriteLine($"Dia {i+1}:Quando seguidores você ganhou hoje?");
    int n = int.Parse(Console.ReadLine());
    s = s + n;
}
Console.WriteLine("O total de seguidores essa semana foi: " +s);