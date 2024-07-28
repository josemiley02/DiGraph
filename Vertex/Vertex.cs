
namespace DiGraph.Vertex;

public class Vertex<T> : IVertex<T>
{
    public Vertex(T value, int id)
    {
        Value = value;
        Id = id;
        Neighbors = [];
    }

    public int Id { get; }
    public T Value { get; }
    public int Degree => InDegree + OutDegree;
    public int InDegree { get; }
    public int OutDegree { get; }
    public List<IVertex<T>> Neighbors { get; }

    public override string ToString()
    {
        return $"{Value}, {Degree}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Vertex<T>)
        {
            return Value!.Equals(((Vertex<T>)obj).Value);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return Value!.GetHashCode();
    }
}