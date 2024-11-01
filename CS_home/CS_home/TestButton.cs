using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace CS_home
{
     class TestButton : Button
    {
        public TestButton(int x, int y, int width, int height) 
        {
            Click += OnClick;

            Text = "ボタン";

            Location = new Point(x,y);
            Size = new Size(width,height);
        }

        public void OnClick(object sender,EventArgs s) 
        {
            MessageBox.Show("hello");
        }
    }
}
