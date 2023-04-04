using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //invertir cadena
            //a,b,c,d,e
            //e,d,c,b,a

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
           
            for (int i = cars.Length-1; i >= 0; i--)
            {
              Console.WriteLine(cars[i]);    
            }

            Console.ReadLine();

            
            




        }
    }
}
