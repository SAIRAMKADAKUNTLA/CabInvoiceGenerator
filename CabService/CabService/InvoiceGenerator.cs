using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    public class InvoiceGenerator
    {
        RideType rideType;
        double price_per_km = 0;
        int price_per_min = 0;
        double min_fare = 0;
        public InvoiceGenerator(RideType.Ridetype type)
        {
            try
            {
                if(type == RideType.Ridetype.NORMAL)
                {
                    price_per_km = 10;
                    price_per_min = 1;
                    min_fare = 5;
                }
                if(type == RideType.Ridetype.PREMIUM)
                {
                    price_per_km = 15;
                    price_per_min = 2;
                    min_fare = 20;
                }
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Ride,"Invalid Ride type") ;
            }
        }
        public double CalculateFare(double distance,int time)
        {
            double totalFare = 0;
            try
            {
                totalFare = distance * price_per_km + time * price_per_min;
            }
            catch (CabInvoiceException)
            {
                if (rideType.Equals(null))
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Ride, "NO SUCH RIDE TYPE");
                }
                if(distance <= 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Distance, "NO SUCH distance");
                }
                if(time < 0)
                {
                    throw new CabInvoiceException(CabInvoiceException.ExceptionType.Invalid_Time, "NO SUCH time");
                }
            }
            return Math.Max(totalFare, min_fare);
        }
    }
}
