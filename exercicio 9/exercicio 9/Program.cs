using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o diametro do circulo :");
            double diametro = Convert.ToDouble(Console.ReadLine());

            double raio = diametro / 2;

            double area = Math.PI * raio * raio;

            Console.WriteLine("a area do círculo é : " + area);


        }
    }
}
