// Faça um programa que solicite ao usuário digitar seu nome e exiba uma mensagem de boas-vindas personalizada com o nome informado

Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine($"Olá {nome} seja bem vindo(a)!");

// Crie um programa que leia a ideade do usuário(como texto), converta para número inteiro e mostre a idade na tela.
Console.WriteLine("Digite sua idade(em anos)");
int idade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Então você tem " + idade);
