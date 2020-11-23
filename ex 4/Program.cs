using System;

namespace ex_4
{
    class Program
    {
        static void Main(string[] args)
        
        {
            int[] numb = new int [11];

           for (int i = 0; i <numb.Length ; i++)

           {
              Console.WriteLine("digite os numeros");
              numb [i] = int.Parse(Console.ReadLine()); 
           }
        }
    }
}
