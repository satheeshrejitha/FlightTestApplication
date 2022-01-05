using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using TestFlights.Console;
using Assert = NUnit.Framework.Assert;

namespace TestFlights_Test
{
    [TestClass]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestMethod]
        public void Test1()
        {
            IFlightBuilderService flightBuilder = new FlightBuilderService();
            ConsoleFlightOutput output = flightBuilder.GetFilightInformation();

            Assert.IsNotNull(output);
            Assert.IsTrue(output.DepartEarliers.Count > 0);
            Assert.IsTrue(output.SegmentWithArriavalDates.Count > 0);
        }
    }
}