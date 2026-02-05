Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());
if (idade >= 18 && idade < 65) {
    Console.WriteLine("Voto obrigatório");    
} else if (idade >= 16 || idade >= 65) {
    Console.WriteLine("Voto opicional");
} else {
    Console.WriteLine("Não pode votar");
}