using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] agrs)
        {

            Console.WriteLine("Digite a quantidade de termos");

            int quantidade = Convert.ToInt32(Console.ReadLine());

            int um = 0;

            int dois = 1;
            
            int tres = 1;

            if (quantidade <= 0 )
            {

                Console.WriteLine( "escreva um numero maior que zero" );

            }

            else
            {

                Console.WriteLine("Fibonacci:");

                Console.WriteLine($"{um} \n{dois} \n{tres}");

                for (int i = 1; i <= quantidade; i++)
                {

                    int temp = tres;

                    tres = dois + tres;

                    um = dois;

                    dois = temp;

                    Console.WriteLine(tres);

                }

            }

        }

    }



}
