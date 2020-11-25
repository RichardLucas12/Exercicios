using System;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numb = new int [16];

            for( int i = 1; i < 16 ; i++)
            {
                Console.WriteLine($"Escreva um número:  ({16 - i} restante(s))");
                numb[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for( int j = 15; j > 0; j--)
            {
                Console.WriteLine( $"{numb[j]} \n \n  ");
            }
        }
    }
}
