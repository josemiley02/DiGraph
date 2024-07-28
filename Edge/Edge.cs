using DiGraph.Vertex;
namespace DiGraph.Arc;

public class Arc<T> : IArc<T>
{
    public Arc(IVertex<T> from, IVertex<T> to)
    {
        From = from;
        To = to;
    }

    public IVertex<T> From { get; }
    public IVertex<T> To { get; }

    public override string ToString()
    {
        return $"{From} -> {To}";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Arc<T>)
        {
            var e = (Arc<T>)obj;
            return e.From.Equals(From) && e.To.Equals(To);
        }
        return false;
    }
    public override int GetHashCode()
    {
        return From.GetHashCode() + To.GetHashCode();
    }
}