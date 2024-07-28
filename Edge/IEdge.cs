using DiGraph.Vertex;
namespace DiGraph.Arc;

public interface IArc<T>
{
    IVertex<T> From { get; }
    IVertex<T> To { get; }
}