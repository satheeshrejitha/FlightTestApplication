using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFlights.Console
{
    public class FlightBuilderService : IFlightBuilderService
    {
       IFlightBuilder? _iFlightBuilder;

       
        ConsoleFlightOutput IFlightBuilderService.GetFilightInformation()
        {
            _iFlightBuilder=new FlightBuilder();
            IList<Flight_Model> flights = _iFlightBuilder.GetFlights();

            IList<ConsoleFlightOutput> FlightOutput = new List<ConsoleFlightOutput>();
            FlightBuilderService_Filter oFilter = new FlightBuilderService_Filter();
            ConsoleFlightOutput consoleFlightOutput1 = oFilter.filterOutput(flights);

            return consoleFlightOutput1;
        }

        
    }
}
