using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string vogal = Console.ReadLine().ToUpper();
            int cont = 0;

            for (int i=0 ; i< vogal.Length; i++)
            {
                 switch (vogal[i])
                 {
                     case "A":
                        cont ++;
                        break;

                     case "E":
                        cont ++;
                        break;

                     case "I":
                        cont ++;
                        break;

                     case "O":
                        cont ++;
                        break;

                     case "U":
                        cont ++;
                        break;

                 }
            }

            Console.WriteLine(cont);
        }
    }
}
