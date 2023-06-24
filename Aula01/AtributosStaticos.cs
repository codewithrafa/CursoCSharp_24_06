using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_24_06.Aula01
{
    class AtributosStaticos
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        class Multi
        {
            public static double Multiplicar(double x, double y)
            {
                return x * y;
            }
        }

        class Atributos
        {
            public static void Main2()
            {
                //Criando um objeto
                AtributosStaticos SomaSimples = new AtributosStaticos();
                //Acessando método
                Console.WriteLine(AtributosStaticos.Somar(3, 3));

                //Criando um objeto
                Multi Operacao = new Multi();
                //Acessando método
                Console.WriteLine(Multi.Multiplicar(9,8));
            }
        }
    }
}
