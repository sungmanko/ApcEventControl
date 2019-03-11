using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApcEventControl
{
    public partial class Form1 : Form
    {
        Form2 fm2;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fm2 = new Form2();
            fm2.WindowState = FormWindowState.Minimized;
            fm2.ShowDialog();

            fm2.ShowInTaskbar = false;

            fm2.Hide();
        }

        private int XXX()
        {
            fm2 = new Form2();
            fm2.FormClosed += Fm2_FormClosed;
            fm2.WindowState = FormWindowState.Minimized;
            fm2.ShowInTaskbar = false;
            fm2.Show();

            var task = Task.Run(() =>
            {
                while (fm2 != null)
                {
                    System.Threading.Thread.Sleep(100);
                }

                string a = "";

                MessageBox.Show("1");
                MessageBox.Show("2");
                MessageBox.Show("3");
                
                if (a == string.Empty)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            });

            return 9;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(XXX().ToString());
        }
        
        private void Fm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            fm2 = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fm2 = new Form2();
            fm2.WindowState = FormWindowState.Minimized;
            fm2.Hide();
            fm2.ShowInTaskbar = false;
            fm2.Show();

            MessageBox.Show("1");
            MessageBox.Show("2");
            MessageBox.Show("3");
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            fm2.Close();
        }
    }
}
