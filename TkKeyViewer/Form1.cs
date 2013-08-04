using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TkKeyViewer
{
    public partial class Form1 : Form
    {

        String BasicLabel = "Bitte Taste drücken!";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = e.KeyData.ToString();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = BasicLabel;
        }
    }
}
