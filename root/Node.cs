using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace root
{
    public class Node
    {
        public int x, y;
        private int m_key;
        private Node m_parent;
        private List<Node> m_children = new List<Node>(100);
        private int state=1;
        private int radius = 10;

        public Node()
        {

        }

        public Node getParrent()
        {
            return m_parent;
        }

        public Node(int a, int b, int info = 0)
        {
            x = a;
            y = b;
        }

        public int getRadius()
        {
            return radius;
        }

        public Node(int a, int b, int key, Node parent, List<Node> children)
        {
            x = a;
            y = b;
            m_key = key;
            m_parent = parent;
            m_children = children;
        }
        public int getState()
        {
            return state;
        }

        public void setState(int st)
        {
            state = st;
        }

        public Node(Node node)
        {
            m_key = node.m_key;
            m_parent = node.m_parent;
            m_children = node.m_children;
        }

        public int getKey()
        {
            return m_key;
        }

        public void add(Node child)
        {
            m_children.Add(child);
        }

        public List<Node> getChildren()
        {
            return m_children;
        }
        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }
    }
}
