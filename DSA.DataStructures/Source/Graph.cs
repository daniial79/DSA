namespace DSA.DataStructures;

public class Graph
{
    private int vertices;
    private readonly bool isDirected;
    private int?[,] adjMatrix;

    public Graph(int v, bool directed = false)
    {
        vertices = v;
        isDirected = directed;
        adjMatrix = new int?[v, v];
    }

    private void validateVertex(int v)
    {
        if (v < 0 || v >= vertices)
            throw new Exception($"vertex number must be between 0 and {vertices - 1}");
    }


    public void Display()
    {
        Console.Write("      ");
        for (int i = 0; i < vertices; i++)
            Console.Write($"{i} |");


        Console.WriteLine();
        Console.WriteLine();

        for (int i = 0; i < vertices; i++)
        {
            Console.Write($"{i}  |");
            for (int j = 0; j < vertices; j++)
                Console.Write($"  {adjMatrix[i, j]}");
            Console.WriteLine();
        }
    }


    public void InsertEdge(int u, int v, int w = 1)
    {
        validateVertex(u);
        validateVertex(v);

        adjMatrix[u, v] = w;

        if (!isDirected)
            adjMatrix[v, u] = w;
    }

    public void RemoveEdge(int u, int v)
    {
        validateVertex(u);
        validateVertex(v);

        adjMatrix[u, v] = null;

        if (!isDirected)
            adjMatrix[v, u] = null;
    }


    public bool ExistsEdge(int u, int v)
    {
        validateVertex(u);
        validateVertex(v);

        return adjMatrix[u, v] != null;
    }


    public int VertexCount()
    {
        return vertices;
    }

    public int EdgeCount()
    {
        int count = 0;

        foreach (int? element in adjMatrix)
            if (element.HasValue)
                count++;

        return isDirected ? count : count / 2;
    }

    public int OutDegree(int v)
    {
        validateVertex(v);

        int count = 0;
        for (int i = 0; i < vertices; i++)
            if (adjMatrix[v, i].HasValue)
                count++;
        return count;
    }

    public int InDegree(int v)
    {
        validateVertex(v);

        int count = 0;
        for (int i = 0; i < vertices; i++)
            if (adjMatrix[i, v].HasValue)
                count++;
        return count;
    }

    public int? GetWeight(int u, int v)
    {
        validateVertex(u);
        validateVertex(v);

        return ExistsEdge(u, v) ? adjMatrix[u, v] : null;
    }
}