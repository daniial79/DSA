namespace DSA.DataStructures;

public class Queue
{
    public List<int> Storage { get; private set; }
    public bool IsEmpty => Storage.Count == 0;

    public Queue()
    {
        Storage = new List<int>();
    }

    public void Enqueue(int value)
    {
        Storage.Add(value);
    }

    public int Dequeue()
    {
        if (IsEmpty)
            throw new Exception("queue is empty");

        int front = Storage[0];
        Storage.RemoveAt(0);
        return front;
    }

    public int First()
    {
        if (IsEmpty)
            throw new Exception("queue is empty");

        int front = Storage[0];
        return front;
    }

    public int Last()
    {
        if (IsEmpty)
            throw new Exception("queue is empty");

        int last = Storage[Storage.Count - 1];
        return last;
    }

    public int Length()
    {
        return Storage.Count;
    }

}