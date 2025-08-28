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

    public static void InorderTraverse(TreeNode? troot, List<int> container)
    {
        if (troot != null)
        {
            InorderTraverse(troot.Left, container);
            container.Add(troot.Data);
            InorderTraverse(troot.Right, container);
        }
    }

    public static void PreorderTraverse(TreeNode? troot, List<int> container)
    {
        if (troot != null)
        {
            container.Add(troot.Data);
            PreorderTraverse(troot.Left, container);
            PreorderTraverse(troot.Right, container);
        }
    }


    public static void PostorderTraverse(TreeNode? troot, List<int> container)
    {
        if (troot != null)
        {
            PostorderTraverse(troot.Left, container);
            PostorderTraverse(troot.Right, container);
            container.Add(troot.Data);
        }
    }


}