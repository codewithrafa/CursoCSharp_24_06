using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_24_06.Aula01
{
    class Series //Molde
    {
        //declaro as variáveis públicas (atributos) na minha classe "Series"
        public string Nome;
        public string Genero;
        public int Lancamento;
        public int Classificação;

        //Crio um metodo para a classe Series
        public string ApresentarSerie()
        {
            return string.Format($"Nome: {Nome}\nGênero: {Genero}\nLançamento: {Lancamento}\nClassificação: {Classificação}\n");
        } 
        //Crio um metodo que declara o metodo anterior
        public void ApresentarSerie2()
        {
            Console.WriteLine(ApresentarSerie()); 
        }   
    }
   class Series02
    {
        public static void Main2()
        {
            //aplico as caracteristicas nos objetos
            Series serie01 = new Series();
            serie01.Nome = "Arcane";
            serie01.Genero = "Drama";
            serie01.Lancamento = 2021;
            serie01.Classificação = 14;

            Series serie02 = new Series();
            serie02.Nome = "WandaVision";
            serie02.Genero = "Sitcom";
            serie02.Lancamento = 2021;
            serie02.Classificação = 14;

            //pergunta com estrutura de condição
            Console.WriteLine("Qual série você quer acessar?\n1 - Arcane\n2 - Wandavision");
            int acessar = int.Parse(Console.ReadLine());
            if (acessar == 1)
            {
                serie01.ApresentarSerie2();
            }
           else
            {
            serie02.ApresentarSerie2();
            }
        }
    }

}

