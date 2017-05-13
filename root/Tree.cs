using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace root
{



    public partial class Tree : Form
    {
        
        private Node n1 = new Node(50, 50);
        private Node n2 = new Node(160, 150);
        private Node n3 = new Node(302, 100);
        private List<Node> lst = new List<Node>();


        private Node m_root;

        public void TestInit()
        {
            m_root.add(new Node(130, 20, 1, m_root, new List<Node>(10)));
            m_root.add(new Node(200, 30, 2, m_root, new List<Node>(10)));
            //Node parrent = getNode(1, m_root);
            //Node n2 = new Node(250, 50, 3, getNode(1, m_root), new List<Node>(10));
            addChild(1, new Node(60, 50, 3, getNode(1, m_root), new List<Node>(10)));
            addChild(1, new Node(130, 70, 4, getNode(1, m_root), new List<Node>(10)));
            addChild(1, new Node(160, 79, 5, getNode(1, m_root), new List<Node>(10)));
            addChild(2, new Node(200, 91, 6, getNode(2, m_root), new List<Node>(10)));
        }

        public Tree()
        {
            InitializeComponent();
        }

        public Tree(Node root)
        {
            InitializeComponent();
            m_root = root;
            TestInit();
        }

        public Node getRoot()
        {
            return m_root;
        }


        private void drawLineBetweenNodes(Node a, Node b)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Brushes.Black);
            p.Width = 3;
            g.DrawLine(p, new Point(a.x, a.y), new Point(b.x, b.y));
        }

        private void drawNode(Node a)
        {
            Graphics g = this.CreateGraphics();
            
            Pen p = new Pen(Brushes.Red);

            g.FillEllipse(Brushes.Red, new RectangleF(a.x - 10, a.y - 10, 20, 20));
        }

        public void printInfo(Node root)
        {
            drawNode(root);
            foreach (Node child in root.getChildren())
            {
                drawLineBetweenNodes(root, child);
                printInfo(child);
            }
        }

        public Node getNode(int key, Node node)
        {
            if (node.getKey() == key)
            {
                return node;
            }
            List<Node> chil = node.getChildren();
            foreach (Node child in chil)
            {
                Node a = getNode(key, child);
                if (a != null)
                    return a;
            }
            return null;
        }

        public void addChild(int key, Node node)
        {
            getNode(key, getRoot()).getChildren().Add(node);
        }


        private void Tree_Paint(object sender, PaintEventArgs e)
        {
            printInfo(getRoot());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public Node getNodeByCoordinates(int px, int py, Node node)
        {
            if (px >= node.getX() - node.getRadius() && px <= node.getX() + node.getRadius() && py >= node.getY() - node.getRadius() && py <= node.getY() + node.getRadius())
            {
                return node;
            }
            List<Node> chil = node.getChildren();
            foreach (Node child in chil)
            {
                Node a = getNodeByCoordinates(px, py, child);
                if (a != null)
                    return a;
            }
            return null;
        }
    }
}
