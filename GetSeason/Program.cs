using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSeasonClassLibrary.GetSeasonClass currentSeason = new GetSeasonClassLibrary.GetSeasonClass();

            string season = currentSeason.GetSeason();

            Console.WriteLine(season);
            Console.ReadKey();
        }
    }
}
