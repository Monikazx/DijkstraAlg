using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DijkstraAlg
{
    public partial class Form1 : Form
    {

        public static Node[,] nodes;
        public static Button startField;
        public static Button endField;
        public static int[,] graph;
        public static int X = 20;

        public ClickBehaviorEnum clickBehavior;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            nodes = new Node[X, X];
            InitializeButtonArray();
            this.MinimumSize = new System.Drawing.Size(this.Width, this.Height);
            this.AutoSize = true;


        }

        /*
          GREEN - ending
          BLUE - start
          BLACK - obstacle 
        */

        private void InitializeButtonArray()
        {
            flowLayoutPanel1.Size = new Size(X * 30, X * 30);
            for (int i = 0; i < X; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Button button = new Button();
                    button.BackColor = Color.White;
                    button.Size = new Size(20, 20);
                    button.MouseDown += Button_Click;
                    flowLayoutPanel1.Controls.Add(button);
                    if (j == X - 1)
                    {
                        flowLayoutPanel1.SetFlowBreak(button, true);
                    }
                    nodes[i, j] = new Node(button,new Point(i,j));
                }
            }
        }


        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (clickBehavior)
           {
               case ClickBehaviorEnum.Start:
                    if (startField != null)
                    {
                        startField.BackColor = Color.White;
                    }
                    startField = button;
                    button.BackColor = Color.Green;
                    break;
                case ClickBehaviorEnum.End:
                    if (endField != null)
                    {
                        endField.BackColor = Color.White;
                    }
                    endField = button;
                    button.BackColor = Color.Blue;
                    break;
                case ClickBehaviorEnum.Obstacle:
                    button.BackColor = button.BackColor == Color.Black ? Color.White : Color.Black;
                    break;
                default:
                    break;
           }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (startField == null || endField == null)
            {
                return;
            }
            Dijkstra dijkstra = new Dijkstra(nodes, X);
            dijkstra.DijkstraAlg(this);


        }
        private void buttonObstacle_Click(object sender, EventArgs e)
        {
            clickBehavior = ClickBehaviorEnum.Obstacle;
        }
        private void buttonStartingField_Click(object sender, EventArgs e)
        {
            clickBehavior = ClickBehaviorEnum.Start;
        }
        private void buttonEndingField_Click(object sender, EventArgs e)
        {
            clickBehavior = ClickBehaviorEnum.End;
        }

        private void reloadButton_Click(object sender, EventArgs e)
        {
            startField = null;
            endField = null;
            foreach(Node node in nodes)
            {
                node.button.BackColor = Color.White;
                node.pathLength = int.MaxValue;
                node.previousNode = null;
                node.isProcessed = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
/*
 *  GREEN - ending 
 *  BLUE - start
 *  BLACK - obstacle
*/