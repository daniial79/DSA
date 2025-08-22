namespace DSA.DataStructures;

public class Node
{
    public int Data { get; internal set; }
    public Node? Next { get; internal set; }


    public Node(int data, Node? next)
    {
        Data = data;
        Next = next;
    }

    public override string ToString()
    {
        return $"{Data}";
    }
}

public class BidirectionalNode
{
    public BidirectionalNode? Previous { get; internal set; }
    public BidirectionalNode? Next { get; internal set; }
    public int Data { get; internal set; }

    public BidirectionalNode(int data, BidirectionalNode? previous, BidirectionalNode? next)
    {
        Data = data;
        Previous = previous;
        Next = next;
    }

    public override string ToString()
    {
        return $"{Data}";
    }
}