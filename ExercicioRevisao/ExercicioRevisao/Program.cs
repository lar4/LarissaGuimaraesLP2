using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string modelo, carro,forca;
            double kmRod, potencia;
            int n, qtd ;

             Console.WriteLine("informe a qtd de carro");
             n=Convert.ToInt32(Console.ReadLine()) ;
          
            for (int i=0;i <= n ; i++)
            {
                Console.WriteLine("informe o modelo");
                modelo= Console.ReadLine();

                Console.WriteLine("informe a quilometragem rodada");
                kmRod=Convert.ToDouble(Console.ReadLine());

                
                Console.WriteLine("informe a potencia do motor");
                potencia=Convert.ToDouble(Console.ReadLine());

                if(kmRod <= 500)
                     
                    carro= "novo";

                else if  (kmRod <=3000)

                     carro = "seminovo";

                else 
                  
                        carro ="velho";

                if (potencia > 200)

                    forca = "potente";

                else if (potencia >= 120 && potencia <= 200)

                    forca = "forte";
                else

                    forca = "popular";

                Console.WriteLine("{0} - {1} - {2} ",modelo,carro, forca);
        }
    }
}
