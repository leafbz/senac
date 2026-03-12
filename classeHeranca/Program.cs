using classeHeranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classeHeranca
{
    internal class Animal
    {
        public string Nome { get; set; }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal emite um som.");
        }
    }

    internal class Cachorro : Animal 
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }
    }
    internal class Gato : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine($"{Nome} mia: Miau!");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Animal cachorro = new Cachorro { Nome = "Frederico" };
        Animal gato = new Gato { Nome = "Diana" };
        //cachorro.EmitirSom();
        //gato.EmitirSom();
        Console.WriteLine($"{gato.Nome} é um gato");
        Console.WriteLine($"{cachorro.Nome} é um cachorro");
        Animal[] animais = { cachorro, gato };
        foreach (var animal in animais)
        {
            animal.EmitirSom();
        }
    }
}