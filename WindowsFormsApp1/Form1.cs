using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /*private void OnClick(object sender, EventArgs e)
        {
            MessageBox.Show(((MouseEventArgs)e).X.ToString() + "  :  " + ((MouseEventArgs)e).Y.ToString());
        }
        */
        private void ButtonClick(object sender, KeyEventArgs e)
        {
            
        }

        private void ButtonClick2(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Text = "";
        }
    }
}
