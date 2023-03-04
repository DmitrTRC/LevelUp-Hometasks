using System.Collections.Concurrent;

void PrintRootsRange(int min, int max)
{
    ConcurrentDictionary<int, double> roots = new ConcurrentDictionary<int, double>();

    Parallel.For(min, max, (i) => { roots.TryAdd(i, Math.Sqrt(i)); });

    foreach (var root in roots)
    {
        System.Console.WriteLine($"{root.Key} : {root.Value}");
    }
}

PrintRootsRange(2, 100);