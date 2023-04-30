using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularEstoqueMédio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Quantidade Minima");
            int quantidadeMinima = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a Quantidade Máxima");
            int quantidadeMaxima = int.Parse(Console.ReadLine());

            Calcular(quantidadeMinima, quantidadeMaxima);
        }

        public static void Calcular(int numero1, int numero2)
        {
            int estoqueMedio = (numero1 + numero2) / 2;
            Mensagem(estoqueMedio);
        }

        public static void Mensagem(int estoqueMedio)
        {
            Console.WriteLine($"O Estoque Médio da Peça é: {estoqueMedio}");
        }
    }
}
