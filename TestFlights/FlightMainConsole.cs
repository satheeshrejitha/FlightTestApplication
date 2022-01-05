// See https://aka.ms/new-console-template for more information
using System;
using TestFlights.Console;

 IFlightBuilderService _iFlightBuilderService;

_iFlightBuilderService = new FlightBuilderService();

var flightDisplay = _iFlightBuilderService.GetFilightInformation();

Console.WriteLine("1.Depart before the current date/time\n");
foreach(var flight in flightDisplay.DepartEarliers)
{

    Console.Write("Flight No: " + flight.FlightNo + ", Flight Name: " + flight.FlightName + ", Arrival info:" + flight.ArrivalDate + ", Departure i" +
        "nfo:" + flight.DepartureDate);
    Console.WriteLine("\n");
    
}

Console.WriteLine("2.Have any segment with an arrival date before the departure date\n");
foreach (var flight in flightDisplay.SegmentWithArriavalDates)
{

    Console.Write("Flight No: " + flight.FlightNo+", Flight Name: " + flight.FlightName+", Arrival info:" + flight.ArrivalDate+", Departure info:" + flight.DepartureDate);
    Console.WriteLine("\n");
    
}
Console.WriteLine("3.Spend more than 2 hours on the ground\n ");

foreach (var flight in flightDisplay.SpendTwoHourGround)
{

    Console.Write("Flight No: " + flight.FlightNo + ", Flight Name: " + flight.FlightName + ", Arrival info:" + flight.ArrivalDate + ", Departure info:" + flight.DepartureDate);
    Console.WriteLine("\n");
}


Console.Read();


