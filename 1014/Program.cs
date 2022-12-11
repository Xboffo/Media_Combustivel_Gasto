using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distanciaTotalPercorrida, totalDeCombustivelGasto, media;

            distanciaTotalPercorrida = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalDeCombustivelGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            

            media = distanciaTotalPercorrida / totalDeCombustivelGasto;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");







        }
    }
}