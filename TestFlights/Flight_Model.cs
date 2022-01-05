using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestFlights.Console
{
   

    public class Flight_Model
    {
        public List<Segment> Segments { get; set; }
    }


    public class Segment
    {

        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public string? FlightNo { get; set; }
        public string? FlightName { get; set; }
        // public FlightDetails? FlightDetails { get; set; }
    }

    /*public class DepartEarlier
    {
        public List<Segment> DepartEarliers { get; set; }
    }

    public class SegmentWithArriavalDate
    {
        public List<Segment> SegmentWithArriavalDates { get; set; }
    }

    public class SpendTwoHoursGround
    {
        public List<Segment> SpendTwoHourGround { get; set; }
    }*/
    public class ConsoleFlightOutput
    {
        public List<Segment> DepartEarliers { get; set; }
        public List<Segment> SegmentWithArriavalDates { get; set; }
        public List<Segment> SpendTwoHourGround { get; set; }

        internal void ForEach(Action<object> p)
        {
            throw new NotImplementedException();
        }
     
    }
   
}
