using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int anoat = 0;
            int nasc = 0;
            int diferença = 0;

            Console.WriteLine("digite o ano atual !");
            anoat = int.Parse(Console.ReadLine());

            Console.WriteLine("digite a data de nascimento!");
            nasc = int.Parse(Console.ReadLine());

            diferença = anoat - nasc;

            if(diferença <= 16 )
            {
                Console.WriteLine("não é possivel votar \n menor de 16 anos");
            }else
            {
                Console.WriteLine("habito a votar ");
            }

        }
    }
}
