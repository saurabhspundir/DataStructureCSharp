namespace DataStructureCSharp.SimpleLinkedList
{
    public class SimpleLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public void AppendNode(T input)
        {
            Node<T> nodeInput = new Node<T>();
            nodeInput.data = input;
            if (head == null)
            {
                head = nodeInput;
                tail = nodeInput;
            }
            else
            {
                tail.next = nodeInput;
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
            while (current.next != null)
            {
                Console.WriteLine(current.data);
                current = current.next;
            }
            Console.WriteLine(current.data);
        }
        //addin between

        public void RemoveFirst()
        {
            Node<T> current = head;
            head = current.next;
            current = null;
        }
        //remove last
        public void RemoveLast()
        {
            Node<T> current = head;
            while (current.next != null)
            {
                if (current.next.Equals(tail))
                {
                    tail = current;
                    current.next = null;
                    tail.next = null;
                    return;
                }
                current = current.next;
            }
        }
        //remove all
        public void RemoveAll()
        {
            Node<T> current = head;
            while (current.next != null)
            {
                Node<T> next = current.next;
                current.next = null;
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
            while (current.next != null)
            {
                if (current.data.Equals(input))
                {
                    selected = current;
                    previous.next = selected.next;
                    selected = null;
                    return;
                }
                previous = current;
                current = current.next;
            }
        }
    }
}