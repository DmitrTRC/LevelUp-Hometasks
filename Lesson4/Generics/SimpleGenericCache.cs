namespace Lesson4.Generics;

internal class SimpleGenericCache<T>
{
    private readonly Dictionary<string, CachedValue<T>?> _cache = new();

    internal void Store(string key, T value, int timeout = 30)
    {
        _cache[key] = new CachedValue<T>
        {
            Value = value,
            CreationTime = DateTime.Now,
            Timeout = timeout
        };
    }

    internal T? Fetch(string key) // Return default if not found
    {
        if (_cache.TryGetValue(key, out var cachedValue))
        {
            if (cachedValue.CreationTime.AddSeconds(cachedValue.Timeout) > DateTime.Now)
            {
                return cachedValue.Value;
            }
        }

        return default;
    }
}