//// alternativa A por todos os formatos estarem certos
//string nomeVideo = "Desafio";
//int visualizacoes = 100000;
//double classificacao = 4.5;
//bool monetizado = true;
//// alternativa A por todos os formatos estarem certos
//string nome = "André";
//string patente = "Tenente";
//int anosServico = 12;
//double salario = 4500.50;
//bool ativo = true;
//// alternativa A por todos os formatos estarem certos
//string nome = "Anitta";
//int seguidores = 65000000;
//double engajamento = 8.5;
//bool emTurnê = true;
//// alternativa A por todos os formatos estarem certos
//string nome = "João";
//int idade = 25;
//string cidade = "São Paulo";
//bool ganhouPremio = false;
//// alternativa A por todos os formatos estarem certos
//string nome = "Maria";
//int idade = 60;
//string destino = "Rio de Janeiro";
//bool portadorDeficiencia = true;
//// alternativa A pela declaração de constante certa
//const double valorPorMil = 0.25;
//// alternativa A pela declaração de constante certa
//const int diasPrograma = 100;
//// alternativa C pela declaração de constante certa
//const int membrosEquipe = 8;
//// alternativa B pelas operações corretas
//int video1 = 100000;
//int video2 = 85000;
//int total = video1 + video2;
//// alternativa C pelas operações corretas
//double valorPassagem = 150;
//int pessoas = 3;
//double valorPorPessoa = valorPassagem / pessoas;
//// alternativa C pelas operações corretas
//double precoVestido = 200;
//double desconto = precoVestido * 0.20;
//// alternativa B pelas operações corretas
//int votos_eliminar = 20;
//int votos_manter = 15;
//int diferenca = votos_eliminar - votos_manter;
//// alternativa A pelo uso correto das condições
//int visualizacoes = 1500000;
//if (visualizacoes > 1000000)
//{
//    Console.WriteLine("Ganhou R$ 1.000");
//}
//else
//{
//    Console.WriteLine("Ganhou R$ 100");
//}
//// alternativa A pelo uso correto das condições
//int idade = 19;
//if (idade > 18)
//{
//    Console.WriteLine("Pode votar");
//}
//else
//{
//    Console.WriteLine("Não pode votar");
//}
//// alternativa A pelo uso correto das condições
//int idade = 28;
//if (idade >= 25)
//{
//    Console.WriteLine("Entra no BOPE");
//}
//else
//{
//    Console.WriteLine("Não entra no BOPE");
//}
//// alternativa A pelo uso correto das condições
//double gasto = 6000;
//if (gasto > 5000)
//{
//    double desconto = gasto * 0.30;
//    Console.WriteLine("Desconto VIP: " + desconto);
//}
//else
//{
//    double desconto = gasto * 0.10;
//    Console.WriteLine("Desconto regular: " + desconto);
//}
//// alternativa A pelo uso correto das condições
//int idade = 62;
//if (idade >= 60)
//{
//    Console.WriteLine("Tem desconto");
//}
//else
//{
//    Console.WriteLine("Sem desconto");
//}
//// alternativa A pelo uso correto do loop
//for (int i = 1; i <= 5; i++)
//{
//    Console.WriteLine("Vídeo: " + i);
//}
//// alternativa A pelo uso correto do loop
//for (int i = 10; i >= 1; i--)
//{
//    Console.WriteLine("Contagem: " + i);
//}
//// alternativa B pelo uso correto do loop
//int contador = 1;
//while (contador <= 7)
//{
//    Console.WriteLine("Anitta");
//    contador++;
//}
//// alternativa A pelo uso correto do loop
//for (int policial = 1; policial <= 15; policial++)
//{
//    Console.WriteLine("Policial " + policial + " em treinamento");
//}
//// alternativa B pelo uso correto do loop
//int cartas = 1;
//while (cartas <= 10)
//{
//    Console.WriteLine("Carta " + cartas);
//    cartas++;
//}
//// alternativa A pela declaração correta de array
//string[] videos = { "Desafio 1", "Desafio 2", "Desafio 3", "Desafio 4", "Desafio 5" };
//// alternativa A pela declaração correta de array e uso de loop para percorre-la
//int[] idades = { 22, 25, 30, 28, 24 };
//for (int i = 0; i < idades.Length; i++)
//{
//    Console.WriteLine(idades[i]);
//}
//// alternativa A pela declaração correta de array e uso do index para exibir o primeiro nome
//string[] passageiros = { "Maria", "João", "Pedro", "Ana", "Carlos", "Beatriz", "Lucas", "Fer" };
//Console.WriteLine(passageiros[0]);

List<string> nomes = new List<string>();    
nomes.Add("Jorge");
nomes.Add("Mario");
nomes.Add("Paula");
nomes.Remove("Mario");
nomes[0] = "Pedro";
nomes.Add("Maria");
nomes.RemoveAt(2);
Console.WriteLine(nomes[2]);