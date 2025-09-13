using DSA.DataStructures.Source;

namespace DSA.DataStructures;

public class HashChaining
{
    private int tableSize;
    private LinkedList[] buckets;

    public HashChaining(int size)
    {
        tableSize = size;
        buckets = new LinkedList[tableSize];
        for (int i = 0; i < tableSize; i++)
            buckets[i] = new LinkedList();
    }

    public int Hash(int data)
    {
        return Math.Abs(data % tableSize);
    }

    public void Display()
    {
        for (int i = 0; i < tableSize; i++)
        {
            Console.Write($"[{i}]");
            buckets[i].Display();
        }
    }

    public bool Contains(int data)
    {
        int bucketIndex = Hash(data);

        LinkedList chain = buckets[bucketIndex];

        Node temp = chain.Head;
        while (temp != null && temp.Data > data)
        {
            if (temp.Data == data)
                return true;
            temp = temp.Next;
        }

        return false;
    }

    public void Insert(int data)
    {
        int bucketIndex = Hash(data);
        buckets[bucketIndex].InsertSorted(data);
    }
}