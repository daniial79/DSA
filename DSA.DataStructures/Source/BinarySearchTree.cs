namespace DSA.DataStructures;


public class BinarySearchTree
{
    public TreeNode? Root { get; private set; }

    public BinarySearchTree(TreeNode? node)
    {
        Root = node;
    }

    public bool IterativeSearch(int value)
    {
        TreeNode? temp = Root;

        if (temp == null)
            return false;

        while (temp != null)
        {
            if (temp.Data == value)
                return true;
            else if (temp.Data < value)
                temp = temp.Right;
            else if (temp.Data > value)
                temp = temp.Left;
        }

        return false;
    }


    public bool IterativeInsert(int value)
    {
        TreeNode? locator = null;
        TreeNode? temp = Root;

        while (temp != null)
        {
            locator = temp;

            if (temp.Data == value)
                return false;
            else if (temp.Data < value)
                temp = temp.Right;
            else
                temp = temp.Left;
        }

        TreeNode newNode = new TreeNode(value, null, null);

        if (locator == null)
        {
            Root = newNode;
            return true;
        }


        if (locator.Data < value)
            locator.Right = newNode;
        else
            locator.Left = newNode;

        return true;
    }


    public List<int> LevelOrderTraversal()
    {
        if (Root == null)
            return new List<int>();

        List<int> result = new List<int>();
        TreeNode troot = Root;
        Queue<TreeNode> que = new Queue<TreeNode>();

        que.Enqueue(troot);

        while (que.Count > 0)
        {
            troot = que.Dequeue();
            result.Add(troot.Data);

            if (troot.Left != null)
                que.Enqueue(troot.Left);

            if (troot.Right != null)
                que.Enqueue(troot.Right);
        }

        return result;
    }


    public static bool RecursiveSearch(TreeNode? root, int value)
    {
        if (root == null)
            return false;

        if (root.Data == value)
            return true;

        if (root.Data < value)
            return RecursiveSearch(root.Right, value);

        return RecursiveSearch(root.Left, value);
    }

    public static TreeNode RecursiveInsert(TreeNode? troot, int value)
    {
        if (troot == null)
            return new TreeNode(value, null, null);

        if (value < troot.Data)
            troot.Left = RecursiveInsert(troot.Left, value);
        else if (value > troot.Data)
            troot.Right = RecursiveInsert(troot.Right, value);

        return troot;
    }

    public static List<int> InorderTraversal(TreeNode? troot, List<int> container)
    {
        if (troot != null)
        {
            InorderTraversal(troot.Left, container);
            container.Add(troot.Data);
            InorderTraversal(troot.Right, container);
        }

        return container;
    }

    public static List<int> PreorderTraversal(TreeNode? troot, List<int> container)
    {
        if (troot != null)
        {
            container.Add(troot.Data);
            PreorderTraversal(troot.Left, container);
            PreorderTraversal(troot.Right, container);
        }

        return container;
    }


    public static List<int> PostorderTraversal(TreeNode? troot, List<int> container)
    {
        if (troot != null)
        {
            PostorderTraversal(troot.Left, container);
            PostorderTraversal(troot.Right, container);
            container.Add(troot.Data);
        }

        return container;
    }
}