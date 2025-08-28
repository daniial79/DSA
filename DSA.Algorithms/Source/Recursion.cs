namespace DSA.Algorithms;

public abstract class Recursion
{

    public void CalculateIterative(int number)
    {
        for (int i = number; i > 1; i--)
        {
            Console.WriteLine(i * 2);
        }
    }

    public void CalculateRecursive(int number)
    {
        if (number > 0)
        {
            Console.WriteLine(number * number);
            CalculateRecursive(number - 1);
        }
    }


    public void CalculateHead(int n)
    {
        if (n > 0)
        {
            CalculateHead(n - 1);
            int k = n * n;
            Console.WriteLine(k);
        }
    }

    public void CalculateTail(int n)
    {
        if (n > 0)
        {
            int k = n * n;
            Console.WriteLine(k);
            CalculateTail(k);
        }
    }

    public void CalculateTree(int n)
    {
        if (n > 0)
        {
            CalculateTree(n - 1);
            int k = n * n;
            Console.WriteLine(k);
            CalculateTree(n - 1);
        }
    }

    public int SumOfNatural(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n + sumOfNatural(n - 1);
    }

    public int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * factorial(n - 1);
    }
}
