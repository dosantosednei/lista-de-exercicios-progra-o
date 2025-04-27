using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int area;

            Console.Write("informe o valor da aresta do quadrado:");
            aresta = int.Parse(Console.ReadLine());

            area = aresta * aresta;

            Console.WriteLine("o valor da area do quadrado que possui aresta de {0} é {1}", aresta, area);

                
            



        }








    }     
}
