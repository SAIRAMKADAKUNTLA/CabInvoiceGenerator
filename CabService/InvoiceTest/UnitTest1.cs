using NUnit.Framework;
using CabService;

namespace InvoiceTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.Ridetype.NORMAL);
        [Test]
        public void Given_distance_and_time_return_totalfare()
        {
            //Arrange
            double distance = 10.0;
            int time = 12;
            //Act
            double result = invoiceGenerator.CalculateFare(distance,time);
            double expected = 112;
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}