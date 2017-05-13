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

    enum States
    {
        AVAILABLE, UNAVAILABLE, ON_PROGRES
    }

    public partial class Tree : Form
    {
        
        private List<Node> lst = new List<Node>();


        private Node m_root;
        private int addFlag = 0;
        private int keyFlag = 0;
        int nodes = 7;

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
            Brush p = Brushes.Red;
            if (a.getState() == 0)
                p = Brushes.Green;
            if (a.getState() == 1)
                p = Brushes.Gray;
            if (a.getState() == 2)
                p = Brushes.Yellow;
            int rad = a.getRadius();

            g.FillEllipse(p, new RectangleF(a.x - rad, a.y - rad, rad * 2, rad * 2));
        }

        public void printInfo(Node root)
        {
            
            foreach (Node child in root.getChildren())
            {
                drawLineBetweenNodes(root, child);
                printInfo(child);
            }
            drawNode(root);
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

        private void Tree_MouseDown(object sender, MouseEventArgs e)
        {
            Node a = getNodeByCoordinates(e.X, e.Y, getRoot());

            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        if (a != null)
                        {
                            int state = a.getState();
                            a.setState((state + 1) % 3);
                            if (a.getState() == (int)States.AVAILABLE)
                            {
                                foreach (Node chile in a.getChildren())
                                {
                                    chile.setState((int)States.ON_PROGRES);
                                    drawNode(chile);
                                }
                            }
                            drawNode(a);
                            break;
                        }
                        break;
                    }
                case MouseButtons.Left:
                    {
                        //MessageBox.Show("left\ny:" + e.X.ToString() + "\ny: " + e.Y.ToString());

                        if(a == null)
                        {
                            if (addFlag == 1)
                            {
                                //MessageBox.Show("flag worked");
                                Node parrent = getNode(keyFlag, getRoot());
                                Node n = new Node(e.X, e.Y, nodes, parrent, new List<Node>());
                                n.setState((int)States.UNAVAILABLE);
                                nodes++;
                                addChild(keyFlag, n);
                                
                                drawLineBetweenNodes(n, parrent);
                                drawNode(parrent);
                                drawNode(n);
                                addFlag = 0;
                            }
                        }

                        if (a != null)
                        {
                            if (addFlag == 0)
                            {
                                ContextMenu c = new ContextMenu();
                                MenuItem it1 = new MenuItem("Add", menu_Add_Click);
                                c.MenuItems.Add(it1);
                                c.MenuItems.Add("view");
                                c.Show(this, e.Location);
                                keyFlag = a.getKey();


                                if (addFlag == 1)
                                {
                                    //MessageBox.Show("click worked");

                                }
                            }
                        }
                        break;
                    }
            }
            
        }

        void menu_Add_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("add workded");
            MenuItem m = (MenuItem)sender;
            addFlag = 1;

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
