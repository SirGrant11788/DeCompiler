using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

namespace Prog3BTask1
{
    class GraphDataStructures
    {
       
        public static void startGraph(string OPF, RichTextBox richTextBox, DataGridView gvGraph)
        {
            
            //graph stuff
            int nodeCount = 0, nodeSubCount = 0, relationshipNum = 0; ;
            List<Node> nodes = new List<Node>();//classes
            foreach (Type typeClassA in Assembly.LoadFile(OPF).GetTypes())
            {
                if (typeClassA.IsPublic)
                {
                    nodes.Add(new Node<string>(typeClassA.Name.ToString()));//adds nodes/classes

                }
            }
            List<Edge> edges = new List<Edge>();//subclasses
            foreach (Type typeClassA in Assembly.LoadFile(OPF).GetTypes())
            {
                if (typeClassA.IsPublic)
                {
                    foreach (Type typeClassB in Assembly.LoadFile(OPF).GetTypes())
                    {
                        if (typeClassB.IsPublic)
                        {
                            if (typeClassB.IsSubclassOf(typeClassA))
                            {
                                edges.Add(new Edge(nodes[nodeCount], nodes[nodeSubCount]));//adds edges that are sub classees
                                relationshipNum++;
                            }
                            nodeSubCount++;//moves to next sub class
                        }
                    }
                    nodeCount++;//moves to next class
                    nodeSubCount = 0;//resets sub nodes to stop overshooting
                    gvGraph.Rows.Add(typeClassA.Name, relationshipNum);
                    relationshipNum = 0;//resets number of relationships/subclasses a class has
                }
            }
            //sorting grid views
            gvGraph.Sort(gvGraph.Columns["b"], ListSortDirection.Descending);
            gvGraph.AutoResizeColumns();
            gvGraph.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            Graph graph = new Graph(edges, nodes);

            //testing and outputting to console
            Console.WriteLine("Inital graph:");
            Console.WriteLine("Nodes:");
            graph.Nodes.ToConsole();
            Console.WriteLine("Edges:");
            graph.Edges.ToConsole();

            //writes to rich text box
            richTextBox.AppendText("Inital graph:\n");
            richTextBox.AppendText("\nNodes:\n");
            graph.Nodes.RichTextBoxGraph(richTextBox);
            richTextBox.AppendText("\nEdges:\n");
            graph.Edges.RichTextBoxGraph(richTextBox);

            //writes to text file
            using (StreamWriter writetext = new StreamWriter(@"graph.txt"))
            {
                writetext.WriteLine("Direct Graph Data Structure " + DateTime.Now);
                writetext.Close();
            }
            graph.Nodes.textFile();
            graph.Edges.textFile();

        }
        
    }
    //graph stuff
    public static class EnumerableHelper
{
    public static void ToConsole<T>(this IEnumerable<T> enumerable)
    {
        foreach (T item in enumerable)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine("");
    }
        public static void RichTextBoxGraph<T>(this IEnumerable<T> enumerable, RichTextBox richTextBox)
        {
            
            foreach (T item in enumerable)
            {
                richTextBox.AppendText(item.ToString()+"\n");
            }
        }
        public static void textFile<T>(this IEnumerable<T> enumerable)
        {
            using (StreamWriter writetext = new StreamWriter(@"graph.txt",append: true))
            {
                foreach (T item in enumerable)
                {
                    writetext.Write(item.ToString() + "\n");
                }
                writetext.Close();
            }
        }

    }

    public abstract class Node
    {
        public Graph Graph { get; internal set; }

        public List<Edge> InboundEdges
        {
            get
            {
                return Graph.Edges.Where(e => e.To == this).ToList();
            }
        }

        public List<Edge> OutboundEdges
        {
            get
            {
                return Graph.Edges.Where(e => e.From == this).ToList();
            }
        }
    }

    public class Node<T> : Node
    {
        public T Payload { get; private set; }

        public Node(T payload)
        {
            this.Payload = payload;
        }

        public override string ToString()
        {
            return this.Payload.ToString();
        }
    }
    public class Edge
    {
        public Node From { get; private set; }

        public Node To { get; private set; }

        public Edge(Node from, Node to)
        {
            this.From = from;
            this.To = to;
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1}", this.From, this.To);
        }
    }
    public class Graph
    {
        public List<Edge> Edges { get; private set; }

        public List<Node> Nodes { get; private set; }

        public Graph(List<Edge> edges, List<Node> nodes)
        {
            this.Edges = edges;
            this.Nodes = nodes;
            foreach (Node node in nodes)
            {
                node.Graph = this;
            }
        }
    }
}

