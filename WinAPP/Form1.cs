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
            string x = ("");
            string y = textBox2.Text;
            textBox1.Text = y;
            textBox2.Text = x;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string j = ("");
            string k = textBox1.Text;
            textBox2.Text = k;
            textBox1.Text = j;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string z = textBox1.Text;
            string h = textBox2.Text;
            textBox1.Text = h;
            textBox2.Text = z;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string s = ("");
            textBox1.Text = s;
            textBox2.Text = s;
        }
    }
}
