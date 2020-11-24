using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int maior=0, menor, i=0, numero=0, tl=10;



            Console.Write("Qual o 1º número? ");
            numero = int.Parse(Console.ReadLine());
            maior = numero;
            menor = numero;

            for(i = 2; i <= tl; i++){
                 Console.Write("Qual o " + i +"º número? ");
                numero = int.Parse(Console.ReadLine());

            if(numero < menor){
                menor = numero;
                }
            if (numero > maior){
                maior = numero;
                }
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("----------------------");
            Console.WriteLine("e o menor número é: " + menor);
        }
    }
}