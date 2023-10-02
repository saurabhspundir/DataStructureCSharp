public class SimpleLinkedList<T>
{
    private Node<T> head;
    private Node<T> tail;

    public void AppendNode(T input)
    {
        Node<T> nodeInput = new Node<T>();
        nodeInput.Data = input;
        if (head == null)
        {
            head = nodeInput;
            tail = nodeInput;
        }
        else
        {
            tail.Next=nodeInput;
            tail = nodeInput;
        }
    }

    public void Display()
    {
        if (head == null)
        {
            return;
        }
        Node<T> current = head;
        while (current.Next != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
        Console.WriteLine(current.Data);
    }
    //addin between

    public void RemoveFirst()
    {
        Node<T> current = head;
        head = current.Next;
    }
    //remove last
    public void RemoveLast()
    {
        Node<T> current = head;
        while (current.Next != null)
        {
            if (current.Next.Equals(tail))
            {
                tail = current;
                current.Next=null;
                tail.Next=null;
                return;
            }
            current = current.Next;
        }
    }
    //remove all
    public void RemoveAll()
    {
        Node<T> current = head;
        while (current.Next != null)
        {
            Node<T> next = current.Next;
            current.Next=null;
            current = next;
        }
        head = null;
    }
    //remove specific
    public void Remove(T input)
    {
        Node<T> current = head;
        Node<T> previous = head;
        Node<T> selected;
        while (current.Next != null)
        {
            if (current.Data.Equals(input))
            {
                selected = current;
                previous.Next=selected.Next;
                return;
            }
            previous = current;
            current = current.Next;
        }
    }
}