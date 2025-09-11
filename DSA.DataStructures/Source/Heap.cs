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
        data = new int[msize];
    }
}