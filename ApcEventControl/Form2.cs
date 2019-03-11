using System;
using System.Windows.Forms;

namespace ApcEventControl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form2_Load");
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Form2_FormClosing");
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Form2_Shown");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form2_FormClosed");
        }
    }
}
