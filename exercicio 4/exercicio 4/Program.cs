using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int baze;
            int altura;
            int area;

            Console.Write("informe o valor da base do triangulo ");
            baze = int.Parse(Console.ReadLine());

            Console.Write("informe o valor da altura do triangulo ");
            altura = int.Parse(Console.ReadLine());

            area = (baze * altura) / 2;

            Console.WriteLine("o valor da area do triangulo de baze {0} e altura {1} e area {2}", baze, altura, area);



        }
    }
}
