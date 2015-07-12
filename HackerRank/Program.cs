using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstMessage = String.Empty;
            do
            {
                Console.WriteLine("Message a convertir : ");
                firstMessage = Console.ReadLine();
                Console.WriteLine("L'entier de decalage : ");
                int shift = Int32.Parse(Console.ReadLine());
                CaesarCipher cipher = new CaesarCipher(firstMessage, shift);
                Console.WriteLine(cipher.Resolve());

            } while (firstMessage.Equals("stop") == false);
           
            //Hacker rank main
            Console.ReadLine();
            String message = Console.ReadLine();
            int shift01 = Int32.Parse(Console.ReadLine());
            CaesarCipher cipher01 = new CaesarCipher(firstMessage, shift01);
            Console.WriteLine(cipher01.Resolve());

            //Break
            Console.ReadLine();
        }
    }
}
