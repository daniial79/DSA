namespace DSA.Algorithms;

public class Recursion
{

    public void calculateIterative(int number)
    {
        for (int i = number; i > 1; i--)
        {
            Console.WriteLine(i * 2);
        }
    }

    public void calculateRecursive(int number)
    {
        if (number > 0)
        {
            Console.WriteLine(number * number);
            calculateRecursive(number - 1);
        }
    }


    public void calculateHead(int n)
    {
        if (n > 0)
        {
            calculateHead(n - 1);
            int k = n * n;
            Console.WriteLine(k);
        }
    }

    public void calculateTail(int n)
    {
        if (n > 0)
        {
            int k = n * n;
            Console.WriteLine(k);
            calculateTail(k);
        }
    }

    public void calculateTree(int n)
    {
        if (n > 0)
        {
            calculateTree(n - 1);
            int k = n * n;
            Console.WriteLine(k);
            calculateTree(n - 1);
        }
    }

    public int sumOfNatural(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        return n + sumOfNatural(n - 1);
    }

    public int factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * factorial(n - 1);
    }
}
