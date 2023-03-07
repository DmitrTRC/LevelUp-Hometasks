
using Lesson4.Generics;


var sCache = new SimpleGenericCache<string>();

var iCache = new SimpleGenericCache<int>();

var lstICache = new SimpleGenericCache<List<int>?>();


sCache.Store("Name", "Dmitry");
sCache.Store("Surname", "Korobko");
sCache.Store("Age", "30");

Console.WriteLine(sCache.Fetch("Name"));
Console.WriteLine(sCache.Fetch("Surname"));
Console.WriteLine(sCache.Fetch("Age"));

Console.WriteLine(sCache.Fetch("LastName"));


iCache.Store("Age", 30);
iCache.Store("Height", 180);
iCache.Store("Weight", 80);

Console.WriteLine(iCache.Fetch("Age"));
Console.WriteLine(iCache.Fetch("Height"));
Console.WriteLine(iCache.Fetch("Weight"));

Console.WriteLine(iCache.Fetch("Age2"));

lstICache.Store("Numbers", new List<int> {1, 2, 3, 4, 5});
lstICache.Store("Numbers2", new List<int> {6, 7, 8, 9, 10});

Console.WriteLine(string.Join(", ",
    lstICache.Fetch("Numbers") ?? new List<int>())); // ?? new List<int>() - to avoid NullReferenceException
Console.WriteLine(string.Join(", ", lstICache.Fetch("Numbers2") ?? new List<int>()));