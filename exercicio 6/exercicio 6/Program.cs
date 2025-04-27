using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite os quatro valores :");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            double valor2 = Convert.ToDouble(Console.ReadLine());   
            double valor3 = Convert.ToDouble(Console.ReadLine());
            double valor4 = Convert.ToDouble(Console.ReadLine());

            double produto = valor1 * valor2 * valor3 * valor4;

            double mediageometrica = Math.Pow(produto, 1.0 / 4.0);

            Console.WriteLine($"A media geometrica é :{mediageometrica}");
            
            

        }
    }
}
