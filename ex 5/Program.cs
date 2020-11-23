using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deseja ver tabuada");
            string resp = Console.ReadLine(); 

                for (int i = 0; i <= 10; i++)
                {
                   int result1=i*1;
                   int result2=i*2;
                   int result3=i*3;
                   int result4=i*4;
                   int result5=i*5;
                   int result6=i*6;
                   int result7=i*7;
                   int result8=i*8;
                   int result9=i*9;
                   int result10=i*10;
                   
                   Console.WriteLine($" \n {i} x 1 :{result1} ");           
                   Console.WriteLine($" {i} x 2 :{result2}"); 
                   Console.WriteLine($" {i} x 3 :{result3}"); 
                   Console.WriteLine($" {i} x 4 :{result4}"); 
                   Console.WriteLine($" {i} x 5 :{result5}"); 
                   Console.WriteLine($" {i} x 6 :{result6}"); 
                   Console.WriteLine($" {i} x 7 :{result7}"); 
                   Console.WriteLine($" {i} x 8 :{result8}"); 
                   Console.WriteLine($" {i} x 9 :{result9}"); 
                   Console.WriteLine($" {i} x 10 :{result10}"); 

                }


                   

         }
    }
}

