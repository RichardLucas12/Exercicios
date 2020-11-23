using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string  combustivel = "";
            double quant = 0; 
            

            Console.WriteLine("qual o tipo de combustivel");
            combustivel = Console.ReadLine();

            Console.WriteLine("quantidade de combustivel em L ");
            quant = float.Parse(Console.ReadLine());

             double precoa = 4.90*quant; 
             double precog = 5.30*quant;
            if( combustivel == "alcool")
            {
             
                if(quant <= 20 )
                {
                    double desc3 = (3.0/100.0)*quant;
                    double result = precoa-desc3; 
                    Console.WriteLine($"o valor é de {result} ");
                    

                }else{
                    double desc5 = (3.0/100.0)*quant;
                    double result = precoa-desc5; 
                    Console.WriteLine($"o valor é de {result} ");
                }
                
            }else {
                if(quant <= 20 )
                {
                    double desc4 = (4.0/100.0)*quant;
                    double result = precog-desc4; 
                    Console.WriteLine($"o valor é de {result} ");
                    

                }else{
                    double desc6 = (6.0/100.0)*quant;
                    double result = precog-desc6; 
                    Console.WriteLine($"o valor é de {result} ");
                }

            }

        }
    }
}
