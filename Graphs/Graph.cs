using System.Collections;
using System.Runtime.InteropServices;

public class Graph
{
    public Dictionary<string, List<Vertex>> adjuencyList = new Dictionary<string, List<Vertex>>();

    public void AddEdge(string s, string e)
    {
        Vertex end = new Vertex { Value = e };
        //add to key and in list
        if (adjuencyList.ContainsKey(s))
        {
            adjuencyList[s].Add(new Vertex { Value = e });
        }
        else//create new node
        {
            adjuencyList.Add(s, new List<Vertex> { end });
        }
    }

    public void BFS(string start)
    {
        //visited keep track of which node already traversed
        List<string> visited = new List<string>(adjuencyList.Count);
        //Queue used for BFS
        Queue<string> queue = new Queue<string>();
        queue.Enqueue(start);//add root
        visited.Add(start);//mark root visited 

        //run until any node left to process 
        //note : in the loop istelf the child node keep getting added(Enqueue) and hence queue gets element as we tarvel in bfs style
        while (queue.Count > 0)
        {
            // it will bring top most node , as we adding node as visited
            var current = queue.Dequeue();
            Console.WriteLine($"{current}==>");
            
            // add all the child nodes of this node. This is way to keep adding  nodes child as we on that node
            //note: if there is no adjuency of the node , that is leaf node
            if (adjuencyList.ContainsKey(current))
            {
                //get all child node    
                var childVertexes = adjuencyList[current];

                if (childVertexes != null)
                {
                    //traverse child node
                    for (int i = 0; i < childVertexes.Count; i++)
                    {
                        var childVertex = childVertexes[i].Value;

                        // only visit if not visted to avoid infinite loop
                        if (!visited.Contains(childVertex))
                        {
                            //add the node and mark visited
                            queue.Enqueue(childVertex);
                            visited.Add(childVertex);
                        }
                    }
                }
            }
        }
    }
    
    public void DFS(string start)
    {
        //visited keep track of which node already traversed
        List<string> visited = new List<string>(adjuencyList.Count);
        //Stack used for DFS
        Stack<string> stack = new Stack<string>();

        stack.Push(start);//add root
        visited.Add(start);//mark root visited 

        //run until any node left to process 
        //note : in the loop istelf the child node keep getting added(Push) and hence stacks gets element as we tarvel in dfs style
        while (stack.Count > 0)
        {
             // it will bring top most node , as we adding node as visited
            var current = stack.Pop();
            Console.WriteLine($"{current}==>");

            // add all the child nodes of this node. This is way to keep adding  nodes child as we on that node
            //note: if there is no adjuency of the node , that is leaf node
            if (adjuencyList.ContainsKey(current))
            {
                //get all child node  
                var childVertexes = adjuencyList[current];

                if (childVertexes != null)
                {
                   //traverse child node
                    for (int i = 0; i < childVertexes.Count; i++)
                    {
                        var childVertex = childVertexes[i].Value;

                        // only visit if not visted to avoid infinite loop
                        if (!visited.Contains(childVertex))
                        {
                            //add the node and mark visited
                            stack.Push(childVertex);
                            visited.Add(childVertex);
                        }
                    }
                }
            }
        }
    }
}