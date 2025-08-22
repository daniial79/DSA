using DSA.DataStructures;


namespace Program;


public class Program
{
    public static void Main(string[] args)
    {
        Stack ms = new Stack();

        for (int i = 0; i <= 10; i++)
            ms.Push(i);


        ms.Display();
    }
}