using DiGraph.Edge;
using DiGraph.Vertex;
namespace DiGraph;

public class Graph<T>
{
    private List<Vertex<T>> Values = [];
    private List<Edge<T>> Edges = [];
    public int CountVertex => Values.Count;
    public int CountEdge => Edges.Count;

    public Graph(params T[] values)
    {
        foreach (var item in values)
        {
            AddVertex(item);
        }
    }
    public void AddVertex(T value)
    {
        var v = new Vertex<T>(value, Values.Count);
        Values.Add(v);
    }
    public void AddEdge(T from, T to)
    {
        var _from = Values.First(x => x.Value!.Equals(from));
        var _to = Values.First(x => x.Value!.Equals(to));
        var e = new Edge<T>(_from, _to, Edges.Count);
        _from.Adjacent.Add(_to);
        Edges.Add(e);
    }
    
}