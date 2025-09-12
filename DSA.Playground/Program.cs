using DSA.DataStructures;

namespace Program;


public class Program
{
    public static void Main(string[] args)
    {
        HashChaining myHashTable = new HashChaining(10);

        myHashTable.Insert(10);
        myHashTable.Insert(20);
        myHashTable.Insert(12);
        myHashTable.Insert(45);
        myHashTable.Insert(99);
        myHashTable.Insert(23);
        myHashTable.Insert(11);
        myHashTable.Insert(11);

        myHashTable.Display();
    }
}