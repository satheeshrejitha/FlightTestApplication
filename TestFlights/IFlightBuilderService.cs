using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using TravelRepublic.FlightCodingTest;



namespace TestFlights.Console
{
    public interface IFlightBuilderService
    {
       
        ConsoleFlightOutput GetFilightInformation();

       // IList<Flight_Model> GetFlights();

    }
}
