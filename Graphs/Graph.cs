using System.Collections;
using System.Runtime.InteropServices;

public class Graph
{
    public Dictionary<string,List<Vertex>> adjuencyList = new Dictionary<string, List<Vertex>>();
    
    public void AddEdge(string s,string e)
    {
        Vertex end = new Vertex{name=e};
        //add to key and in list
        if(adjuencyList.ContainsKey(s))
        {
            adjuencyList[s].Add(new Vertex{name=e});
        }
        else//create new node
        {
            adjuencyList.Add(s,new List<Vertex>{end});
        }
    }

    public void BFS(string start)
    {
        List<string> travled = new List<string>(adjuencyList.Count);
        Queue<string> queue =new Queue<string>();
        queue.Enqueue(start);
        travled.Add(start);
        while(queue.Count>0)
        {
           var sel=queue.Dequeue();
           Console.WriteLine($"{sel}==>");
           if(adjuencyList.ContainsKey(sel))
           {
                var vertexSelected= adjuencyList[sel];

                if (vertexSelected!=null)
                {
                    for(int i=0;i<vertexSelected.Count ;i++)
                    {
                        var vertexsel=vertexSelected[i].name;

                        if(!travled.Contains(vertexsel))
                        {
                            queue.Enqueue(vertexsel);
                            travled.Add(vertexsel);
                        }
                    }
                }
           }

        }
    }
    public void DFS(string start)
    {
        List<string> travled = new List<string>(adjuencyList.Count);
        Stack<string> queue =new Stack<string>();
        queue.Push(start);
        travled.Add(start);
        while(queue.Count>0)
        {
           var sel=queue.Pop();
           Console.WriteLine($"{sel}==>");
           if(adjuencyList.ContainsKey(sel))
           {
                var vertexSelected= adjuencyList[sel];

                if (vertexSelected!=null)
                {
                    for(int i=0;i<vertexSelected.Count ;i++)
                    {
                        var vertexsel=vertexSelected[i].name;

                        if(!travled.Contains(vertexsel))
                        {
                            queue.Push(vertexsel);
                            travled.Add(vertexsel);
                        }
                    }
                }
           }

        }
        

    }


}