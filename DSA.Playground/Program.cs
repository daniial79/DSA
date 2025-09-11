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
        myHeap.Display();

        myHeap.Insert(2);
        myHeap.Display();

        myHeap.Insert(15);
        myHeap.Display();

        myHeap.Insert(200);
        myHeap.Display();
        
        
        

    }
}