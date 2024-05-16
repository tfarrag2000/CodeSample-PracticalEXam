namespace WinAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string c5 = ("");
            string c1 = textBox2.Text;
            textBox1.Text = c1;
            textBox2.Text = c5;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string c5 = ("");
            string c2 = textBox1.Text;
            textBox2.Text = c2;
            textBox1.Text = c5;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string c2 = textBox1.Text;
            string c3 = textBox2.Text;
            textBox1.Text = c3;
            textBox2.Text = c2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string c5 = ("");
            textBox1.Text= c5;
            textBox2.Text= c5;
        }
    }
}
