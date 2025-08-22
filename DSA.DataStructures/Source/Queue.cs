namespace DSA.DataStructures;

public class Queue
{
    public List<int> Storage { get; private set; }

    public Queue()
    {
        Storage = new List<int>();
    }

    public bool IsEmpty()
    {
        return Storage.Count == 0;
    }

    public void Enqueue(int value)
    {
        Storage.Add(value);
    }

    public int Dequeue(int value)
    {
        if (IsEmpty())
            throw new Exception("queue is empty");

        int front = Storage[0];
        Storage.RemoveAt(0);
        return front;
    }

    public int First()
    {
        if (IsEmpty())
            throw new Exception("queue is empty");

        int front = Storage[0];
        return front;
    }

    public int Last()
    {
        if (IsEmpty())
            throw new Exception("queue is empty");

        int last = Storage[Storage.Count - 1];
        return last;
    }

    public int Length()
    {
        return Storage.Count;
    }

}