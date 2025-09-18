using DSA.DataStructures;

namespace Program;


public class Program
{
    public static void Main(string[] args)
    {
        Graph mg = new Graph(10);

        mg.Display();

        mg.InsertEdge(3, 4);

        mg.Display();

    }
}