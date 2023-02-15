namespace Lesson4.Generics;

public record CachedValue<T>
{
    public T? Value { get; init; }
    public DateTime CreationTime { get; init; }
    public int Timeout { get; init; }
}