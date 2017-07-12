using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrosHermione
{
    class Livro
    {
        public string Titulo;
        public int NumeroDePagina;
        public int Devol;
        public int QuantosDias;

        public int Dias(int horas, int PaginaPorHora)
        {
            int qtd = PaginaPorHora * horas;

            QuantosDias = NumeroDePagina / qtd;

            return QuantosDias;
        }
    }
}
