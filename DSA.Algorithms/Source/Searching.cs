namespace DSA.Algorithms;


public abstract class Searching<T> where T : IComparable<T>
{

    public int LinearSearch(List<T> list, T value)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Equals(value))
            {
                return i;
            }
        }

        return -1;
    }

    public int BinarySearchIterative(List<T> data, T value)
    {
        int first = 0;
        int last = data.Count - 1;

        int middle = (first + last) / 2;

        int comparisonResult = data[middle].CompareTo(value);

        while (first <= last)
        {
            if (data[middle].Equals(value))
            {
                return middle;
            }
            else if (comparisonResult < 0)
            {
                first = middle + 1;
            }
            else if (comparisonResult > 0)
            {
                last = middle - 1;
            }
        }

        return -1;

    }


    public int BinarySearchRecursive(List<T> data, T value, int left, int right)
    {


        if (left > right)
        {
            return -1;
        }

        int middle = (left + right) / 2;
        int comparisonResult = data[middle].CompareTo(value);
        int result = 0;

        if (comparisonResult == 0)
        {
            result = middle;
        }
        else if (comparisonResult < 0)
        {
            left = middle + 1;
            result = binarySearchRecursive(data, value, left, right);
        }
        else if (comparisonResult > 0)
        {
            right = middle - 1;
            result = binarySearchRecursive(data, value, left, right);
        }

        return result;
    }      
}