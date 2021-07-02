using System;

namespace CabService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO CAB SERVICES");
            InvoiceGenerator invoice = new InvoiceGenerator(RideType.Ridetype.NORMAL);
            double fare = invoice.CalculateFare(10.0, 12);
            Console.WriteLine("the total fair is::"+fare);

        }
    }
}
