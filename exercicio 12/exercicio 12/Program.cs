using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite os valores dos produtos");
            double valor1 = Convert.ToDouble(Console.ReadLine());
            double valor2 = Convert.ToDouble(Console.ReadLine());   
            double valor3 = Convert.ToDouble(Console.ReadLine());
            double valor4 = Convert.ToDouble(Console.ReadLine());
            double valor5 = Convert.ToDouble(Console.ReadLine());
            double soma;

            soma = valor1 + valor2 + valor3 + valor4  + valor5;

            Console.WriteLine(soma);

            Console.WriteLine("digite o valor do pagamento");
            double pag = Convert.ToDouble(Console.ReadLine());

            double troco;

            troco = pag - soma;

            Console.WriteLine(troco);





            



   





        }
    }
}
