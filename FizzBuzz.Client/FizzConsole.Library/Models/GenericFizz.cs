using System;
using System.Collections.Generic;
using System.Text;

namespace FizzConsole.Library.Models
{
    public class GenericFizz
    {
        int fizz = 0;
        int buzz= 0;
        int fizzbuzz=0;
        int fizztext { get; set; }
        int buzztext { get; set; }
        int fbtext { get; set; }
        int index { get; set; }
       
        public void Input()//void means we dont have to return something specifically
        {
            Console.WriteLine("How much would you like to divide fizz by?");
            int fizzran;
            bool x = Int32.TryParse(Console.ReadLine(), out fizzran);
                if (x && fizzran != 0)
            {
                fizztext = fizzran;
            }
                else
            {
                Input();
            }

            Console.WriteLine("How much would you like to divide buzz by?");
            int buzzran;
             x = Int32.TryParse(Console.ReadLine(), out buzzran);
            if (x && buzzran != 0)
            {
                buzztext = buzzran;
            }
            else
            {
                Input();
            }
       
            Console.WriteLine("How many FizzBuzz would you like?");
            int fizzbuzzran;
            x = Int32.TryParse(Console.ReadLine(), out fizzbuzzran);
            if(x && fizzbuzzran != 0)
            {
                fbtext = fizzbuzzran;
            }
            else
            {
                Input();
            }

            while (fizzbuzz < fbtext)
            {
                if (index % fizztext == 0)
                {
                    fizz++;
                }

                if (index % buzztext == 0)
                {
                    buzz++;
                }
            
                if(index % buzztext == 0  && index % fizztext == 0)
                {
                    fizzbuzz++;
                }
                    
                index++;

            }

            Console.WriteLine(buzz);
            Console.WriteLine(fizz);
            Console.WriteLine(fizzbuzz);
        }
            
       





    }


    
    
}
