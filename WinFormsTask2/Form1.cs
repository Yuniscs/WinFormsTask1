using System;
using System.Windows.Forms;

namespace WinFormsTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string c = textBox1.Text.Replace(",", "\t");
            listBox1.Items.Add(c);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int se = listBox1.SelectedIndex;
            if (se != -1)
            {
                listBox1.Items.RemoveAt(se);
            }
            else
            {
                MessageBox.Show("Seçim et");
            }
        }
    }
}
