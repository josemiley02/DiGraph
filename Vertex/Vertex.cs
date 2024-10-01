namespace DiGraph.Vertex;

public class Vertex<T>
{
    public Vertex(T value, int idVertex)
    {
        Value = value;
        IdVertex = idVertex;
    }

    public T Value { get; set; }
    public int InDegree { get; set; }
    public int OutDegree { get; set; }
    public int IdVertex {get; set;}
    public List<Vertex<T>> Adjacent { get; set; } = new List<Vertex<T>>();

    public override string ToString()
    {
        return $"Vertex:{IdVertex}, Value: {Value!.ToString()}";
    }
    public override bool Equals(object? obj)
    {
        if(obj is Vertex<T>)
        {
            var v = obj as Vertex<T>;
            return Value!.Equals(v!.Value) && IdVertex == v.IdVertex;
        }
        throw new ArgumentException("");
    }
    public override int GetHashCode()
    {
        return IdVertex;
    }
}