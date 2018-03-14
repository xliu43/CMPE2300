using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace testprep
{
    public partial class Form1 : Form
    {
        CDrawer drawer = new CDrawer(800,600,true);
        LinkedList<Point> pointLinkedList = new LinkedList<Point>();
        Queue<Point> pointQueue = new Queue<Point>();
        public Form1()
        {
            InitializeComponent();
            drawer.MouseLeftClick += Drawer_MouseLeftClick;
        }

        private void Drawer_MouseLeftClick(Point pos, CDrawer dr)
        {
            pointLinkedList.AddLast(pos);
            pointQueue.Enqueue(pos);
            Render();
        }


        private void Render()
        {
            LinkedListNode<Point> nodePoint;
            nodePoint = pointLinkedList.First;
            while (nodePoint!=null &&nodePoint.Next!=null)
            {
                drawer.AddLine(nodePoint.Value.X, nodePoint.Value.Y, nodePoint.Next.Value.X, nodePoint.Next.Value.Y,Color.Red,5);
                nodePoint = nodePoint.Next;
                if (nodePoint.Next != null && nodePoint.Next.Next == null)
                {
                    drawer.AddLine(nodePoint.Value.X, nodePoint.Value.Y, nodePoint.Next.Value.X, nodePoint.Next.Value.Y, Color.Red, 5);
                }
                else
                    nodePoint = nodePoint.Next;

            }
            if (pointQueue.Count>1)
            {
                Point lastPoint = new Point(-1, -1);
                Point startPoint = new Point(-1, -1);
                
                lastPoint = pointQueue.Dequeue();

                drawer.AddLine(startPoint.)

            }



        }
    }
}
