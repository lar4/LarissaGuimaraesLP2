﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperaturaCelsius
{
    class Temperatura
    {
        
            public double celsius;


            public double ParaFahrenheit()
            {
                return (celsius * 9 / 5) + 32;

            }

            public double ParaKelvin()
            {
                return celsius + 273;
            }
        }
}
