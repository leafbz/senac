namespace classes
{
    internal class Carro
    {
        public string Marca { get; set; }
        private string Modelo { get; set; }
        private int ano;
        public int Ano
        {
            get { return ano; }
            set
            {
                if (value > 1900 && value < DateTime.Now.Year)
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano inválido.");
                }
            }
        }
        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }
        public int CalcIdade()
        {
            int anoAt = DateTime.Now.Year;
            return anoAt - Ano;
        }
        public void DefModelo(string modelo)
        {
            Modelo = modelo.ToLower();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.Marca = "Mercedes";
            carro.DefModelo("Benz Truck");
            carro.Ano = 2017;
            carro.ExibirInfo();
            Console.WriteLine($"Idade do carro: {carro.CalcIdade()} anos.");
        }
    }
}

