// See https://aka.ms/new-console-template for more information

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //SimpleLinkedList();
        //TestSimpleTree();
        //TestGraph();
        TestTries();

        Console.ReadKey();
    }
    private static void TestTries()
    {
       var t = new Trie();
        t.Insert("apple");
        t.Insert("app");
        t.Insert("bat");

    }

    private static void TestGraph()
    {
        Graph graph = new Graph();
        graph.AddEdge("1","2");
        graph.AddEdge("2","3");
        graph.AddEdge("3","4");
        graph.AddEdge("4","1");
        graph.AddEdge("2","5");
        graph.AddEdge("3","6");
        graph.AddEdge("6","7");

        graph.AddEdge("12","13");

        graph.BFS("1");
        Console.WriteLine("----------");
        graph.DFS("1");
        Console.WriteLine("----------");
        graph.DFS("12");
    }
    private static void TestSimpleTree()
    {
        SimpleTree tree = new SimpleTree();
        tree.AddNode(10);
        tree.AddNode(11);
        tree.AddNode(9);
        tree.AddNode(14);
        tree.AddNode(1);
        tree.AddNode(8);

        tree.Print();
    }

    private static void SimpleLinkedList()
    {
        SimpleLinkedList<string> input = new SimpleLinkedList<string>();
        input.AppendNode("first");
        input.AppendNode("Second");
        input.AppendNode("Third");
        input.AppendNode("Fourth");
        input.AppendNode("Fifth");
        input.AppendNode("Sixth");
        input.Display();
        Console.WriteLine("----remove second-----");
        input.Remove("Second");
        input.Display();

        Console.WriteLine("-----remove first ----");
        input.RemoveFirst();
        input.Display();

        Console.WriteLine("----remove last-----");
        input.RemoveLast();
        input.Display();

        Console.WriteLine("----remove all-----");
        input.RemoveAll();
        input.Display();
    }
}
