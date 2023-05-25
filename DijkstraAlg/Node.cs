using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraAlg
{
    public class Node
    {
        public Button button;
        public Node previousNode;
        public int pathLength;
        public bool isProcessed;
        public Point coordinates;
        public bool isObstacle
        {
            get { return button.BackColor == Color.Black; }
        }
        public Node(Button button, Point coordinates)
        {
            this.button = button;
            this.pathLength = int.MaxValue;
            this.previousNode = previousNode;
            this.isProcessed = false;
            this.coordinates = coordinates;
        }

    }
}
