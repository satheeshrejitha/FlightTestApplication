using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFlights.Console
{
    internal class FlightBuilderService_Filter
    {
        public ConsoleFlightOutput filterOutput(IList<Flight_Model> flights)
        {

            var departDate = (from flightDeparture in flights
                              where flightDeparture.Segments.Any(x => x.DepartureDate < DateTime.Now)
                              select flightDeparture).ToList();

            var arrivalDateBeforeDeparture = (from flightDeparture in flights
                                              where flightDeparture.Segments.Any(x => x.ArrivalDate > x.DepartureDate)
                                              select flightDeparture);

            var flghtMorethanTwoHours = (from flightDeparture in flights
                                         where flightDeparture.Segments.Count > 2
                                         select flightDeparture);


            ConsoleFlightOutput consoleFlightOutput1 = new ConsoleFlightOutput();
            consoleFlightOutput1.DepartEarliers = new List<Segment>();
            consoleFlightOutput1.SegmentWithArriavalDates = new List<Segment>();
            consoleFlightOutput1.SpendTwoHourGround = new List<Segment>();

            Segment oSegment;
            foreach (var flight in departDate)
            {
                oSegment = new Segment();
                oSegment.FlightName = "Cathy Pacific";
                oSegment.FlightNo = "A21334";
                oSegment.ArrivalDate = flight.Segments[0].ArrivalDate;
                oSegment.DepartureDate = flight.Segments[0].DepartureDate;
                consoleFlightOutput1.DepartEarliers.Add(oSegment);

            }
            // consoleFlightOutputs.Add(consoleFlightOutput1);

            foreach (var flight in flghtMorethanTwoHours)
            {
                oSegment = new Segment();
                oSegment.FlightName = "Cathy Pacific";
                oSegment.FlightNo = "A34343";
                oSegment.ArrivalDate = flight.Segments[0].ArrivalDate;
                oSegment.DepartureDate = flight.Segments[0].DepartureDate;
                consoleFlightOutput1.SpendTwoHourGround.Add(oSegment);

            }

            foreach (var flight in arrivalDateBeforeDeparture)
            {
                oSegment = new Segment();
                oSegment.FlightName = "Cathy Pacific";
                oSegment.FlightNo = "A34343";
                oSegment.ArrivalDate = flight.Segments[0].ArrivalDate;
                oSegment.DepartureDate = flight.Segments[0].DepartureDate;
                consoleFlightOutput1.SegmentWithArriavalDates.Add(oSegment);

            }

            return consoleFlightOutput1;

        }
    }
}
