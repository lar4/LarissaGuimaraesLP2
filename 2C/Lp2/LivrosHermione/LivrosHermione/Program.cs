using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, PaginaPorHora, N;

            Console.WriteLine(" Informe a quantidade de livros ");
            N = int.Parse(Console.ReadLine());

            Livro[] livros = new Livro[N];
            int[] dias = new int[N];

            for (int i = 0; i < N; i++)
            {

                livros[i] = new Livro();

                Console.WriteLine("Informe o nome do livro");
                livros[i].Titulo = Console.ReadLine();

                Console.WriteLine("Informe a quantidade de páginas");
                livros[i].NumeroDePagina = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe quantos dias há até a devolução ");
                livros[i].Devol = int.Parse(Console.ReadLine());

                Console.WriteLine(" Quantos horas tenho disponível? ");
                horas = int.Parse(Console.ReadLine());

                Console.WriteLine(" Quantas páginas leio por hora? ");
                PaginaPorHora = int.Parse(Console.ReadLine());

                dias[i] = livros[i].Dias(horas, PaginaPorHora);
            }

            for (int i = 0; i < N; i++)
            {

                if (dias[i] <= livros[i].Devol)

                    Console.WriteLine(" Irei ler o livro: {0} em {1} dias, antes da data de devolução", livros[i].Titulo, dias[i]);

                else

                    Console.WriteLine(" É impossível ler o livro {0} antes da data de devolução pois levrei {1} dias", livros[i].Titulo, dias[i]);
            }
        
        }
    }
}
