public class SimpleTree
{
    TreeNode _root;

    public void AddNode(int input)
    {
        TreeNode current = new TreeNode();
        current.value=input;

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
        if(input.value<=parent.value)
        {
            if(parent.left==null)
            {
                parent.left=input;
            }
            else
            {
                AddNode(parent.left,input);
            }
        }
        //go right
        if(input.value>parent.value)
        {
            if(parent.right==null)
            {
                parent.right=input;
            }
            else
            {
                AddNode(parent.right,input);
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
        PrintChildNode(input.left);
        Console.WriteLine($"{input.value}-->");
        PrintChildNode(input.right);
    }
}