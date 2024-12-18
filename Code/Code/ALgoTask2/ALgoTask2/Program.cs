using static ALgoTask2.Kruskal;

internal class Program
{
    private static void Main(string[] args)
    {
        int V = 4; 
        List<Edge> edges = new List<Edge>
        {
            new Edge(0, 1, 10),
            new Edge(0, 2, 6),
            new Edge(0, 3, 5),
            new Edge(1, 3, 15),
            new Edge(2, 3, 4)
        };

        List<Edge> mst = KruskalMST(V, edges);

        Console.WriteLine("Edges in the MST:");
        foreach (var edge in mst)
        {
            Console.WriteLine($"({edge.Src}, {edge.Dest}) -> {edge.Weight}");
        }
    }
}