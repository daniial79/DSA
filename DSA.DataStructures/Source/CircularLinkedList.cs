using System.Threading.Channels;

namespace DSA.DataStructures;





public class CircularLinkedList
{
    public Node? Head { get; private set; }
    public Node? Tail { get; private set; }
    public int Size { get; private set; }
    public bool IsEmpty => Size == 0;

    public CircularLinkedList(Node? node)
    {
        Head = node;
        Tail = node;
        Size = Head == null ? 0 : 1;

        if (Head != null)
            Tail.Next = Head;
    }


    public void Display()
    {
        if (IsEmpty)
        {
            Console.WriteLine("null");
            return;
        }

        Node temp = Head;
        int index = 0;

        while (index < Size)
        {
            Console.Write($"{temp.Data} ");
            temp = temp.Next;
            index++;
        }

        Console.WriteLine();
    }

    public void AddFirst(int value)
    {
        Node newNode = new Node(value, null);

        if (IsEmpty)
        {
            Head = newNode;
            Tail = newNode;
            Tail.Next = Head;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
            Tail.Next = Head;
        }

        Size++;
    }

    public void AddLast(int value)
    {
        Node newNode = new Node(value, null);

        if (IsEmpty)
        {
            Head = newNode;
            Tail = newNode;
            Tail.Next = Head;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
            Tail.Next = Head;
        }

        Size++;
    }

    public void AddAt(int value, int position)
    {
        if (position <= 0)
            throw new Exception("position must be greater than zero");

        if (position > Size + 1)
            throw new Exception("position must be <= Size + 1");

        if (position == 1)
        {
            AddFirst(value);
            return;
        }

        if (position == Size + 1)
        {
            AddLast(value);
            return;
        }

        Node temp = Head;
        int index = 1;

        while (index < position - 1)
        {
            temp = temp.Next;
            index++;
        }

        Node newNode = new Node(value, temp.Next);
        temp.Next = newNode;
        Size++;
    }

    public void DeleteFirst()
    {
        if (IsEmpty)
            return;

        if (Size == 1)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Head = Head.Next;
            Tail.Next = Head;
        }

        Size--;
    }

    public void DeleteLast()
    {
        if (IsEmpty)
            return;

        if (Size == 1)
        {
            Head = null;
            Tail = null;
        }
        else
        {
            Node temp = Head;
            while (temp.Next != Tail)
                temp = temp.Next;

            temp.Next = Head;
            Tail = temp;
        }

        Size--;
    }

    public void DeleteAt(int position)
    {
        if (IsEmpty)
            return;

        if (position <= 0)
            throw new Exception("position must be greater than zero");

        if (position > Size)
            throw new Exception("position must be <= Size");

        if (position == 1)
        {
            DeleteFirst();
            return;
        }

        if (position == Size)
        {
            DeleteLast();
            return;
        }

        Node temp = Head;
        int index = 1;
        while (index < position - 1)
        {
            temp = temp.Next;
            index++;
        }

        Node target = temp.Next;
        temp.Next = target.Next;
        target.Next = null;

        Size--;
    }
}
