namespace dotNET_Lab_2;
using System;
using System.Globalization;

class Fruit
{
    public string Name;
    public bool IsSweet { get; set; }
    public double Price;
    public double UsdPrice => Price / UsdCourse.Current;

    public static Fruit Create()
    {
        Random r = new Random();
        string[] names = new string[] { "Apple", "Banana", "Cherry", "Durian", "Edelberry", "Grape", "Jackfruit" };
        return new Fruit
        {
            Name = names[r.Next(names.Length)],
            IsSweet = r.NextDouble() > 0.5,
            Price = r.NextDouble() * 10
        };
    }

    public override string ToString()
    {
        // CultureInfo polishCulture = new CultureInfo("pl-PL");
        return $"Fruit: Name={Name}, IsSweet={IsSweet}, Price={Price.ToString("c2")}, UsdPrice={MyFormatter.FormatUsdPrice(UsdPrice)}";
    }

    // public override string ToString()
    // {
    //     CultureInfo polishCulture = new CultureInfo("pl-PL");

    //     return $"Fruit: Name={Name}, IsSweet={IsSweet}, Price={Price.ToString("c2", polishCulture)}, UsdPrice={UsdPrice.ToString("f2")} $";
    // }
}
