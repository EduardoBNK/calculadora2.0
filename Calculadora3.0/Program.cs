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


            for (string contador = " "; contador != "stop";)
            {
               

            


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








                switch (Console.ReadLine())
                {


                    case "1":

                        Console.WriteLine(valor1 + valor2);
                        break;

                    case "2":

                        Console.WriteLine(valor1 - valor2);
                        break;


                    case "3":
                        if (valor1 >= valor2)


                            Console.WriteLine(valor1 / valor2);
                        else Console.WriteLine("Divisão errada");


                        break;


                    case "4":

                        Console.WriteLine(valor1 * valor2);
                        break;

                    case "5":

                        Console.WriteLine("EXIT");

                        break;










                }
                Console.WriteLine("Quer continuar?");
                contador = Console.ReadLine();


            }

            



                Console.ReadKey();
        }

    }
}







