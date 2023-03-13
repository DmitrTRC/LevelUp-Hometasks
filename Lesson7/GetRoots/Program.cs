using System.Collections.Concurrent;

void PrintRootsRange(int min, int max) {
    ConcurrentDictionary<int, double> roots = new ConcurrentDictionary<int, double>();

    // Check min and max values
    if (min < 0 || max < 0)
    {
        Console.WriteLine("Invalid range.");
        return;
    }

    Parallel.For(Math.Min(min, max),
        Math.Max(max, min),
        (i) => { roots.TryAdd(i, Math.Sqrt(i)); });


    foreach (var root in roots)
    {
        Console.WriteLine($"{root.Key} : {root.Value}");
    }
}

PrintRootsRange(20, 2);
PrintRootsRange(5, 10);
PrintRootsRange(-100, -100);