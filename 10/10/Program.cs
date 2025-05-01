using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite os dois valores :");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            double valor2 = Convert.ToDouble(Console.ReadLine());
            
            

            

            double mediageometrica = Math.Sqrt(valor1 * valor2);

            Console.WriteLine("A media geometrica é :{0}",mediageometrica);
            Console.ReadKey();








        }
    }
}
