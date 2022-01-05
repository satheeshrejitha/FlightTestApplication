using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFlights.Console
{
    public interface IFlightBuilder
    {
        IList<Flight_Model> GetFlights();
    }
}
