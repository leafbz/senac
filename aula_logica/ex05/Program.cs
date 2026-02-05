Console.WriteLine("Digite o valor da compra");
double total = double.Parse(Console.ReadLine());
if (total > 500) {
    Console.WriteLine("O valor final é: " + (total - (total * 10) / 100));
} else {
    Console.WriteLine("O valor final é: " + total);
}