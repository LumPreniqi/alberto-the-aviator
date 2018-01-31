using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoAviator
{
    class AlbertoTheAviator
    {
        public static int MaximumFlights(int F, int[] durations, int[] refuel)
        {
            List<Flight> flights = new List<Flight>();

            for (int i = 0; i < durations.Length; i++)
			{
                if (F >= durations[i])
                    flights.Add(new Flight(durations[i] - refuel[i], durations[i]));
			}

            flights.Sort((flightA, flightB) => flightA.delta == flightB.delta ? 
                flightA.duration - flightB.duration : flightA.delta.CompareTo(flightB.delta));

            return flights.Aggregate(0, (nrOfFlights, nextFlight) => {
                F -= nextFlight.delta;
                return F >= 0 ? nrOfFlights += 1 : nrOfFlights;
            });
        }
    }
}
