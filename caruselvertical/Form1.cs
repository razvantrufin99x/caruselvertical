using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace caruselvertical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            while( i < 20){
            elementcarusel1.Top -= i;
            elementcarusel2.Top = elementcarusel1.Top + elementcarusel1.Height + 6;
            elementcarusel3.Top = elementcarusel2.Top + elementcarusel2.Height + 6;
            elementcarusel4.Top = elementcarusel3.Top + elementcarusel3.Height + 6;
            elementcarusel5.Top = elementcarusel4.Top + elementcarusel4.Height + 6;
            i+=5;
            Thread.Sleep(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            while (i < 20)
            {
                elementcarusel1.Top += i;
                elementcarusel2.Top = elementcarusel1.Top + elementcarusel1.Height + 6;
                elementcarusel3.Top = elementcarusel2.Top + elementcarusel2.Height + 6;
                elementcarusel4.Top = elementcarusel3.Top + elementcarusel3.Height + 6;
                elementcarusel5.Top = elementcarusel4.Top + elementcarusel4.Height + 6;
                i+=5;
                Thread.Sleep(100);
            } 
        }
    }
}
