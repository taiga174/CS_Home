using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                TestButton testButton = new TestButton(i,(i % 5) * 100, (i / 5) * 100, 100, 100);
                Controls.Add(testButton);
            }

            TestLabel testLabel = new TestLabel("ラベル",10,300,100,500);
            Controls.Add(testLabel);

            //Label label = new Label();
            //label.Location = new Point(30,400);
            //label.Text = "ラベル";
            //Controls.Add(label);

            //TestButton testButton = new TestButton(0,0,100,100);
            //Controls.Add(testButton);
            //
            //TestButton testButton2 = new TestButton(10,10,100,100);
            //Controls.Add(testButton2);
            //
            //TestButton testButton3 = new TestButton(20, 20, 100, 100);
            //Controls.Add(testButton3);
            //
            //TestButton testButton4 = new TestButton(30, 30, 100, 100);
            //Controls.Add(testButton4);
            //
            //TestButton testButton5 = new TestButton(40, 40, 100, 100);
            //Controls.Add(testButton5);
            //
            //TestButton testButton6 = new TestButton(50, 50, 100, 100);
            //Controls.Add(testButton6);
            //
            //TestButton testButton7 = new TestButton(60, 60, 100, 100);
            //Controls.Add(testButton7);
            //
            //TestButton testButton8 = new TestButton(70, 70, 100, 100);
            //Controls.Add(testButton8);
            //
            //TestButton testButton9 = new TestButton(80, 80, 100, 100);
            //Controls.Add(testButton9);
            //
            //TestButton testButton10 = new TestButton(90, 90, 100, 100);
            //Controls.Add(testButton10);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
