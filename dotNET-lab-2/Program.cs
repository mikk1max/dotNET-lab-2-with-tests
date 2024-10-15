using dotNET_Lab_2;
using System.Linq;

UsdCourse.Current = await UsdCourse.GetUsdCourseAsync();

List<Fruit> fruits = new List<Fruit>();

for (int i = 0; i < 15; i++)
{
    fruits.Add(Fruit.Create());
}

fruits = fruits.Where(x => x.IsSweet == true).OrderByDescending(x => x.Price).ToList();

foreach (var item in fruits)
{
    Console.Write(item + "\n");
}