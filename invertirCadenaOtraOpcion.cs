using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace invetirCadena2
{
    class Program
    {
        //3->0, 2->1, 1->0
        //


        static void Main(string[] args)
        {
            String[] letras = { "a", "b", "c","d","e","f","g","h","i","j","k","l","m","n","ñ","o","p","q","r","s","t","u","v","w","x","y","z"};
            String[] letrasInvertidas = new String[letras.Length];
                        
            for (int i = letras.Length-1; i >=0; i--)
            {               
                letrasInvertidas[letras.Length-1-i] = letras[i];    
            }

            for (int i = 0; i <= letrasInvertidas.Length-1; i++)
            {
                Console.Write(letrasInvertidas[i] + '\n');                
            }

            Console.ReadLine();
        }
    }
}