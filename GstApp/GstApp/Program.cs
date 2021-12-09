using System;
using GstUtilities;

namespace GstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Gst gst = new Gst(10000, 10);
            Console.WriteLine($"GST Amount is:{gst.CalculateGstAmt()}");
            Console.WriteLine($"Total Product Amount is:{gst.CalculateTotalProAmt()}");
            Console.ReadLine();
        }
    }
}
