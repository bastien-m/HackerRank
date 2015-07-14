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
            #region Caesar cipher
            //String firstMessage = String.Empty;
            //do
            //{
            //    Console.WriteLine("Message a convertir : ");
            //    firstMessage = Console.ReadLine();
            //    Console.WriteLine("L'entier de decalage : ");
            //    int shift = Int32.Parse(Console.ReadLine());
            //    CaesarCipher cipher = new CaesarCipher(firstMessage, shift);
            //    cipher.Resolve();
            //    Console.WriteLine(cipher.GetResult());

            //} while (firstMessage.Equals("stop") == false);
            #endregion


            #region LibraryFine
            /*
            Console.WriteLine("Actual date: ");
            String actualDate = Console.ReadLine();

            Console.WriteLine("Expected date: ");
            String expectedDate = Console.ReadLine();


            
            try
            {
                short[] expectedDateSplit = expectedDate.Split(' ').Select(x => Int16.Parse(x)).ToArray();
                short[] actualDateSplit = actualDate.Split(' ').Select(x => Int16.Parse(x)).ToArray();

                DateTime expectedDateFormatted = new DateTime(expectedDateSplit[2], expectedDateSplit[1], expectedDateSplit[0]);
                DateTime actualDateFormatted = new DateTime(actualDateSplit[2], actualDateSplit[1], actualDateSplit[0]);

                LibraryFine libraryFine = new LibraryFine(actualDateFormatted, expectedDateFormatted);
                libraryFine.Resolve();
                Console.WriteLine(libraryFine.GetResult());
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Format de la date invalide [" + ex.Message + "]");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Erreur sur le format de l'input [" + fe.Message + "]");
            }
            */
            #endregion


            #region AngryProfessor

            int numberOfTestCase = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfTestCase; i++)
            {
                int[] N_K = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                List<int> arrivalsTime = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            }


            AngryProfessor angryProfessor = new AngryProfessor(4, 3, new List<int>(){-1, -3, 1, 2});
            angryProfessor.Resolve();
            Console.WriteLine(angryProfessor.GetResult());

            #endregion

            //Break
            Console.ReadLine();
        }
    }
}
