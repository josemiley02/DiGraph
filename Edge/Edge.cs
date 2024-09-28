using DiGraph.Vertex;
namespace DiGraph.Edge;

public class Edge<T>
{
    public Edge(Vertex<T> from, Vertex<T> to, int idEdge)
    {
        From = from;
        To = to;
        IdEdge = idEdge;
    }

    public Vertex<T> From {get; set;}
    public Vertex<T> To {get;}
    public int IdEdge {get; set;}
    public override string ToString()
    {
        return $"<{From.Value},{To.Value}>";
    }
    public override bool Equals(object? obj)
    {
        if(obj is Edge<T> edge)
        {
            return From.Equals(edge.From) && To.Equals(edge.To);
        }
        throw new ArgumentException();
    }
    public override int GetHashCode()
    {
        return From.GetHashCode() + To.GetHashCode();
    }
}