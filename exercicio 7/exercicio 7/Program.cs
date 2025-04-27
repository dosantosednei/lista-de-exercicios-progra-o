using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o valor das milhas maritimas :");
            string input = Console.ReadLine();

            double quilometros;
            double milhasmaritimas;

            if (double.TryParse(input, out quilometros)) 

            if (double.TryParse(input, out milhasmaritimas))

            quilometros = milhasmaritimas * 1852 / 1000;

            Console.WriteLine($"o valor em quilometros é : {quilometros}");




        }
    }
}
