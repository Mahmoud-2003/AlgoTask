using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALgoTask2
{
    using System;
    using System.Collections.Generic;

    public partial class Kruskal
    {
        public class Edge
        {
            public int Src, Dest, Weight;
            public Edge(int src, int dest, int weight)
            {
                Src = src;
                Dest = dest;
                Weight = weight;
            }
        }

        public static List<Edge> KruskalMST(int V, List<Edge> edges)
        {
            edges.Sort((a, b) => a.Weight.CompareTo(b.Weight));

            DisjointSet ds = new DisjointSet(V);
            List<Edge> mst = new List<Edge>();

            foreach (Edge edge in edges)
            {
                int srcRoot = ds.Find(edge.Src);
                int destRoot = ds.Find(edge.Dest);

                if (srcRoot != destRoot)
                {
                    mst.Add(edge);
                    ds.Union(srcRoot, destRoot);
                }
            }

            return mst;
        }
    }

}
