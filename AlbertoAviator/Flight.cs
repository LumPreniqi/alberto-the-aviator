using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbertoAviator
{
    class Flight
    {
        public int delta;
        public int duration;

        public Flight(int delta, int duration)
        {
            this.delta = delta;
            this.duration = duration;
        }
    }
}
