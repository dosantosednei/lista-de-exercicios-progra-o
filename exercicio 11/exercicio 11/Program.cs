using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double resultado;

            Console.WriteLine("digite o valor de x");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("digite o valor de y :");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = Match.Pow(x, y);

           

            Console.WriteLine($"o resultado de {x} elevado a {y} é : {resultado}");


            
            
            
           
        }
    }
}
