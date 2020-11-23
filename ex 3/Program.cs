using System;

namespace ex_3
{
    class Program
    {
        private const int V = 2;

        static void Main(string[] args)
        
        {
            string prod = "";
            int quant = 0;
            float prec = 0;
            float total = 0;
            double tap= 0;
            

            Console.WriteLine("digite o nome do pruduto");
            prod = Console.ReadLine();

            Console.WriteLine("digite a quantidade ");
            quant = int.Parse(Console.ReadLine());

            Console.WriteLine("digite preço do pruduto");
            prec = float.Parse(Console.ReadLine());

            Console.WriteLine("total " + (total = quant*prec));

            if( quant <=5 )
            {
                Console.ForegroundColor = ConsoleColor.Blue;
               double desc2 =  (2.0/100.0)*total ;
               tap = total - desc2;  
               Console.WriteLine(value: $"DESCONTO DE 2% ");
               Console.WriteLine($"total a pagar {tap} ");
                

            }else if( (quant >5) && (quant <10 ) ){
                
                Console.ForegroundColor = ConsoleColor.Red;
                double desc3 =  (3.0/100.0)*total ;
               tap = total - desc3;  
               Console.WriteLine(value: $"DESCONTO DE 3% ");
               Console.WriteLine($"total a pagar {tap} ");

            }else if( (quant >= 6)  && (quant >10 ) ){
                
                Console.ForegroundColor = ConsoleColor.Yellow;
               double desc5 =  (5.0/100.0)*total ;
               tap = total - desc5;  
               Console.WriteLine(value: $"DESCONTO DE 5% ");
               Console.WriteLine($"total a pagar {tap} ");
 
            }

        }
    }
}
