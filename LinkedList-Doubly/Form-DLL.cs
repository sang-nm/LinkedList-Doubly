using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList_Doubly
{
    public partial class LinkedListDB : Form
    {
        public LinkedListDB()
        {
            InitializeComponent();
        }

        LinkedListDoubly.LinkedList_Doubly LLDB = new LinkedListDoubly.LinkedList_Doubly();

        Button[] bt;
        Point startpoint, endpoint;
        private void button1_Click(object sender, EventArgs e)
        {
            Point pt = Cursor.Position;
            startpoint = pt;
            endpoint = pt   ;
            string[] arr = textBox1.Text.Split(';');
            Array.Sort(arr);
            bt = new Button[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                bt[i] = new Button();
                this.Controls.Add(bt[i]);
                bt[i].Location = new Point(50 + i * 50, 200);
                bt[i].Name = "button" + i;
                bt[i].Size = new Size(50, 30);
                bt[i].TabIndex = i;
                bt[i].Text = arr[i];
                bt[i].UseVisualStyleBackColor = true;
                //bt[i].Click += new System.EventHandler(this.button1_Click);
                System.Drawing.Pen myPen;
                myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
                System.Drawing.Graphics formGraphics = this.CreateGraphics();
                formGraphics.DrawLine(myPen, 0, 0, 200, 200);
                myPen.Dispose();
                formGraphics.Dispose();
            }
        }
    }
}

