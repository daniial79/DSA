using DSA.DataStructures;

namespace Program;


public class Program
{
    public static void Main(string[] args)
    {
        Heap myHeap = new Heap(10);

        myHeap.Display();

        myHeap.Insert(20);
        myHeap.Display();

        myHeap.Insert(14);
        myHeap.Insert(18);
        myHeap.Display();

        myHeap.Delete();
        myHeap.Display();

        myHeap.Delete();
        myHeap.Display();
        
        myHeap.Delete();
        myHeap.Display();
    }
}