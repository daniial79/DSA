using System.Text;

namespace DSA.DataStructures;



public class DoublyLinkedList
{
    public BidirectionalNode? Head { get; private set; }
    public BidirectionalNode? Tail { get; private set; }
    public int Size { get; private set; }
    public bool IsEmpty => Size == 0;

    public DoublyLinkedList(BidirectionalNode? node)
    {
        Head = node;
        Tail = node;
        Size = Head == null ? 0 : 1;
    }


    public void Display()
    {
        StringBuilder result = new StringBuilder();

        if (IsEmpty)
        {
            result.Append("null");
        }
        else if (Size == 1)
        {
            result.Append($"<= {Head.Data} =>");
        }
        else
        {
            result.Append($"<= {Head.Data}");

            BidirectionalNode temp = Head.Next;
            while (temp != Tail)
            {
                result.Append($" <=> {temp.Data}");
                temp = temp.Next;
            }

            result.Append($" <=> {Tail.Data} =>");
        }

        Console.WriteLine(result.ToString());
    }

    public void AddFirst(int value)
    {
        BidirectionalNode newNode = new BidirectionalNode(value, null, null);

        if (IsEmpty)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head.Previous = newNode;
            Head = newNode;
        }

        Size++;
    }

    public void AddLast(int value)
    {
        BidirectionalNode newNode = new BidirectionalNode(value, null, null);

        if (IsEmpty)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Previous = Tail;
            Tail.Next = newNode;
            Tail = newNode;
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

        int index = 1;
        BidirectionalNode temp = Head;

        while (index < position - 1)
        {
            temp = temp.Next;
            index++;
        }

        BidirectionalNode newNode = new BidirectionalNode(value, null, null);

        newNode.Next = temp.Next;
        newNode.Previous = temp;

        temp.Next.Previous = newNode;
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
            Head.Previous = null;
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
            Tail = Tail.Previous;
            Tail.Next = null;
        }

        Size--;
    }

    public void DeleteAt(int position)
    {
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

        int index = 1;
        BidirectionalNode temp = Head;


        while (index < position - 1)
        {
            temp = temp.Next;
            index++;
        }

        BidirectionalNode target = temp.Next;

        temp.Next = target.Next;
        target.Next.Previous = temp;

        target.Next = null;
        target.Previous = null;

        Size--;
    }
}
