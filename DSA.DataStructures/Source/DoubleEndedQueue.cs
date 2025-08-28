namespace DSA.DataStructures;


public class DeQueue
{
    public List<int> Storage { get; private set; }
    public bool IsEmpty => Storage.Count == 0;

    public DeQueue()
    {
        Storage = new List<int>();
    }


    public void AddFirst(int value)
    {
        Storage.Insert(0, value);
    }

    public void AddLast(int value)
    {
        Storage.Add(value);
    }

    public int RemoveFirst()
    {
        if (IsEmpty)
            throw new Exception("queue is empty");

        int first = Storage[0];
        Storage.RemoveAt(0);
        return first;
    }

    public int RemoveLast()
    {
        if (IsEmpty)
            throw new Exception("queue is empty");


        int lastIndex = Storage.Count - 1;
        int last = Storage[lastIndex];
        Storage.RemoveAt(lastIndex);
        return last;
    }

    public int First()
    {
        if (IsEmpty)
            throw new Exception("queue is empty");

        return Storage[0];
    }

    public int Last()
    {
        if (IsEmpty)
            throw new Exception("queue is empty");

        return Storage[Storage.Count - 1];
    }

    public int Length()
    {
        return Storage.Count;
    }
}