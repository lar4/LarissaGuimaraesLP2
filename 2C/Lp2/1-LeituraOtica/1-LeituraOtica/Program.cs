using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_LeituraOtica
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int A,B,C,D,E ;

            Console.WriteLine("Indorme o números de questões");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                int respok=0;
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                D = int.Parse(Console.ReadLine()); 
                E = int.Parse(Console.ReadLine());

                if (A <= 100 && B >= 155 && C >= 155 && D >= 155)
                {
                    Console.WriteLine("A");
                    respok++;
                }

                if (B <= 100 && B >= 155 && C >= 155 && D >= 155)
                {
                    Console.WriteLine("B");
                    respok++;
                }

                if (C <= 100 && B >= 155 && C >= 155 && D >= 155)
                {
                    Console.WriteLine("C");
                    respok++;
                }

                if (D <= 100 && B >= 155 && C >= 155 && D >= 155)
                {
                    Console.WriteLine("D");
                    respok++;
                }

                if (E <= 100 && B >= 155 && C >= 155 && D >= 155)
                {
                    Console.WriteLine("E");
                    respok++;
                }
                else 
                {
                    Console.WriteLine("*");
                }
             }
        }

    }
}
