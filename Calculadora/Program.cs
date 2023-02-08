using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valor1 = 0;
            double valor2 = 0;
            int opcao = 0;


            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Qual a operação que você quer realizar?" + "\n");
            Console.WriteLine("1º - Soma");
            Console.WriteLine("2º - Subtração");
            Console.WriteLine("3º - Divisão");
            Console.WriteLine("4º - Multiplicação");
            Console.WriteLine("5º - EXIT" + "\n");



            Console.WriteLine("Digite sua opção");
            opcao = Convert.ToInt16(Console.ReadLine());

            if (opcao == 1)
            {
                Console.WriteLine(valor1 + valor2);
            }

            if (opcao == 2)
            {
                Console.WriteLine(valor1 - valor2);
            }

            if (opcao == 3)
            {
                Console.WriteLine(valor1 / valor2);
            }

            if(opcao == 4)
            { 
                Console.WriteLine(valor1 * valor2);
            }
            if(opcao == 5)
            {
                Console.WriteLine("EXIT");
                opcao = (int)Convert.ToDouble(Console.ReadLine());
            }


                
            

              
            
        }
    }
}
