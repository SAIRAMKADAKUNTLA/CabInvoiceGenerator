using System;
using System.Collections.Generic;
using System.Text;

namespace CabService
{
    public class CabInvoiceException:Exception
    {
        public enum ExceptionType
        {
            Invalid_Distance,
            Invalid_UserId,
            Invalid_Ride,
            Null_Rides,
            Invalid_Time
        }
        ExceptionType type;
        public CabInvoiceException(ExceptionType type,string message) 
        {
            Console.WriteLine("--Exception type--"+type+"::"+message);
        }
    }
}
