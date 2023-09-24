// See https://aka.ms/new-console-template for more information
using DataStructureCSharp.SimpleLinkedList;

Console.WriteLine("Hello, World!");
SimpleLinkedList<string>input= new SimpleLinkedList<string>();
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

Console.ReadKey();
