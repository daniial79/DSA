namespace DSA.DataStructures.Source;

public class LinkedList
{
    public Node Head { get; private set; }
    public Node Tail { get; private set; }
    public int Size { get; private set; }
    public bool IsEmpty => Size == 0;

    public LinkedList(Node node = null)
    {
        Head = node;
        Tail = node;
        Size = Head == null ? 0 : 1;
    }

    public void Display()
    {
        if (IsEmpty)
        {
            Console.WriteLine("null");
            return;
        }

        StringBuilder result = new StringBuilder();
        Node temp = Head;

        while (temp != null)
        {
            result.Append(temp.Data + " => ");
            temp = temp.Next;
        }

        result.Append("null");
        Console.WriteLine(result.ToString());
    }

    public void AddLast(int value)
    {
        Node newNode = new Node(value, null);

        if (IsEmpty)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }

        Size++;
    }

    public void AddFirst(int value)
    {
        Node newNode = new Node(value, Head);

        if (IsEmpty)
        {
            Tail = newNode;
        }

        Head = newNode;
        Size++;
    }

    public void InsertAt(int value, int position)
    {
        if (position < 1 || position > Size + 1)
            throw new Exception("Position out of range");

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

        Node newNode = new Node(value, null);
        Node temp = Head;
        int index = 1;

        while (index < position - 1)
        {
            temp = temp.Next;
            index++;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
        Size++;
    }

    public void InsertSorted(int value)
    {
        if (IsEmpty || Head.Data >= value)
        {
            AddFirst(value);
            return;
        }

        if (Tail.Data <= value)
        {
            AddLast(value);
            return;
        }

        Node newNode = new Node(value, null);
        Node temp = Head;

        while (temp.Next != null && temp.Next.Data < value)
            temp = temp.Next;

        newNode.Next = temp.Next;
        temp.Next = newNode;
        Size++;
    }

    public void DeleteFirst()
    {
        if (IsEmpty)
            return;

        Head = Head.Next;
        Size--;

        if (IsEmpty)
            Tail = null;
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

            Tail = temp;
            Tail.Next = null;
        }

        Size--;
    }

    public void DeleteAt(int position)
    {
        if (position < 1 || position > Size)
            throw new Exception("Position out of range");

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

        temp.Next = temp.Next.Next;
        Size--;
    }

    public int GetValueAt(int position)
    {
        if (position < 1 || position > Size)
            throw new Exception("Position out of range");

        Node temp = Head;
        int index = 1;

        while (index < position)
        {
            temp = temp.Next;
            index++;
        }

        return temp.Data;
    }

    public int Search(int value)
    {
        Node temp = Head;
        int index = 1;

        while (temp != null)
        {
            if (temp.Data == value)
                return index;

            temp = temp.Next;
            index++;
        }

        return -1;
    }

    public bool IsSorted()
    {
        if (IsEmpty || Size == 1)
            return true;

        Node temp = Head;
        while (temp.Next != null)
        {
            if (temp.Data > temp.Next.Data)
                return false;

            temp = temp.Next;
        }

        return true;
    }

    public void Reverse()
    {
        if (IsEmpty || Size == 1)
            return;

        Node prev = null;
        Node curr = Head;
        Node next = null;
        Tail = Head;

        while (curr != null)
        {
            next = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = next;
        }

        Head = prev;
    }
}

