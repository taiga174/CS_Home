﻿using System;
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

            TestButton testButton = new TestButton();

            Controls.Add(testButton);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
