namespace DSA.Algorithms;


public class Sorting
{
    private void swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }


    private int[] merge(int[] lArray, int[] rArray)
    {
        int lPointer = 0;
        int rPointer = 0;

        int[] combined = new int[lArray.Length + rArray.Length];
        int index = 0;

        int lSize = lArray.Length;
        int rSize = rArray.Length;

        while (lPointer < lSize && rPointer < rSize)
        {
            if (lArray[lPointer] < rArray[rPointer])
            {
                combined[index] = lArray[lPointer];
                lPointer++;
            }
            else
            {
                combined[index] = rArray[rPointer];
                rPointer++;
            }

            index++;
        }

        while (lPointer < lSize)
        {
            combined[index] = lArray[lPointer];
            lPointer++;
            index++;
        }

        while (rPointer < rSize)
        {
            combined[index] = rArray[rPointer];
            rPointer++;
            index++;
        }

        return combined;
    }


    private int partition(int[] array, int low, int high)
    {
        int pivot = low;
        low++;

        while (low < high)
        {
            while (low <= high && array[low] < array[pivot])
            {
                low++;
            }

            while (low <= high && array[high] > array[pivot])
            {
                high--;
            }

            swap(array, low, high);
            low++;
        }

        swap(array, high, pivot);

        return high;

    }

    public void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int position = i;

            for (int j = i + 1; j < array.Length; j++)
                if (array[j] < array[position])
                    position = j;


            if (position != i)
                swap(array, position, i);
        }
    }


    public void InsertionSort(int[] array)
    {
        if (array.Length == 1 || array.Length == 0)
            return;

        for (int i = 1; i < array.Length; i++)
        {
            int j = i;
            while (j != 0 && array[j] < array[j - 1])
            {
                swap(array, j, j - 1);
                j--;
            }
        }
    }


    public void BubbleSort(int[] array)
    {
        if (array.Length == 0 || array.Length == 1)
            return;

        for (int i = array.Length - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (array[j - 1] > array[j])
                    swap(array, j - 1, j);
            }
        }
    }


    public void ShellSort(int[] array)
    {

    }

    public int[] MergeSort(int[] array)
    {
        if (array.Length <= 1)
            return array;

        int mid = array.Length / 2;

        int[] leftSubArray = array[..mid];
        int[] rightSubArray = array[mid..];

        return merge(MergeSort(leftSubArray), MergeSort(rightSubArray));
    }

    public void QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = partition(array, low, high);
            QuickSort(array, low, pivotIndex + 1);
            QuickSort(array, pivotIndex + 1, high);
        }
    }
}
