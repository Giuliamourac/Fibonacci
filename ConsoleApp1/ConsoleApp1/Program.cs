using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] agrs)
        {

            Console.WriteLine("Digite a quantidade de termos");

            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci:");

            int um = 0;

            int dois = 1;
            
            int tres = 1;

            Console.WriteLine( $"{um} \n{dois} \n{tres}" );

            for (int i = 0; i <= quantidade; i++)
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
