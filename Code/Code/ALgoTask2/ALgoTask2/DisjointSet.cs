namespace ALgoTask2
{
    public partial class Kruskal
    {
        public class DisjointSet
        {
            private int[] parent, rank;

            public DisjointSet(int n)
            {
                parent = new int[n];
                rank = new int[n];
                for (int i = 0; i < n; i++)
                {
                    parent[i] = i;
                    rank[i] = 0;
                }
            }

            public int Find(int u)
            {
                if (parent[u] != u)
                {
                    parent[u] = Find(parent[u]);
                }
                return parent[u];
            }

            public void Union(int u, int v)
            {
                int rootU = Find(u);
                int rootV = Find(v);

                if (rootU != rootV)
                {
                    if (rank[rootU] > rank[rootV])
                        parent[rootV] = rootU;
                    else if (rank[rootU] < rank[rootV])
                        parent[rootU] = rootV;
                    else
                    {
                        parent[rootV] = rootU;
                        rank[rootU]++;
                    }
                }
            }
        }
    }

}
