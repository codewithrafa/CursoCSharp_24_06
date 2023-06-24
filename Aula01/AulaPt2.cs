using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_24_06.Aula01
{
    class AulaPt2
    {
        public string NomeProd;
        public double Preco;
        public static double Desc;

        public AulaPt2(string nomeProd, double preco, double desc)
        {
            NomeProd = nomeProd;
            Preco = preco;
            Desc = desc;
        }

        public double CalValor()
        {
            double ValorComDesconto = Preco - (Preco * Desc);
            return ValorComDesconto;
        }

        class Carro
        {
            public static void Main()
            {
                AulaPt2 carro01 = new AulaPt2("Fox", 20000, 0.5);
                Console.WriteLine(carro01.NomeProd);
                Console.WriteLine(carro01.Preco);
                Console.WriteLine(carro01.CalValor());

                Console.WriteLine("__________________");

                AulaPt2 carro02 = new AulaPt2("Gol", 40000, 1);
                Console.WriteLine(carro02.NomeProd);
                Console.WriteLine(carro02.Preco);
                Console.WriteLine(carro02.CalValor());
            }

        }
    }
}
