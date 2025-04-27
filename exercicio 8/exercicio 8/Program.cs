using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite a temperatura em graus celsius");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"A temperatura em Fahrenheit é :{fahrenheit} F");
        }
    }
}
