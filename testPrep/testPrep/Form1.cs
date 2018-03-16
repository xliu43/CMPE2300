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
            if (!pointLinkedList.Contains(pos))
            {
                pointLinkedList.AddLast(pos);
                LinkedListNode<Point> node = pointLinkedList.First;

            }
        }


       
    }
}
