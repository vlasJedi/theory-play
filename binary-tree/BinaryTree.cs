namespace binary_tree;

public class BinaryTree
{
    private BinaryTreeNode? _root;
    public void Insert(string key, string someText)
    {
        if (_root == null)
        {
            Console.WriteLine($"Created root node with key: {key} and value: {someText}");
            _root = new BinaryTreeNode(key, someText);
            return;
        }
        InsertLeftRight(_root, key, someText);
    }

    private void InsertLeftRight(BinaryTreeNode parent, string key, string someText)
    {
        var isParentGreater = parent.NodeKey.CompareTo(key);
        if (isParentGreater == 0)
        {
            Console.WriteLine($"Node key: {key} already exist, replacing value");
            parent.NodeValue = someText;
            return;
        }
        if (isParentGreater > 0)
        {
            if (parent.Left == null)
            {
                Console.WriteLine($"For parent: {parent.NodeKey} inserting left child: {key}");
                parent.Left = new BinaryTreeNode(key, someText);
                return;
            }
            InsertLeftRight(parent.Left, key, someText);
            return;
        }
        if (parent.Right == null)
        {
            Console.WriteLine($"For parent: {parent.NodeKey} inserting right child: {key}");
            parent.Right = new BinaryTreeNode(key, someText);
            return;
        }

        InsertLeftRight(parent.Right, key, someText);
    }
}

public class BinaryTreeNode
{
    public BinaryTreeNode(string key, string value)
    {
        NodeKey = key;
        NodeValue = value;
    }
    public string NodeKey { get; set; }
    public string NodeValue { get; set; }
    public BinaryTreeNode? Left { get; set; }
    public BinaryTreeNode? Right { get; set; }
}