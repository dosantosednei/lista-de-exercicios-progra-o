using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diagonal;
            double area;

            Console.WriteLine("digite o valor da diagonal do quadrado :");
            diagonal = double.Parse(Console.ReadLine());

            area = (diagonal * diagonal) /2;

            Console.WriteLine("A area do quadrado é :" + area);

            
        }
    }
}
