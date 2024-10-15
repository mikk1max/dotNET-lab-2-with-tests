namespace dotNET_Lab_2;
using System.Globalization;


public class MyFormatter
{
    public static string FormatUsdPrice(double price)
    {
        var usc = new CultureInfo("en-us");
        return price.ToString("C2", usc);
    }
}