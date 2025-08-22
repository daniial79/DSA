namespace DSA.DataStructures;

public class Stack
{
    private List<int> Storage { get; } = new List<int>();
    public int Size => Storage.Count;
    public bool IsEmpty => Size == 0;


    public void Display()
    {
        if (Size == 0)
        {
            Console.WriteLine("stack is empty");
            return;
        }

        Console.WriteLine($"{Storage[Size - 1]} <= top");
        for (int i = Size - 2; i >= 0; i--)
            Console.WriteLine(Storage[i]);
    }


    public void Push(int value)
    {
        Storage.Add(value);
    }

    public int Pop()
    {
        if (IsEmpty)
            throw new Exception("stack is empty");

        int lastItem = Storage[Size - 1];
        Storage.RemoveAt(Size - 1);
        return lastItem;
    }

    public int Top()
    {
        if (IsEmpty)
            throw new Exception("stack is empty");

        return Storage[Size - 1];
    }
}