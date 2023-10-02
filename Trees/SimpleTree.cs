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

    private void AddNode(TreeNode parent, TreeNode input)
    {
        //go left
        if(input.Value<=parent.Value)
        {
            if(parent.Left==null)
            {
                parent.Left=input;
            }
            else
            {
                AddNode(parent.Left,input);
            }
        }
        //go right
        if(input.Value>parent.Value)
        {
            if(parent.Right==null)
            {
                parent.Right=input;
            }
            else
            {
                AddNode(parent.Right,input);
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