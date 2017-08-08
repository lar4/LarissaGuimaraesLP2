using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
       
                string resp;

                Temperatura Temp = new Temperatura();

                Console.WriteLine("INforme a temperatura em Celsius");
                Temp.celsius = int.Parse(Console.ReadLine());


                Console.WriteLine("Deseja converter para Kelvin? ");
                resp = Console.ReadLine();


                if (resp == "sim")
                {
                    Console.WriteLine(Temp.ParaKelvin());
                }

                else
                    Console.WriteLine(Temp.ParaFahrenheit());

            }
        }
    }

