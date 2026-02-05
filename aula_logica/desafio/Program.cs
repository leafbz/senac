string senha = "!Abacax1";
Console.WriteLine("Digite a senha");
string s = Console.ReadLine();
if (s != senha) {
    Console.WriteLine("🚨🚨🚨Aceso negado🚨🚨🚨");
} else {
    Console.WriteLine("Liberado");
}

int n  = 42;
Console.WriteLine("Qual o seu palpite");
int g = int.Parse(Console.ReadLine());
while (g != n) {
    Console.WriteLine("Errado");
}
Console.WriteLine("Certo");

Console.WriteLine("Cardapio");
Console.WriteLine("Digite: (1) Pizza (2) Lanche (3) Suco");
int c = int.Parse(Console.ReadLine());
switch (c)
{
    case 1:
        Console.WriteLine("Você escolheu uma pizza");
        break;
    case 2:
        Console.WriteLine("Você escolheu um lanche");
        break;
    case 3:
        Console.WriteLine("Você escolheu um suco");
        break;
    default: 
        Console.WriteLine("Opção inválida");
        break;
}