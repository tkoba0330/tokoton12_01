using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tokoton12_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Thread t;

        private void Form1_Load(object sender, EventArgs e)
        {
            t = new Thread((x) =>
            {
                for (;;)
                {
                    Action a = () =>
                    {
                        label1.Text = DateTime.Now.Second.ToString();
                    };
                    Invoke(a);
                    Thread.Sleep(1000);
                }
            });
            t.Start();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            t.Abort();
        }
    }
}
