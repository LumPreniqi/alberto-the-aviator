using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoAviator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jepe vleren e F prej 1 deri ne 5000: ");
            int F = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jepe vleren e durations prej 1 deri ne 5000: ");
            int[] durations = Helpers.StringToArray(Console.ReadLine());
            Console.Write("Jepe vleren e durations prej 1 deri ne 5000: ");
            int[] refuel = Helpers.StringToArray(Console.ReadLine());

            int maxFlight = AlbertoTheAviator.MaximumFlights(F, durations, refuel);

            Console.WriteLine("Per F: {0}, durations: {1} dhe refuel: {2} numri maksimal i fluturimeve eshte: {3}", F, Helpers.ArrayToString(durations), Helpers.ArrayToString(refuel), maxFlight);

            Console.ReadLine();
        }
    }
}
