using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace DijkstraAlg
{

    public class Dijkstra
    {
        int X;
        Node[,] nodes;
        Form1 form;
        public Dijkstra(Node[,] nodes, int X)
        {
            this.nodes = nodes;
            this.X = X;
        }

        static int timeLeft;

        public void DijkstraAlg(Form form1)
        {
            Node startNode = FindStart();
            startNode.pathLength = 0;
            Node endNode = FindEnd();
            List<Node> nodesToProcess = new List<Node>();
            nodesToProcess.Add(startNode);


            // foreach - > while sortoeanie 
            while (nodesToProcess.Count>0)
            {
                
                nodesToProcess.OrderBy(x=>x.pathLength);
                Node node = nodesToProcess[0];
                nodesToProcess.RemoveAt(0);

                node.isProcessed = true;
                for(int x = -1; x <= 1; x++)
                {
                    for(int y = -1; y <= 1; y++)
                    {
                        if (x == 0 && y == 0) 
                            continue;
                        int axisX = node.coordinates.X + x;
                        int axisY = node.coordinates.Y + y;
                        if (axisX < 0 || axisY < 0 || axisX >= X || axisY >= X)
                            continue;
                   
                        Node tmpNode = nodes[axisX, axisY]; // somsiod
                        if (tmpNode.isObstacle)
                            continue;

                        int pathBetweenNodes = (x != 0 && y != 0) ? 14 : 10;
                        if(node.pathLength + pathBetweenNodes < tmpNode.pathLength)
                        {
                            tmpNode.pathLength = node.pathLength + pathBetweenNodes;
                            tmpNode.previousNode = node;
                        }


                        if (!tmpNode.isProcessed)
                        {
                            /*myTimer.Interval = 30;
                            myTimer.Start();
                            tmpNode.button.BackColor = Color.Bisque;*/
                            //tmpNode.button.BackColor = Color.Bisque;
                            //Task.Delay(3).Wait();
                            //Thread.Sleep(3);
                            /*timeLeft = 600;
                            timer1.Tick += Timer_Tick;*/
                            Task.Delay(3).Wait();
                            form1.Invoke((MethodInvoker)delegate
                            {
                                tmpNode.button.BackColor = Color.Bisque;
                            });
                            if (!nodesToProcess.Any(LinqNode => LinqNode == tmpNode))
                            {
                                nodesToProcess.Add(tmpNode);
                            }
                               
                        } 
                    }
                }
            }
            while (endNode.pathLength != 0)
            {
                endNode.button.BackColor = Color.Yellow;
                endNode = endNode.previousNode;
            }
            
        }

        public Node FindStart()
        {
            for(int i = 0; i < X; i++)
            {
                for(int j = 0; j < X; j++)
                {
                    if (nodes[i,j].button.BackColor == Color.Green)
                    {
                        return nodes[i, j];
                    }
                }
            }
            return null;
        }
        public Node FindEnd()
        {
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    if (nodes[i, j].button.BackColor == Color.Blue)
                    {
                        return nodes[i, j];
                    }
                }
            }
            return null;
        }


    }
}
