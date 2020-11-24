using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
                int c = 1; 
                for (int i = 1; i < 11; i++)
                {
                   for (int n = 1; n <= 10 ;n++)
                   {
                       Console.WriteLine($" {n} x {c} = {n*c} ");
                   }
                   Console.WriteLine("  ");
                       c++;
                }


                   

         }
    }
}

