using System.Globalization;

namespace DSA.DataStructures;


public class Heap
{
    private int csize;
    private int msize;
    private int[] data;

    public int Length => csize;
    public bool IsEmpty => csize == 0;
    public bool IsFull => csize == msize;


    public Heap(int maxSize)
    {
        msize = maxSize;
        csize = 0;
        data = new int[msize + 1];
    }


    public void Display()
    {
        for (int i = 0; i < data.Length; i++)
            Console.Write($"{data[i]} ");
        Console.WriteLine();

    }


    public void Insert(int value)
    {
        if (IsFull)
            return;

        csize++;
        int heapIndex = csize;

        while (heapIndex > 1 && value > data[heapIndex / 2])
        {
            data[heapIndex] = data[heapIndex / 2];
            heapIndex = heapIndex / 2;
        }

        data[heapIndex] = value;
    }


    public int Delete()
    {

        if (IsEmpty)
            throw new Exception("Heap is empty");

        int biggestData = data[1];

        data[1] = data[csize];
        data[csize] = 0;
        csize--;

        int parentIndex = 1;
        int childIndex = parentIndex * 2;

        while (childIndex <= csize)
        {
            if (childIndex < csize && data[childIndex] < data[childIndex + 1])
                childIndex++;


            if (data[parentIndex] < data[childIndex])
            {
                int temp = data[parentIndex];
                data[parentIndex] = data[childIndex];
                data[childIndex] = temp;

                parentIndex = childIndex;
                childIndex = parentIndex * 2;
            }
            else
            {
                break;
            }
        }

        return biggestData;
    }


    public static int[] Sort(int[] array)
    {
        int[] result = new int[array.Length];
        Heap containerHeap = new Heap(array.Length);

        for (int i = 0; i < array.Length; i++)
            containerHeap.Insert(array[i]);

        for (int i = array.Length - 1; i >= 0; i--)
            result[i] = containerHeap.Delete();

        return result;
    }
}