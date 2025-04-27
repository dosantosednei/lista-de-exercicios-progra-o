using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite o primeiro valor : ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo valor : ");
            double valor2 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o terceiro valor : ");
            double valor3 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o quarto valor ");
            double valor4 = double.Parse(Console.ReadLine());

            double soma = valor1 + valor2 + valor3 + valor4;
            double media = soma / 4;

            Console.WriteLine("A média aritimética é :" + media);


            
            
           
            
           

           
            

            
            

            
            

            
            

            
            











        }
    }
}
