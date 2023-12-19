using System.Xml.Linq;

namespace Final_Exam_Q5
{
    //Program defines an adjacency list and adjacency graph for given digraph
    internal class Program
    {
        //Represents the eight colors in the diagram
        public enum Color
        {
            Red,
            Navy,
            Gray,
            Blue,
            Yellow,
            Orange,
            Purple,
            Green
        }
        //Adjacency matrix
        static int[,] mGraph = new int[,]
        {
            //        Red   Navy   gray  blue  yellow  orange  purp  green
            /*Red*/ {-1, 1, 5, -1, -1, -1, -1, -1},
            /*Navy*/{-1, -1, -1, 1, 8, -1, -1, -1},
            /*Gray*/{-1, -1, -1, 0, -1, 1, -1, -1},
            /*blue*/{-1, 1, 0, -1, -1, -1, -1, -1},
            /*yellow*/{-1, -1, -1, -1, -1, -1, -1, 6 },
            /*orang*/{-1, -1, -1, -1, -1, -1, 1, -1 },
            /*purp*/{-1, -1, -1, -1, 1, -1, -1, -1 },
            /*green*/{-1, -1, -1, -1, -1, -1, -1, -1 }
        };

        //Adjacency list graph
        static int[][] lGraph = new int[][]
        {
            /*Red*/ new int[]{ (int)Color.Navy, (int)Color.Gray},
            /*Navy*/ new int[]{ (int)Color.Blue, (int)Color.Yellow},
            /*Gray*/ new int[]{ (int)Color.Blue, (int)Color.Orange},
            /*blue*/ new int[]{ (int)Color.Navy, (int)Color.Gray},
            /*yellow*/ new int[]{ (int)Color.Green},
            /*orang*/ new int[]{ (int)Color.Purple},
            /*purp*/ new int[]{ (int)Color.Yellow},
            /*green*/ null
        };
        //Parallel graph for lGraph with Adjacency list weights
        static int[][] wGraph = new int[][]
        {
            /*Red*/ new int[]{1,5},
            /*Navy*/ new int[]{1,8},
            /*Gray*/ new int[]{0,1},
            /*blue*/ new int[]{1,0},
            /*yellow*/ new int[]{6},
            /*orang*/ new int[]{1},
            /*purp*/ new int[]{1},
            /*green*/ null
        };

        static List<Node> game = new List<Node>();
        static public List<Node> GetShortestPathDijkstra()
        {
            // set up all distances from every vertex to the start vertex
            DijkstraSearch();

            // the list of nodes that will be the shortest path from the start
            List<Node> shortestPath = new List<Node>();

            // add the target node
            shortestPath.Add(game[(int)Color.Green]);

            // populate the List of nodes from the target node back to the start
            BuildShortestPath(shortestPath, game[(int)Color.Red]);

            // reverse the List to give the path from the start to the finish
            shortestPath.Reverse();

            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }

        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = game[(int)Color.Red];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            // next 2 lines are equivalent
            //Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            Func<Node, int> nodeOrderBy = NodeOrderBy;

            do
            {
                // sort our prioQueue by minCostToStart
                // option #1, use .Sort() which sorts in place
                prioQueue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // the next 5 lines are equivalent from descriptive to abbreviated:
                prioQueue = prioQueue.OrderBy(nodeOrderBy).ToList();
                prioQueue = prioQueue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => n.minCostToStart).ToList();
                prioQueue = prioQueue.OrderBy(n => n.minCostToStart).ToList();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in node.edges)
                // if we do not sort each list of edges after populating them for a node,
                // we can create a temporary sorted list for this loop
                //foreach (Edge cnn in node.edges.OrderBy(delegate(Edge n) { return n.cost; }))
                {
                    // look at the neighbor connected to this edge
                    Node neighborNode = cnn.connectedNode;
                    if (neighborNode.visited)
                    {
                        // skip if we already visited this neighbor
                        continue;
                    }

                    // if this neighbor has not been evaluated yet or
                    // it is closer than the current path to start
                    if (neighborNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < neighborNode.minCostToStart)
                    {
                        // update the cost to start
                        neighborNode.minCostToStart = node.minCostToStart + cnn.cost;

                        // set the node heading back to start from this neighbor to the 
                        // node we got here by
                        neighborNode.nearestToStart = node;

                        // if we don't have this neighbor in our queue
                        if (!prioQueue.Contains(neighborNode))
                        {
                            // add it
                            prioQueue.Add(neighborNode);
                        }
                    }
                }

                // set this node as visited
                node.visited = true;

                // if we reached the target node
                if (node == game[(int)Color.Green])
                {
                    // we're done!
                    return;
                }

                // stay in this loop while there are any items left in our queue
            } while (prioQueue.Any());
        }
    }

    public class Node : IComparable<Node>
    {
        public int nState;
        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(int nState)
        {
            this.nState = nState;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }
}

