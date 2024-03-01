public class SimpleTree
{
    private TreeNode _root;

    public void AddNode(int input)
    {
        TreeNode current = new TreeNode();
        current.Value=input;

        if (_root==null)
        {
            _root=current;
            return;
        }
            AddNode(_root,current);
    }

    private void AddNode(TreeNode parent, TreeNode child)
    {
        //go left
        if(child.Value<=parent.Value)
        {
            if(parent.Left==null)
            {
                parent.Left=child;
            }
            else
            {
                AddNode(parent.Left,child);
            }
        }
        //go right
        if(child.Value>parent.Value)
        {
            if(parent.Right==null)
            {
                parent.Right=child;
            }
            else
            {
                AddNode(parent.Right,child);
            }
        }        
    }

    public void Print()
    {
            PrintChildNode(_root);
    }
    private void PrintChildNode(TreeNode input)
    {
        if (input==null)
        {
            return;
        }
        PrintChildNode(input.Left);
        Console.WriteLine($"{input.Value}-->");
        PrintChildNode(input.Right);
    }
}