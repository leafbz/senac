Console.WriteLine("Digite sua idade");
int n = int.Parse(Console.ReadLine());
if (n >= 6 && n <= 14) {
    Console.WriteLine("Você está no Ensino Fundamental!");
} else if (n >= 15 && n <= 17) {
    Console.WriteLine("Você está no Ensino Médio!");
} else {
    Console.WriteLine("Você está fora dessas etapas escolares.");
}

