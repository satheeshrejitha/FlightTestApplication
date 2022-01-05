using System;
using System.Collections.Generic;
using System.Linq;

namespace TestFlights.Console
{
    public class FlightBuilder: IFlightBuilder
    {
      //  List<FlightDetails> listFlights = new List<FlightDetails> ();

        public FlightBuilder()
        {
            //listFlights.Add(new FlightDetails() { FlightNo = 1001, FlightName = "Jet Airways", ArrivalTime = DateTime.Now.AddHours(1), DepartureTime = DateTime.Now.AddHours(3) });
            //listFlights.Add(new FlightDetails() { FlightNo = 1002, FlightName = "Jet Airways", ArrivalTime = DateTime.Now.AddHours(1), DepartureTime = DateTime.Now.AddHours(3) });
            //listFlights.Add(new FlightDetails() { FlightNo = 1003, FlightName = "Jet Airways", ArrivalTime = DateTime.Now.AddHours(1), DepartureTime = DateTime.Now.AddHours(3) });

        }
      

        public IList<Flight_Model> GetFlights()
        {
            var threeDaysFromNow = DateTime.Now.AddDays(3);

            return new List<Flight_Model>
            {
                // A normal flight with two hour duration
                CreateFlight(threeDaysFromNow, threeDaysFromNow.AddHours(2)),

                // A normal multi-segment flight
                CreateFlight(threeDaysFromNow, threeDaysFromNow.AddHours(2), threeDaysFromNow.AddHours(3), threeDaysFromNow.AddHours(5)),
                
                // A flight departing in the past
                CreateFlight(threeDaysFromNow.AddDays(-6), threeDaysFromNow),

                // A flight that departs before it arrives
                CreateFlight(threeDaysFromNow, threeDaysFromNow.AddHours(-6)),

                // A flight with more than two hours ground time
                CreateFlight(threeDaysFromNow, threeDaysFromNow.AddHours(2), threeDaysFromNow.AddHours(5), threeDaysFromNow.AddHours(6)),

                // Another flight with more than two hours ground time
                CreateFlight(threeDaysFromNow, threeDaysFromNow.AddHours(2), threeDaysFromNow.AddHours(3), threeDaysFromNow.AddHours(4), threeDaysFromNow.AddHours(6), threeDaysFromNow.AddHours(7))
            };
        }

        private static Flight_Model CreateFlight(params DateTime[] dates)
        {
            if (dates.Length % 2 != 0) 
                throw new ArgumentException("You must pass an even number of dates,", "dates");

            var departureDates = dates.Where((date, index) => index % 2 == 0);
            var arrivalDates = dates.Where((date, index) => index % 2 == 1);

            var segments = departureDates
                .Zip(arrivalDates, (departureDate, arrivalDate) => new Segment() { DepartureDate = departureDate, ArrivalDate = arrivalDate,FlightName="" })
                .ToList();

            return new Flight_Model { Segments = segments };
        }


    }

   
}

